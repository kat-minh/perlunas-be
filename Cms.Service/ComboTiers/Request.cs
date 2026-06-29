namespace Cms.Service.ComboTiers;

public class Request
{
    public class CreateComboTierRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Tagline { get; set; } = string.Empty;
        public string Pearl { get; set; } = string.Empty;
        public string Story { get; set; } = string.Empty;
        public List<string> Includes { get; set; } = new();

    }

    public class UpdateComboTierRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Tagline { get; set; } = string.Empty;
        public string Pearl { get; set; } = string.Empty;
        public string Story { get; set; } = string.Empty;
        public List<string> Includes { get; set; } = new();

    }
}
