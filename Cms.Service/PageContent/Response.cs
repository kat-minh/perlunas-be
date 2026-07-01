namespace Cms.Service.PageContent;

public class Response
{
    public class PageContentResponse
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public string PageKey { get; set; } = string.Empty;
        public string SectionKey { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public string ContentValue { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public string Kind { get; set; } = string.Empty;
        public int SoftOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public List<PageContentResponse> Children { get; set; } = new();
    }
}
