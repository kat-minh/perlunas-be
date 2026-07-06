using Cms.API.Extentions;
using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CloudinaryService = Cms.Service.CloudinaryService;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/cloudinary")]
public class CloudinaryController : ControllerBase
{
    private readonly CloudinaryService.IService _cloudinaryService;

    public CloudinaryController(CloudinaryService.IService cloudinaryService)
    {
        _cloudinaryService = cloudinaryService;
    }

    public record DeleteImageRequest(string Url);

    [HttpPost("upload")]
    [Authorize]
    public async Task<IActionResult> Upload(IFormFile file)
    {
        var result = await _cloudinaryService.UploadImageAsync(file);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost("delete")]
    [Authorize]
    public async Task<IActionResult> Delete([FromBody] DeleteImageRequest request)
    {
        await _cloudinaryService.DeleteImageByUrlAsync(request.Url);
        return Ok(ApiResponseFactory.Base(new { }, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost("delete-multiple")]
    [Authorize]
    public async Task<IActionResult> DeleteMultiple([FromBody] List<string> urls)
    {
        await _cloudinaryService.DeleteImagesByUrlsAsync(urls);
        return Ok(ApiResponseFactory.Base(new { }, true, "", HttpContext.TraceIdentifier));
    }
}
