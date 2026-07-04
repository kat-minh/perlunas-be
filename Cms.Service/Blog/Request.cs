namespace Cms.Service.Blog;

public class Request
{
    public class CreateBlogRequest
    {
        public string Titile { get; set; } = string.Empty;
        public string SubTitile { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string ReadingTime { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Tag { get; set; } = string.Empty;
        public string Cover { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }

    public class UpdateBlogRequest
    {
        public string Titile { get; set; } = string.Empty;
        public string SubTitile { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string ReadingTime { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Tag { get; set; } = string.Empty;
        public string Cover { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
