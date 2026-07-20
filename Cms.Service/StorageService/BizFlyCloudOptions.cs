using System.ComponentModel.DataAnnotations;

namespace Cms.Service.StorageService;

/// <summary>
/// Cấu hình lưu trữ ảnh trên BizFly Cloud Simple Storage (S3-compatible).
/// Nạp từ section "BizFlyCloudOptions" (env: BizFlyCloudOptions__AccessKey, ...).
/// Dùng để sinh presigned PUT URL cho client upload ảnh thẳng lên bucket (không qua server).
/// </summary>
public class BizFlyCloudOptions
{
    /// <summary>Access key (Application Credential) do BizFly cấp.</summary>
    [Required] public string AccessKey { get; set; } = string.Empty;

    /// <summary>Secret key (Application Credential) do BizFly cấp.</summary>
    [Required] public string SecretKey { get; set; } = string.Empty;

    /// <summary>Endpoint S3 của BizFly, vd https://hcm.ss.bfcplatform.vn</summary>
    [Required] public string ServiceUrl { get; set; } = string.Empty;

    /// <summary>Tên bucket chứa ảnh.</summary>
    [Required] public string BucketName { get; set; } = string.Empty;
}
