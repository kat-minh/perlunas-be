using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;

namespace Cms.Service.MailService;

public class Service: IService
{
    
    private readonly MailOptions _mailOptions = new ();
    
    public Service(IConfiguration configuration)
    {
        configuration.GetSection(nameof(MailOptions)).Bind(_mailOptions);
    }
    
    public async Task SendMail(MailContent mailContent)
    {
        // Best-effort: chưa cấu hình mail (thiếu env Host/Mail) → bỏ qua gửi, KHÔNG
        // được làm hỏng luồng đã lưu form. Khi có env thì gửi bình thường.
        if (string.IsNullOrWhiteSpace(_mailOptions?.Mail) || string.IsNullOrWhiteSpace(_mailOptions?.Host))
            return;

        try
        {
            MimeMessage email = new();
            email.Sender = new MailboxAddress(_mailOptions.DisplayName, _mailOptions.Mail);
            email.From.Add(new MailboxAddress(_mailOptions.DisplayName, _mailOptions.Mail));
            email.To.Add(MailboxAddress.Parse(mailContent.To));
            email.Subject = mailContent.Subject;

            BodyBuilder builder = new();
            builder.HtmlBody = mailContent.Body;
            email.Body = builder.ToMessageBody();

            using SmtpClient smtp = new();
            await smtp.ConnectAsync(_mailOptions.Host, _mailOptions.Port, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_mailOptions.Mail, _mailOptions.Password);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
        catch (Exception ex)
        {
            // Lỗi SMTP/mạng không được chặn việc đăng ký đã lưu thành công.
            Console.Error.WriteLine($"[mail] send failed (best-effort): {ex.Message}");
        }
    }
}