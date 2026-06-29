namespace Cms.Service.PageContent;

public class Response
{
    public class PageContentResponse
    {
        public Guid Id { get; set; }
        public string? Key { get; set; }
        public string Value { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public string Kind { get; set; } = "text";
        public int SortOrder { get; set; }
        public Guid? ParentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public List<PageContentResponse> Children { get; set; } = new();
    }
}
