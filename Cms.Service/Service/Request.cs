using Cms.Repository.Enums;

namespace Cms.Service.Service;

public class Request
{
    public class ScheduleInline
    {
        public string Day { get; set; } = string.Empty;
        public string Titile { get; set; } = string.Empty;
        public string Sumary { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class ImportantInforInline
    {
        public string Title { get; set; } = string.Empty;
        public string SubTitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class DepartureScheduleInline
    {
        public string StartTime { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string AccommodationStandards { get; set; } = string.Empty;
    }

    public class RoomCategoryInline
    {
        public List<string> Album { get; set; } = new();
        public string Titile { get; set; } = string.Empty;
        public int NumberOfCustomer { get; set; }
        public string Acreage { get; set; } = string.Empty;
        public string NumberOfBed { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Feature { get; set; } = new();
        public string? Price { get; set; }
        public string? OriginalPrice { get; set; }
        public string? Unit { get; set; }
    }

    public class CreateTourRequest
    {
        public string Title { get; set; } = string.Empty;
        public int Day { get; set; }
        public int Night { get; set; }
        public List<string> Album { get; set; } = new();
        public string Region { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Infor { get; set; } = string.Empty;
        public string Highlight { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public bool IsPublic { get; set; }
        public List<ScheduleInline> Schedules { get; set; } = new();
        public List<ImportantInforInline> ImportantInfors { get; set; } = new();
        public List<DepartureScheduleInline> DepartureSchedules { get; set; } = new();
    }

    public class CreateComboRequest
    {
        public string Title { get; set; } = string.Empty;
        public int Night { get; set; }
        public string Label { get; set; } = string.Empty;
        public List<string> Album { get; set; } = new();
        public string Region { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Infor { get; set; } = string.Empty;
        public string Highlight { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public PurposeOfTrip PurposeOfTrip { get; set; }
        public string Destination { get; set; } = string.Empty;
        public string Form { get; set; } = string.Empty;
        public Classify Classify { get; set; }
        public bool IsPublic { get; set; }
        public List<ScheduleInline> Schedules { get; set; } = new();
        public List<ImportantInforInline> ImportantInfors { get; set; } = new();
        public List<RoomCategoryInline> RoomCategories { get; set; } = new();
    }

    public class CreateHotelRequest
    {
        public string Title { get; set; } = string.Empty;
        public string Introducetion { get; set; } = string.Empty;
        public List<string> Album { get; set; } = new();
        public string Region { get; set; } = string.Empty;
        public string Instruct { get; set; } = string.Empty;
        public string Feature { get; set; } = string.Empty;
        public PurposeOfTrip PurposeOfTrip { get; set; }
        public string Destination { get; set; } = string.Empty;
        public string Form { get; set; } = string.Empty;
        public bool IsPublic { get; set; }
        public List<RoomCategoryInline> RoomCategories { get; set; } = new();
    }

    public class UpdateServiceRequest
    {
        public string? Title { get; set; }
        public string? Introducetion { get; set; }
        public int? Day { get; set; }
        public int? Night { get; set; }
        public string? Label { get; set; }
        public List<string>? Album { get; set; }
        public string? Region { get; set; }
        public string? Description { get; set; }
        public string? Infor { get; set; }
        public string? Highlight { get; set; }
        public string? Code { get; set; }
        public string? Instruct { get; set; }
        public string? Feature { get; set; }
        public ServiceType? Type { get; set; }
        public bool? IsPublic { get; set; }
        public PurposeOfTrip? PurposeOfTrip { get; set; }
        public string? Destination { get; set; }
        public string? Form { get; set; }
        public Classify? Classify { get; set; }
        public List<ScheduleInline>? Schedules { get; set; }
        public List<ImportantInforInline>? ImportantInfors { get; set; }
        public List<DepartureScheduleInline>? DepartureSchedules { get; set; }
        public List<RoomCategoryInline>? RoomCategories { get; set; }
    }
}
