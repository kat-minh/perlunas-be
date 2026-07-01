namespace Cms.Service.Service;

public class Response
{
    public class ServiceResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Introducetion { get; set; } = string.Empty;
        public int Day { get; set; }
        public int Night { get; set; }
        public string Label { get; set; } = string.Empty;
        public string Album { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Infor { get; set; } = string.Empty;
        public string Highlight { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Instruct { get; set; } = string.Empty;
        public string Feature { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public bool IsPublic { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
