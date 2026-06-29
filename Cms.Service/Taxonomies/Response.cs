using Cms.Repository.Enums;

namespace Cms.Service.Taxonomies;

public class Response
{
    public class TaxonomyResponse
    {
        public Guid Id { get; set; }
        public TaxonomyGroup Group { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
