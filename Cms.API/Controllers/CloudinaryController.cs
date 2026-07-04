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

    [HttpPost("upload")]
    [Authorize]
    public async Task<IActionResult> Upload(IFormFile file)
    {
        var result = await _cloudinaryService.UploadImageAsync(file);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }
}
