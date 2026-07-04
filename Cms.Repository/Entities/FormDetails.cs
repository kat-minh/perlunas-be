using Cms.Repository.Abtraction;

namespace Cms.Repository.Entities;

public class FormDetails : BaseEntity<Guid>, IAuditableEntity
{
     
    public List<string>? RoomCategory {get; set;}
    
    public int? NumberOfRooms {get; set;}
    
    public string? ReceiveTime {get; set;}
    
    public string? EndTime {get; set;}
    
    public int? Adults {get; set;}
    
    public int? Children {get; set;}
    
    public int? Baby {get; set;}
    
    public int? Price {get; set;}
    
    public string? UnitPrice {get; set;}
    
    public Guid ServiceId {get; set;}

    public Guid FormId { get; set; }
    public Form Form { get; set; } = null;
    
    
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}