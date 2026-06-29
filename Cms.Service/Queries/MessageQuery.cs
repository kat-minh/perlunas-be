namespace Cms.Service.Queries;

public class MessageQuery
{
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 15;
    public string? Search { get; set; }
    public bool? Unread { get; set; }

    public (int page, int pageSize) Normalized()
    {
        var page = Page < 1 ? 1 : Page;
        var size = PageSize < 1 ? 15 : PageSize > 100 ? 100 : PageSize;
        return (page, size);
    }
}
