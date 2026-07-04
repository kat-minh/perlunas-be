using Microsoft.AspNetCore.Http;

namespace Cms.Service.CloudinaryService;

public interface IService
{
    Task<Response.UploadResponse> UploadImageAsync(IFormFile file);
}
