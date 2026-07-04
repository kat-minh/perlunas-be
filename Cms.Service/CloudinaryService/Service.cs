using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Cms.Service.CloudinaryService;

public class Service : IService
{
    private readonly Cloudinary _cloudinary;

    public Service(IConfiguration configuration)
    {
        var options = new CloudinaryOptions();
        configuration.GetSection(nameof(CloudinaryOptions)).Bind(options);
        _cloudinary = new Cloudinary(new Account(options.CloudName, options.ApiKey, options.ApiSecret));
    }

    public async Task<Response.UploadResponse> UploadImageAsync(IFormFile file)
    {
        if (file == null || file.Length == 0)
            throw new ArgumentException("File is empty or null", nameof(file));

        if (!IsImageFile(file))
            throw new ArgumentException("File is not an image", nameof(file));

        await using var stream = file.OpenReadStream();
        var uploadParams = new ImageUploadParams
        {
            File = new FileDescription(file.FileName, stream),
        };

        var uploadResult = await _cloudinary.UploadAsync(uploadParams);
        return new Response.UploadResponse { Url = uploadResult.SecureUrl.ToString() };
    }

    private static bool IsImageFile(IFormFile file)
    {
        var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif", ".webp" };
        var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
        return allowedExtensions.Contains(extension);
    }
}
