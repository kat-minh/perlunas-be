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

    private static Cms.Service.CloudinaryService.Service CreateService() =>
        new(ConfigWithCloudinary());

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

    // ===== UploadImageAsync — Validation (không cần gọi Cloudinary thật) =====

    [Fact]
    public async Task UploadImageAsync_WithNullFile_ShouldThrow()
    {
        var svc = CreateService();

        var act = () => svc.UploadImageAsync(null!);

        await act.Should().ThrowAsync<ArgumentException>()
            .WithMessage("*File is empty or null*");
    }

    [Fact]
    public async Task UploadImageAsync_WithEmptyFile_ShouldThrow()
    {
        var svc = CreateService();
        var file = FakeFormFile("photo.jpg", "image/jpeg", Array.Empty<byte>());

        var act = () => svc.UploadImageAsync(file);

        await act.Should().ThrowAsync<ArgumentException>()
            .WithMessage("*File is empty or null*");
    }

    [Theory]
    [InlineData("document.pdf")]
    [InlineData("archive.zip")]
    [InlineData("movie.mp4")]
    [InlineData("song.mp3")]
    [InlineData("noextension")]
    public async Task UploadImageAsync_WithNonImageExtension_ShouldThrow(string fileName)
    {
        var svc = CreateService();
        var file = FakeFormFile(fileName, "application/octet-stream");

        var act = () => svc.UploadImageAsync(file);

        await act.Should().ThrowAsync<ArgumentException>()
            .WithMessage("*File is not an image*");
    }

    // ===== IsImageFile (qua hành vi UploadImageAsync) — định dạng được phép =====
    // Lưu ý: các test dưới đây để file đi qua validation rồi mới gọi Cloudinary thật.
    // Vì không có network/credentials thật, Cloudinary sẽ ném lỗi kết nối — ta chỉ kiểm tra
    // rằng exception KHÔNG phải là "File is empty" hay "File is not an image" (nghĩa là file
    // đã được chấp nhận về định dạng). Điều này vẫn xác nhận được nhánh IsImageFile = true.

    [Theory]
    [InlineData("photo.jpg")]
    [InlineData("photo.jpeg")]
    [InlineData("photo.png")]
    [InlineData("photo.gif")]
    [InlineData("photo.webp")]
    [InlineData("PHOTO.JPG")]     // kiểm tra case-insensitive
    [InlineData("Photo.PNG")]
    public async Task UploadImageAsync_WithAllowedImageExtension_ShouldPassFormatCheck(string fileName)
    {
        var svc = CreateService();
        var file = FakeFormFile(fileName, "image/jpeg");

        // Cloudinary thật sẽ ném (không có network) — nhưng không phải lỗi định dạng file.
        var thrown = await FluentActions.Awaiting(() => svc.UploadImageAsync(file))
            .Should().ThrowAsync<Exception>();

        // File đã qua bước kiểm tra định dạng: exception ném ra KHÔNG chứa thông điệp validate.
        thrown.Which.Message.Should().NotContain("File is not an image");
        thrown.Which.Message.Should().NotContain("File is empty or null");
    }

    [Fact]
    public async Task UploadImageAsync_WithDotJpgButPdfContent_ShouldStillPassFormatCheck()
    {
        // IsImageFile chỉ kiểm tra phần mở rộng, KHÔNG kiểm tra nội dung/magic-bytes.
        var svc = CreateService();
        var file = FakeFormFile("trick.jpg", "application/pdf", "%PDF-1.4 fake"u8.ToArray());

        var thrown = await FluentActions.Awaiting(() => svc.UploadImageAsync(file))
            .Should().ThrowAsync<Exception>();

        thrown.Which.Message.Should().NotContain("File is not an image");
        thrown.Which.Message.Should().NotContain("File is empty or null");
    }

    // ===== Constructor / Cấu hình =====

    [Fact]
    public void Constructor_WithMissingCloudName_ShouldThrowArgumentException()
    {
        // CloudinaryOptions binding rỗng → Account("","","") → thư viện CloudinaryDotNet ném
        // "Cloud name must be specified in Account!" ở constructor.
        var config = new DictionaryConfiguration(new Dictionary<string, string?>());

        var act = () => new Cms.Service.CloudinaryService.Service(config);

        act.Should().Throw<ArgumentException>()
            .WithMessage("*Cloud name must be specified*");
    }

    [Fact]
    public void Constructor_WithValidConfig_ShouldInstantiate()
    {
        var act = () => CreateService();

        act.Should().NotThrow();
    }
}
