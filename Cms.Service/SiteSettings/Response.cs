namespace Cms.Service.SiteSettings;

public class Response
{
    public class Office
    {
        public string Label { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }

    public class SocialLink
    {
        public string Label { get; set; } = string.Empty;
        public string Href { get; set; } = string.Empty;
    }

    public class SiteSettingResponse
    {
        public DateTime? UpdatedAt { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LegalName { get; set; } = string.Empty;
        public string Tagline { get; set; } = string.Empty;
        public string Manifesto { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string TaxId { get; set; } = string.Empty;
        public List<Office> Offices { get; set; } = new();
        public List<SocialLink> Social { get; set; } = new();
    }
}
