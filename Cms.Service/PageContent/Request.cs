namespace Cms.Service.PageContent;

public class Request
{
    public class PageContentUpdate
    {
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}
