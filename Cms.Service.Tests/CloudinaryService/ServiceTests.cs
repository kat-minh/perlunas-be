using Cms.Service.Exceptions;
using Cms.Service.Tests.TestHelper;
using Cms.Service.CloudinaryService;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Moq;

namespace Cms.Service.Tests.CloudinaryService;

public class ServiceTests
{
    private static IConfiguration ConfigWithCloudinary() =>
        new DictionaryConfiguration(new Dictionary<string, string?>
            {
                ["CloudinaryOptions:CloudName"] = "demo-cloud",
                ["CloudinaryOptions:ApiKey"] = "123456789012345",
                ["CloudinaryOptions:ApiSecret"] = "secret-key-value"
            });

    private static IConfiguration EmptyConfig() =>
        new DictionaryConfiguration(new Dictionary<string, string?>());

    private static Cms.Service.CloudinaryService.Service CreateService() =>
        new(ConfigWithCloudinary());

    private static Cms.Service.CloudinaryService.Service CreateServiceWithoutConfig() =>
        new(EmptyConfig());

    /// <summary>
    /// Tạo một IFormFile giả với nội dung byte + tên file cho trước.
    /// </summary>
    private static IFormFile FakeFormFile(string fileName, string contentType, byte[]? content = null)
    {
        content ??= "fake-image-content"u8.ToArray();
        var stream = new MemoryStream(content);
        var mock = new Mock<IFormFile>();
        mock.Setup(f => f.FileName).Returns(fileName);
        mock.Setup(f => f.Length).Returns(content.Length);
        mock.Setup(f => f.ContentType).Returns(contentType);
        mock.Setup(f => f.OpenReadStream()).Returns(stream);
        mock.Setup(f => f.CopyToAsync(It.IsAny<Stream>(), It.IsAny<CancellationToken>()))
            .Returns<Stream, CancellationToken>((s, _) => s.WriteAsync(content).AsTask());
        return mock.Object;
    }

    // ===== UploadImageAsync — cấu hình thiếu (ServerException 500) =====

    [Fact]
    public async Task UploadImageAsync_WhenCloudinaryNotConfigured_ShouldThrowServerException()
    {
        // fix(cloudinary): thiếu env CloudName/ApiKey/ApiSecret -> 500 ServerException rõ ràng.
        var svc = CreateServiceWithoutConfig();
        var file = FakeFormFile("photo.jpg", "image/jpeg");

        var act = () => svc.UploadImageAsync(file);

        await act.Should().ThrowAsync<ServerException>()
            .WithMessage("*chưa được cấu hình*");
    }

    // ===== UploadImageAsync — validation phía người dùng (BadRequestException 400) =====

    [Fact]
    public async Task UploadImageAsync_WithNullFile_ShouldThrowBadRequest()
    {
        var svc = CreateService();

        var act = () => svc.UploadImageAsync(null!);

        await act.Should().ThrowAsync<BadRequestException>()
            .WithMessage("*Chưa chọn ảnh hoặc ảnh rỗng*");
    }

    [Fact]
    public async Task UploadImageAsync_WithEmptyFile_ShouldThrowBadRequest()
    {
        var svc = CreateService();
        var file = FakeFormFile("photo.jpg", "image/jpeg", Array.Empty<byte>());

        var act = () => svc.UploadImageAsync(file);

        await act.Should().ThrowAsync<BadRequestException>()
            .WithMessage("*Chưa chọn ảnh hoặc ảnh rỗng*");
    }

    [Fact]
    public async Task UploadImageAsync_WhenFileExceeds10MB_ShouldThrowBadRequest()
    {
        var svc = CreateService();
        // 10MB + 1 byte -> vượt giới hạn.
        var oversize = new byte[(10 * 1024 * 1024) + 1];
        var file = FakeFormFile("photo.jpg", "image/jpeg", oversize);

        var act = () => svc.UploadImageAsync(file);

        await act.Should().ThrowAsync<BadRequestException>()
            .WithMessage("*vượt quá dung lượng tối đa 10 MB*");
    }
}
