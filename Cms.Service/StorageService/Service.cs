using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Cms.Service.Exceptions;
using Microsoft.Extensions.Configuration;

namespace Cms.Service.StorageService;

/// <summary>
/// Lưu trữ ảnh trên BizFly Cloud Simple Storage (S3-compatible) bằng AWS SDK. Sinh presigned PUT URL để client
/// upload ảnh thẳng lên bucket. Đăng ký Singleton (AmazonS3Client thread-safe, tái sử dụng).
/// </summary>
public class Service : IService
{
    /// <summary>Kích thước ảnh tối đa khuyến nghị (10MB) — đưa vào hướng dẫn cho client.</summary>
    private const long MaxImageBytes = 10 * 1024 * 1024;

    /// <summary>Presigned URL sống bao lâu (phút).</summary>
    private const int ExpiresMinutes = 5;

    /// <summary>Tiền tố thư mục cố định cho object key (vd uploads/2026/07/xxxx.jpg).</summary>
    private const string UploadPrefix = "uploads";

    /// <summary>Content-Type ảnh được phép -> phần mở rộng file tương ứng.</summary>
    private static readonly IReadOnlyDictionary<string, string> AllowedImageTypes =
        new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["image/jpeg"] = ".jpg",
            ["image/png"] = ".png",
            ["image/webp"] = ".webp",
            ["image/gif"] = ".gif",
        };

    private readonly BizFlyCloudOptions _options;
    private readonly Lazy<AmazonS3Client> _client;

    public Service(IConfiguration configuration)
    {
        _options = new BizFlyCloudOptions();
        configuration.GetSection(nameof(BizFlyCloudOptions)).Bind(_options);
        // Lazy: thiếu env -> constructor KHÔNG throw (DI đăng ký vẫn OK);
        // ServerException chỉ ném khi thật sự gọi tới storage.
        _client = new Lazy<AmazonS3Client>(CreateClient, LazyThreadSafetyMode.ExecutionAndPublication);
    }

    public async Task<Response.PresignedUploadResponse> CreatePresignedImageUploadAsync(
        string contentType, string? fileName = null, CancellationToken ct = default)
    {
        ct.ThrowIfCancellationRequested();

        var normalized = (contentType ?? string.Empty).Trim().ToLowerInvariant();
        if (!AllowedImageTypes.TryGetValue(normalized, out var extension))
            throw new BadRequestException("Định dạng ảnh không hợp lệ (chỉ nhận image/jpeg, image/png, image/webp, image/gif).");

        var key = BuildObjectKey(extension);
        var presignedUrl = await GeneratePresignedUrlAsync(key, normalized, ExpiresMinutes);

        return new Response.PresignedUploadResponse
        {
            PresignedUrl = presignedUrl,
            Key = key,
            FileUrl = BuildPublicFileUrl(key),
            ContentType = normalized,
            UploadMethod = "PUT",
            RequiredHeaders = new[]
            {
                $"Content-Type: {normalized}",
                "Content-Length: <file-size-in-bytes>",
            },
            ExpiresInSeconds = ExpiresMinutes * 60,
            Instructions =
                "Upload ảnh dạng raw binary bằng method PUT (KHÔNG dùng multipart/form-data). " +
                $"Set đúng header Content-Type = {normalized}. Dung lượng tối đa {MaxImageBytes / (1024 * 1024)}MB. " +
                $"URL hết hạn sau {ExpiresMinutes} phút.",
        };
    }

    public async Task<string> GeneratePresignedUrlAsync(string key, string contentType, int expiresMinutes = ExpiresMinutes)
    {
        var request = new GetPreSignedUrlRequest
        {
            BucketName = _options.BucketName,
            Key = key,
            Verb = HttpVerb.PUT,
            Expires = DateTime.UtcNow.AddMinutes(expiresMinutes),
            ContentType = contentType,
            Protocol = Protocol.HTTPS,
        };

        try
        {
            return await _client.Value.GetPreSignedURLAsync(request);
        }
        catch (AppException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new BadGatewayException($"Không tạo được đường dẫn tải ảnh lên: {ex.Message}");
        }
    }

    public async Task RemoveFileInStorageAsync(string key)
    {
        if (string.IsNullOrWhiteSpace(key)) return;

        try
        {
            await _client.Value.DeleteObjectAsync(new DeleteObjectRequest
            {
                BucketName = _options.BucketName,
                Key = key,
            });
        }
        catch (AmazonS3Exception ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            // File không tồn tại -> bỏ qua.
        }
        catch (AppException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new BadGatewayException($"Không xoá được ảnh trên BizFly Cloud: {ex.Message}");
        }
    }

    public Task RemoveFileByUrlAsync(string url)
    {
        var key = ExtractKey(url);
        return key == null ? Task.CompletedTask : RemoveFileInStorageAsync(key);
    }

    /// <summary>Object key dạng <c>{prefix}/{yyyy}/{MM}/{guid}{ext}</c> — sinh phía server để tránh ghi đè/đường dẫn tuỳ ý.</summary>
    private static string BuildObjectKey(string extension)
    {
        var now = DateTime.UtcNow;
        return $"{UploadPrefix}/{now:yyyy}/{now:MM}/{Guid.NewGuid():N}{extension}";
    }

    /// <summary>URL công khai để đọc ảnh — dựng path-style từ ServiceUrl + bucket.</summary>
    private string BuildPublicFileUrl(string key)
        => $"{_options.ServiceUrl.TrimEnd('/')}/{_options.BucketName}/{key}";

    /// <summary>Lấy lại object key từ URL công khai. Trả null nếu URL không thuộc bucket này.</summary>
    private string? ExtractKey(string url)
    {
        if (string.IsNullOrWhiteSpace(url)) return null;

        var prefix = $"{_options.ServiceUrl.TrimEnd('/')}/{_options.BucketName}/";
        if (!url.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)) return null;

        var key = url[prefix.Length..];
        return string.IsNullOrWhiteSpace(key) ? null : key;
    }

    private AmazonS3Client CreateClient()
    {
        if (string.IsNullOrWhiteSpace(_options.AccessKey) || string.IsNullOrWhiteSpace(_options.SecretKey)
            || string.IsNullOrWhiteSpace(_options.ServiceUrl) || string.IsNullOrWhiteSpace(_options.BucketName))
            throw new ServerException("Dịch vụ lưu trữ ảnh chưa được cấu hình (BizFlyCloudOptions: AccessKey/SecretKey/ServiceUrl/BucketName).");

        AWSConfigsS3.UseSignatureVersion4 = true;
        var config = new AmazonS3Config
        {
            ServiceURL = _options.ServiceUrl,
            ForcePathStyle = true,
        };
        return new AmazonS3Client(_options.AccessKey, _options.SecretKey, config);
    }
}
