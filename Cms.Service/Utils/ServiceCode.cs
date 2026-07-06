namespace Cms.Service.Configurations;

/// <summary>
/// Sinh mã hiển thị cho dịch vụ TỪ slug — tất định (cùng slug → cùng mã), khớp
/// hệt thuật toán ở frontend (src/app/combo/[slug]/page.tsx) để mã trên website,
/// trong email và ở admin luôn giống nhau mà không cần lưu tay.
///
/// FE:
///   prefix = slug.split("-").map(w=>w[0]).join("").toUpperCase().slice(0,3) || "PL"
///   số 6 chữ số = Array.from(slug).reduce((a,c)=>(a*33+c.charCodeAt(0))%1_000_000, 7)
/// Slug luôn là ASCII (a-z0-9-) nên duyệt theo char C# cho kết quả trùng khít.
/// </summary>
public static class ServiceCode
{
    public static string ForCombo(string? slug)
    {
        slug ??= string.Empty;

        // Chữ cái đầu mỗi "từ" (tách theo dấu "-"); phần rỗng bỏ qua như JS.
        var initials = string.Concat(
            slug.Split('-').Select(w => w.Length > 0 ? w[0].ToString() : string.Empty));
        var prefix = initials.ToUpperInvariant();
        if (prefix.Length > 3) prefix = prefix.Substring(0, 3);
        if (prefix.Length == 0) prefix = "PL";

        // Hash tất định của slug (seed 7) — trùng reduce ở FE.
        long hash = 7;
        foreach (var c in slug)
            hash = (hash * 33 + c) % 1_000_000;

        return prefix + hash.ToString().PadLeft(6, '0');
    }
}
