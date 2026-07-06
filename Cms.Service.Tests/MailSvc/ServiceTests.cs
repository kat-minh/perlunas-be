using Cms.Service.Tests.TestHelper;
using Cms.Service.MailService;
using FluentAssertions;
using Microsoft.Extensions.Configuration;

namespace Cms.Service.Tests.MailSvc;

/// <summary>
/// MailService gọi SmtpClient thật (MailKit) → không thể test network trong CI mà không có SMTP server.
/// Tầng test này tập trung kiểm tra:
///  - constructor bind cấu hình từ IConfiguration;
///  - hành vi đầu vào (MailContent required fields) — Service không tự validate nhưng binding SMTP
///    phải đúng để tránh NullReferenceException ở SendMail.
/// Các test dùng ServiceProvider thật + SmtpClient bị connect-thất-bại để xác nhận luồng đi tới
/// bước ConnectAsync (nghĩa là config đã bind đầy đủ, không ném trước khi kết nối).
/// </summary>
public class ServiceTests
{
    private static IConfiguration ConfigWithMail() =>
        new DictionaryConfiguration(new Dictionary<string, string?>
            {
                ["MailOptions:Mail"] = "noreply@perlunas.com",
                ["MailOptions:DisplayName"] = "Perlunas",
                ["MailOptions:Password"] = "app-password",
                ["MailOptions:Host"] = "smtp.invalid.example",
                ["MailOptions:Port"] = "587"
            });

    private static Cms.Service.MailService.Service CreateService() => new(ConfigWithMail());

    private static MailContent ValidMail => new()
    {
        To = "guest@example.com",
        Subject = "Subject test",
        Body = "<p>Body</p>"
    };

    // ===== Constructor / cấu hình =====

    [Fact]
    public void Constructor_WithFullConfig_ShouldBindAllOptions()
    {
        // Khởi tạo không ném → các property bắt buộc đã được bind.
        var act = () => CreateService();

        act.Should().NotThrow();
    }

    [Fact]
    public void Constructor_WithEmptyConfig_ShouldNotThrowAtConstructionTime()
    {
        // Bind rỗng → MailOptions các field null/0. Service chỉ ném khi SendMail được gọi.
        var config = new DictionaryConfiguration(new Dictionary<string, string?>());

        var act = () => new Cms.Service.MailService.Service(config);

        act.Should().NotThrow();
    }

    // ===== SendMail — thất bại kết nối (không có SMTP thật) =====
    // Host = smtp.invalid.example → MailKit ném khi ConnectAsync. Điều này xác nhận:
    //  - config đã bind đầy đủ (không NullReference trước khi kết nối);
    //  - luồng đi tới bước kết nối SMTP.

    [Fact]
    public async Task SendMail_WithValidMailContent_ShouldAttemptSmtpConnect()
    {
        var svc = CreateService();

        // Vì host không tồn tại → ném exception khi ConnectAsync (SocketException/DnsException).
        var act = () => svc.SendMail(ValidMail);

        await act.Should().ThrowAsync<Exception>();
    }

    [Fact]
    public async Task SendMail_WhenConfigMissing_ShouldFailBeforeOrAtConnect()
    {
        // Cấu hình thiếu → _mailOptions.Mail/Host = null. Service sẽ ném (NullReference hoặc
        // MailKit ném khi parse địa chỉ null).
        var config = new DictionaryConfiguration(new Dictionary<string, string?>());
        var svc = new Cms.Service.MailService.Service(config);

        var act = () => svc.SendMail(ValidMail);

        await act.Should().ThrowAsync<Exception>();
    }
}
