using Cms.Repository.Abtraction;
using Cms.Repository.Enums;

namespace Cms.Repository.Entities;

public class Service : BaseEntity<Guid>, IAuditableEntity
{
    public string? Title { get; set; }
    public string? Introducetion { get; set; }
    public int? Day { get; set; }
    public int? Night { get; set; }
    public string? Label { get; set; }
    public string? Album { get; set; }
    public string? Region { get; set; }
    public string? Description { get; set; }
    public string? Infor { get; set; }
    public string? Highlight { get; set; }
    public string? Code { get; set; }
    public string? Instruct { get; set; }
    public string? Feature { get; set; }
    public ServiceType Type { get; set; }
    public bool IsPublic { get; set; }
    public PurposeOfTrip? PurposeOfTrip { get; set; }
    public string? Destination { get; set; }
    public string? Form { get; set; }
    public Classify? Classify { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
    public ICollection<RoomCategory> RoomCategories { get; set; } = new List<RoomCategory>();
    public ICollection<DepartureSchedule> DepartureSchedules { get; set; } = new List<DepartureSchedule>();
    public ICollection<ImportantInfor> ImportantInfors { get; set; } = new List<ImportantInfor>();
}
