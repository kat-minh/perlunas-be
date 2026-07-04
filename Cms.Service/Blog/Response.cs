namespace Cms.Service.Blog;

public class Response
{
    public class BlogResponse
    {
        public Guid Id { get; set; }
        public string Titile { get; set; } = string.Empty;
        public string SubTitile { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string ReadingTime { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Tag { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Cover { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public List<BlogResponse>? RecentBlogs { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
