namespace Cms.Service.Taxonomy;

public class Request
{
    public class CreateTaxonomyRequest
    {
        /// <summary>city | region | stay-type | tier | purpose.</summary>
        public string Group { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Color { get; set; }
        public int SortOrder { get; set; }
    }

    public class UpdateTaxonomyRequest
    {
        public string Name { get; set; } = string.Empty;
        public string? Color { get; set; }
        public int SortOrder { get; set; }
    }
}
