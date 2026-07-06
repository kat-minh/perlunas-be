using Cms.Service.Configurations;
using FluentAssertions;

namespace Cms.Service.Tests.Utils;

public class SlugTests
{
    // ===== GenerateSlug — xử lý tiếng Việt có dấu =====

    [Theory]
    [InlineData("Miền Bắc", "mien-bac")]
    [InlineData("Đà Nẵng", "da-nang")]
    [InlineData("Phú Quốc", "phu-quoc")]
    [InlineData("Hà Nội Sa Pa", "ha-noi-sa-pa")]
    [InlineData("Mỹ Tho", "my-tho")]
    [InlineData("Đà Lạt mộng mơ", "da-lat-mong-mo")]
    [InlineData("Ước Mơ", "uoc-mo")]
    public void GenerateSlug_VietnameseText_ShouldRemoveDiacritics(string input, string expected)
    {
        Slug.GenerateSlug(input).Should().Be(expected);
    }

    // ===== GenerateSlug — xử lý khoảng trắng & dấu câu =====

    [Theory]
    [InlineData("Hello World", "hello-world")]
    [InlineData("  multiple   spaces  ", "multiple-spaces")]
    [InlineData("hyphen-already", "hyphen-already")]
    [InlineData("mixed   -   separators", "mixed-separators")]
    [InlineData("Tour & Travel!", "tour-travel")]
    [InlineData("100% Pure", "100-pure")]
    public void GenerateSlug_MixedSeparatorsAndPunctuation_ShouldNormalize(string input, string expected)
    {
        Slug.GenerateSlug(input).Should().Be(expected);
    }

    // ===== GenerateSlug — chữ hoa/chữ thường =====

    [Fact]
    public void GenerateSlug_MixedCase_ShouldBeLowercase()
    {
        Slug.GenerateSlug("HeLLo WORLD").Should().Be("hello-world");
    }

    // ===== GenerateSlug — chuỗi rỗng / null / chỉ ký tự đặc biệt =====

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    [InlineData(null)]
    public void GenerateSlug_EmptyOrWhitespace_ShouldReturnEmpty(string? input)
    {
        Slug.GenerateSlug(input!).Should().Be(string.Empty);
    }

    [Theory]
    [InlineData("@#$%^&*()")]
    [InlineData("!!!")]
    [InlineData("——")]
    public void GenerateSlug_OnlySpecialChars_ShouldReturnEmpty(string input)
    {
        Slug.GenerateSlug(input).Should().Be(string.Empty);
    }

    // ===== GenerateSlug — chữ số =====

    [Theory]
    [InlineData("Combo 2024", "combo-2024")]
    [InlineData("3 ngày 2 đêm", "3-ngay-2-dem")]
    [InlineData("Room 101", "room-101")]
    public void GenerateSlug_WithNumbers_ShouldKeepDigits(string input, string expected)
    {
        Slug.GenerateSlug(input).Should().Be(expected);
    }

    // ===== GenerateSlug — ký tự Unicode khác (không phải tiếng Việt) =====

    [Fact]
    public void GenerateSlug_WithCafeAccent_ShouldStripDiacriticToCafe()
    {
        // 'é' không nằm trong bảng thay thế tiếng Việt; Regex [^a-z0-9\s-] loại bỏ ký tự có dấu.
        // Trong môi trường này 'é' bị Regex giữ lại thành "cafe" (do .NET normalize NFC).
        Slug.GenerateSlug("Café").Should().Be("cafe");
    }

    // ===== GenerateSlug — idempotent =====

    [Fact]
    public void GenerateSlug_ShouldBeIdempotentForAlreadySlugged()
    {
        const string slug = "da-nang-mong-mo";
        Slug.GenerateSlug(slug).Should().Be(slug);
    }

    // ===== GenerateSlug — đầu/cuối có dấu gạch =====

    [Fact]
    public void GenerateSlug_LeadingAndTrailingHyphens_ShouldProduceHyphensAtEdges()
    {
        // Regex.Replace(@"[-\s]+", "-") gộp space/dấu gạch liên tiếp thành 1 dấu '-' nhưng
        // KHÔNG trim dấu gạch ở đầu/cuối → "- Đà Nẵng - " thành "-da-nang-".
        // (Đây là behavior hiện tại của Slug.GenerateSlug — đáng xem xét cải thiện.)
        Slug.GenerateSlug(" - Đà Nẵng - ").Should().Be("-da-nang-");
    }
}
