namespace Cms.Service.ImportantInfor;

public class Request
{
    public class CreateImportantInforRequest
    {
        public Guid ServiceId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string SubTitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class UpdateImportantInforRequest
    {
        public Guid ServiceId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string SubTitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
