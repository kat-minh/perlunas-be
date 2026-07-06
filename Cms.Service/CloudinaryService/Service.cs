using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Cms.Service.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Cms.Service.CloudinaryService;

public class Service : IService
{
    // Giới hạn 10 MB — đủ cho ảnh web, tránh nuốt file lớn/nhầm.
    private const long MaxFileBytes = 10 * 1024 * 1024;
    private static readonly string[] AllowedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".webp" };

    private readonly CloudinaryOptions _options;
    private Cloudinary? _cloudinary;

    public Service(IConfiguration configuration)
    {
        _options = new CloudinaryOptions();
        configuration.GetSection(nameof(CloudinaryOptions)).Bind(_options);
        // Lazy: only init Cloudinary when fully configured.
        // Missing env (CloudName/ApiKey/ApiSecret) -> constructor does NOT throw (DI register OK);
        // ServerException is raised clearly only when UploadImageAsync is actually called.
        if (!string.IsNullOrWhiteSpace(_options.CloudName)
            && !string.IsNullOrWhiteSpace(_options.ApiKey)
            && !string.IsNullOrWhiteSpace(_options.ApiSecret))
        {
            _cloudinary = new Cloudinary(new Account(_options.CloudName, _options.ApiKey, _options.ApiSecret));
        }
    }

    public async Task<Response.UploadResponse> UploadImageAsync(IFormFile file)
    {
        // Chưa cấu hình Cloudinary (thiếu env) → lỗi máy chủ rõ ràng thay vì lỗi khó hiểu.
        if (string.IsNullOrWhiteSpace(_options.CloudName)
            || string.IsNullOrWhiteSpace(_options.ApiKey)
            || string.IsNullOrWhiteSpace(_options.ApiSecret))
            throw new ServerException("Dịch vụ tải ảnh chưa được cấu hình (Cloudinary).");

        // Lỗi phía người dùng → 400 (trước đây ném ArgumentException nên bị map thành 500).
        if (file == null || file.Length == 0)
            throw new BadRequestException("Chưa chọn ảnh hoặc ảnh rỗng.");

        if (file.Length > MaxFileBytes)
            throw new BadRequestException("Ảnh vượt quá dung lượng tối đa 10 MB.");

        if (!IsImageFile(file))
            throw new BadRequestException("Định dạng ảnh không hợp lệ (chỉ nhận jpg, jpeg, png, gif, webp).");

        ImageUploadResult uploadResult;
        try
        {
            await using var stream = file.OpenReadStream();
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(file.FileName, stream),
            };
            uploadResult = await _cloudinary!.UploadAsync(uploadParams);
        }
        catch (Exception ex)
        {
            // Lỗi mạng/SDK khi gọi Cloudinary → 502 (dịch vụ ngoài), không phải 500 mù.
            throw new BadGatewayException($"Không kết nối được dịch vụ tải ảnh: {ex.Message}");
        }

        // Cloudinary trả lỗi trong kết quả (không throw) — trước đây .SecureUrl null gây NRE→500.
        if (uploadResult.Error != null)
            throw new BadGatewayException($"Tải ảnh thất bại: {uploadResult.Error.Message}");

        if (uploadResult.SecureUrl == null)
            throw new BadGatewayException("Dịch vụ tải ảnh không trả về đường dẫn ảnh.");

        return new Response.UploadResponse { Url = uploadResult.SecureUrl.ToString() };
    }

    private static bool IsImageFile(IFormFile file)
    {
        var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
        var extOk = AllowedExtensions.Contains(extension);
        // Content-type là gợi ý phụ: chấp nhận image/* hoặc generic (octet-stream/rỗng),
        // chỉ chặn khi client khai rõ là loại KHÁC (vd application/pdf).
        var contentType = file.ContentType ?? string.Empty;
        var typeOk = string.IsNullOrEmpty(contentType)
            || contentType.StartsWith("image/", StringComparison.OrdinalIgnoreCase)
            || contentType.Equals("application/octet-stream", StringComparison.OrdinalIgnoreCase);
        return extOk && typeOk;
    }
}
