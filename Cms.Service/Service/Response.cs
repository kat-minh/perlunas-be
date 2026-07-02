using Cms.Repository.Enums;

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
        public List<string> Album { get; set; } = new();
        public string Region { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Infor { get; set; } = string.Empty;
        public string Highlight { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Instruct { get; set; } = string.Empty;
        public string Feature { get; set; } = string.Empty;
        public ServiceType Type { get; set; }
        public bool IsPublic { get; set; }
        public PurposeOfTrip? PurposeOfTrip { get; set; }
        public string? Destination { get; set; }
        public string? Form { get; set; }
        public Classify? Classify { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
