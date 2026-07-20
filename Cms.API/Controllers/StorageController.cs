using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StorageService = Cms.Service.StorageService;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/storage")]
public class StorageController : ControllerBase
{
    private readonly StorageService.IService _storageService;

    public StorageController(StorageService.IService storageService)
    {
        _storageService = storageService;
    }

    public record DeleteFileRequest(string Url);

    /// <summary>
    /// GET /api/storage/presigned-url — Xin URL có chữ ký để upload ảnh thẳng lên BizFly Cloud.
    /// Client sau đó PUT raw binary ảnh lên <c>presignedUrl</c> với đúng header Content-Type, rồi dùng <c>fileUrl</c>.
    /// </summary>
    [HttpGet("presigned-url")]
    [Authorize]
    public async Task<IActionResult> GetPresignedUrl(
        [FromQuery] string contentType, [FromQuery] string? fileName, CancellationToken ct)
    {
        var result = await _storageService.CreatePresignedImageUploadAsync(contentType, fileName, ct);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    /// <summary>POST /api/storage/delete — Xoá ảnh khỏi bucket theo URL công khai.</summary>
    [HttpPost("delete")]
    [Authorize]
    public async Task<IActionResult> Delete([FromBody] DeleteFileRequest request)
    {
        await _storageService.RemoveFileByUrlAsync(request.Url);
        return Ok(ApiResponseFactory.Base(new { }, true, "", HttpContext.TraceIdentifier));
    }
}
