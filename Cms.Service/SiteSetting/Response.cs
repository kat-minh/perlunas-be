namespace Cms.Service.SiteSetting;

public class Response
{
    public class SiteSettingResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LegalName { get; set; } = string.Empty;
        public string Tagline { get; set; } = string.Empty;
        public string Manifesto { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string TaxId { get; set; } = string.Empty;
        public string OfficesJson { get; set; } = string.Empty;
        public string SocialJson { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
