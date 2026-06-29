namespace Cms.Service.SiteSettings;

public class Request
{
    public class UpdateSiteSettingRequest
    {
        public string Name { get; set; } = string.Empty;
        public string LegalName { get; set; } = string.Empty;
        public string Tagline { get; set; } = string.Empty;
        public string Manifesto { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string TaxId { get; set; } = string.Empty;
        public List<Response.Office> Offices { get; set; } = new();
        public List<Response.SocialLink> Social { get; set; } = new();
    }
}
