namespace Cms.Service.ComboTiers;

public class Response
{
    public class ComboTierResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Tagline { get; set; } = string.Empty;
        public string Pearl { get; set; } = string.Empty;
        public string Story { get; set; } = string.Empty;
        public List<string> Includes { get; set; } = new();
        public int SortOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
