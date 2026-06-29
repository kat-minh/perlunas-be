namespace Cms.Service.Tours;

public class Request
{
    public class CreateTourRequest
    {
        public string Slug { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public Guid TaxonomyId { get; set; }
        public string Nights { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string Teaser { get; set; } = string.Empty;
        public List<string> Highlights { get; set; } = new();
        public List<string> Stays { get; set; } = new();
        public string Cover { get; set; } = string.Empty;
        public bool Featured { get; set; }
    }

    public class UpdateTourRequest
    {
        public string Slug { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public Guid TaxonomyId { get; set; }
        public string Nights { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string Teaser { get; set; } = string.Empty;
        public List<string> Highlights { get; set; } = new();
        public List<string> Stays { get; set; } = new();
        public string Cover { get; set; } = string.Empty;
        public bool Featured { get; set; }
    }
}
