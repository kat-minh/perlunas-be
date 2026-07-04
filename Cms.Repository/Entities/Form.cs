using Cms.Repository.Abtraction;
using Cms.Repository.Enums;

namespace Cms.Repository.Entities;

public class Form: BaseEntity<Guid>, IAuditableEntity
{
    public string? Where {get; set;}
    
    public string? Slug {get; set;}
    
    public string? Month {get; set;}
    
    public string? Year {get; set;}
    
    public string? LongTime {get; set;}
    
    public string? ComboService {get; set;}
    
    public string? Note {get; set;}
    
    public string? FullName {get; set;}
    
    public string? Phone {get; set;}
    
    public string? Email {get; set;}
    
    public string? Website {get; set;}
    
    public string? ContactName {get; set;}
    
    public bool PromotionalInformation {get; set;} = false;
    
    public FormType Type {get; set;} 
   
    public int? TotalPrice {get; set;}
    
    public Guid ServiceId {get; set;}
    
    public Service Service {get; set;} = null;
    
    public ICollection<FormDetails> FormDetails {get; set;} = new List<FormDetails>();
    
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}