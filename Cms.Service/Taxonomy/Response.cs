namespace Cms.Service.Taxonomy;

public class Response
{
    public class TaxonomyResponse
    {
        public Guid Id { get; set; }
        public string Group { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Slug { get; set; }
        public string? Color { get; set; }
        public int SortOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
