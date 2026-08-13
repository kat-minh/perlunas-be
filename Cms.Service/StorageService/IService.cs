namespace Cms.Service.StorageService;

/// <summary>Lưu trữ ảnh trên BizFly Cloud (S3-compatible) qua presigned URL — client upload thẳng, không qua server.</summary>
public interface IService
{
    /// <summary>
    /// High-level: kiểm tra tệp hợp lệ (ảnh hoặc video nền), sinh object key, trả presigned PUT URL
    /// + thông tin để client upload thẳng lên bucket.
    /// </summary>
    Task<Response.PresignedUploadResponse> CreatePresignedImageUploadAsync(string contentType, string? fileName = null, CancellationToken ct = default);

    /// <summary>Low-level: sinh presigned PUT URL cho một object key + content-type cụ thể.</summary>
    Task<string> GeneratePresignedUrlAsync(string key, string contentType, int expiresMinutes = 5);

    /// <summary>Xoá object khỏi bucket theo key (bỏ qua nếu không tồn tại).</summary>
    Task RemoveFileInStorageAsync(string key);

    /// <summary>Xoá object khỏi bucket theo URL công khai (bỏ qua nếu URL không thuộc bucket).</summary>
    Task RemoveFileByUrlAsync(string url);
}
