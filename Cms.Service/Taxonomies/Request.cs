using Cms.Repository.Enums;
using Cms.Service.Common;

namespace Cms.Service.Taxonomies;

public class Request
{
    public class CreateTaxonomyRequest
    {
        public TaxonomyGroup Group { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Slug { get; set; }
    }

    public class UpdateTaxonomyRequest
    {
        public TaxonomyGroup Group { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Slug { get; set; }
    }

    private static string Slugify(string? slug, string fallback) =>
        SlugHelper.Slugify(slug, fallback);
}
