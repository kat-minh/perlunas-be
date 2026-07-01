namespace Cms.Service.PageContent;

public class Request
{
    public class CreatePageContentRequest
    {
        public Guid? ParentId { get; set; }
        public string PageKey { get; set; } = string.Empty;
        public string SectionKey { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public string ContentValue { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public string Kind { get; set; } = string.Empty;
        public int SoftOrder { get; set; }
    }

    public class UpdatePageContentRequest
    {
        public Guid? ParentId { get; set; }
        public string PageKey { get; set; } = string.Empty;
        public string SectionKey { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public string ContentValue { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public string Kind { get; set; } = string.Empty;
        public int SoftOrder { get; set; }
    }
}
