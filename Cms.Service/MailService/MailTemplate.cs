using System.Net;
using System.Text;

namespace Cms.Service.MailService;

/// <summary>
/// Email xác nhận branded Perlunas (HTML inline-style, an toàn cho email client).
/// Dùng chung cho các form: tư vấn / tour / combo / phòng.
/// </summary>
public static class MailTemplate
{
    /// <summary>Logo ngang bản trắng, host tĩnh trên site (public/email) để mọi client tải được.</summary>
    private const string LogoUrl = "https://www.perlunas.com/email/logo-white.png";

    /// <summary>Navy của site (--color-night) — nền header.</summary>
    private const string Navy = "#151c44";

    /// <summary>
    /// Font stack chỉ gồm font hệ thống có đủ dấu tiếng Việt (Georgia/Times thiếu
    /// ơ ư ặ… nên client chắp vá glyph → chữ nhảy font, lệch baseline).
    /// </summary>
    private const string FontStack = "'Segoe UI',-apple-system,BlinkMacSystemFont,Roboto,'Helvetica Neue',Arial,sans-serif";

    /// <param name="heading">Tiêu đề lớn (vd "Đã nhận đăng ký tour").</param>
    /// <param name="fullName">Tên khách (lời chào).</param>
    /// <param name="intro">Câu mở đầu ngắn.</param>
    /// <param name="rows">Các dòng thông tin (nhãn, giá trị) — giá trị tự escape + xuống dòng.</param>
    /// <param name="closing">Câu kết trước lời chào.</param>
    public static string Confirmation(
        string heading,
        string fullName,
        string intro,
        IEnumerable<(string Label, string? Value)> rows,
        string closing)
    {
        var body = new StringBuilder();
        foreach (var (label, value) in rows)
        {
            if (string.IsNullOrWhiteSpace(value)) continue;
            var v = WebUtility.HtmlEncode(value).Replace("\n", "<br>");
            body.Append($@"
              <tr>
                <td style=""padding:11px 0;border-bottom:1px solid #efece3;color:#8a836f;font-size:12px;text-transform:uppercase;letter-spacing:.06em;vertical-align:top;white-space:nowrap;padding-right:16px;"">{WebUtility.HtmlEncode(label)}</td>
                <td style=""padding:11px 0;border-bottom:1px solid #efece3;color:#2a2620;font-size:14px;"">{v}</td>
              </tr>");
        }

        return $@"<!DOCTYPE html>
<html lang=""vi"">
<head><meta charset=""UTF-8""><meta name=""viewport"" content=""width=device-width,initial-scale=1""></head>
<body style=""margin:0;padding:0;background:#f2efe8;"">
  <table role=""presentation"" width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""background:#f2efe8;padding:32px 12px;font-family:{FontStack};"">
    <tr><td align=""center"">
      <table role=""presentation"" width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""max-width:560px;background:#fffdf8;border:1px solid #e5e0d5;border-radius:6px;overflow:hidden;"">
        <tr><td style=""background:{Navy};padding:30px 32px;text-align:center;"">
          <img src=""{LogoUrl}"" alt=""PERLUNAS"" width=""220"" style=""display:block;margin:0 auto;width:220px;max-width:70%;height:auto;border:0;outline:none;text-decoration:none;color:#ffffff;font-size:20px;letter-spacing:6px;font-weight:bold;"">
          <div style=""color:#c5cae0;font-size:11px;letter-spacing:2px;margin-top:12px;"">HÀNH TRÌNH KẾT NỐI GIÁ TRỊ</div>
        </td></tr>
        <tr><td style=""padding:34px 32px 8px;"">
          <h1 style=""margin:0;font-size:22px;color:{Navy};font-weight:600;"">{WebUtility.HtmlEncode(heading)}</h1>
          <p style=""margin:18px 0 4px;font-size:15px;color:#2a2620;"">Chào <strong>{WebUtility.HtmlEncode(fullName)}</strong>,</p>
          <p style=""margin:0 0 22px;font-size:15px;line-height:1.7;color:#5b5548;"">{WebUtility.HtmlEncode(intro)}</p>
        </td></tr>
        <tr><td style=""padding:0 32px;"">
          <table role=""presentation"" width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""border-top:1px solid #e5e0d5;"">{body}</table>
        </td></tr>
        <tr><td style=""padding:22px 32px 34px;"">
          <p style=""margin:0;font-size:15px;line-height:1.7;color:#5b5548;"">{WebUtility.HtmlEncode(closing)}</p>
          <p style=""margin:22px 0 0;font-size:15px;color:#2a2620;"">Trân trọng,<br><strong style=""color:{Navy};"">Đội ngũ Perlunas Travel</strong></p>
        </td></tr>
        <tr><td style=""background:#faf7f0;padding:18px 32px;text-align:center;border-top:1px solid #e5e0d5;color:#9a9280;font-size:11px;line-height:1.6;"">
          Đây là email tự động, vui lòng không trả lời.<br>© Perlunas Travel — Thiết kế hành trình du lịch trong nước.
        </td></tr>
      </table>
    </td></tr>
  </table>
</body>
</html>";
    }
}
