namespace Cms.Service.Queries;

public class CatalogQuery
{
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 12;
    public string? Search { get; set; }
    public bool? Featured { get; set; }
    public string? Region { get; set; }
    public string? City { get; set; }
    public string? Type { get; set; }
    public string? Tier { get; set; }
    public string? StayType { get; set; }

    public (int page, int pageSize) Normalized()
    {
        var page = Page < 1 ? 1 : Page;
        var size = PageSize < 1 ? 12 : PageSize > 200 ? 200 : PageSize;
        return (page, size);
    }
}
