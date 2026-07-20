namespace Cms.Service.StorageService;

public class Response
{
    /// <summary>
    /// Kết quả xin upload ảnh: client dùng <see cref="PresignedUrl"/> để PUT raw binary ảnh thẳng lên
    /// BizFly, sau đó lưu/đọc ảnh qua <see cref="FileUrl"/>.
    /// </summary>
    public class PresignedUploadResponse
    {
        /// <summary>URL có chữ ký để PUT file (hết hạn sau <see cref="ExpiresInSeconds"/>).</summary>
        public string PresignedUrl { get; set; } = string.Empty;

        /// <summary>Object key trên bucket (đường dẫn lưu trữ).</summary>
        public string Key { get; set; } = string.Empty;

        /// <summary>URL truy cập ảnh sau khi upload thành công.</summary>
        public string FileUrl { get; set; } = string.Empty;

        /// <summary>Content-Type phải set đúng khi PUT (khớp lúc ký).</summary>
        public string ContentType { get; set; } = string.Empty;

        /// <summary>Luôn là "PUT".</summary>
        public string UploadMethod { get; set; } = "PUT";

        /// <summary>Các header bắt buộc khi PUT.</summary>
        public IReadOnlyList<string> RequiredHeaders { get; set; } = Array.Empty<string>();

        /// <summary>Thời gian sống của presigned URL (giây).</summary>
        public int ExpiresInSeconds { get; set; }

        /// <summary>Hướng dẫn upload cho client.</summary>
        public string Instructions { get; set; } = string.Empty;
    }
}
