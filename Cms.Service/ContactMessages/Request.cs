namespace Cms.Service.ContactMessages;

public class Request
{
    public class CreateContactMessageRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? Subject { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
