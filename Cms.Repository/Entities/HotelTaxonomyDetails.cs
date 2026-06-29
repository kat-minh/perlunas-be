namespace Cms.Repository.Entities;

public class HotelTaxonomyDetails
{
    public Guid HotelId { get; set; }
    public Hotel Hotel { get; set; } = null!;

    public Guid TaxonomyId { get; set; }
    public Taxonomy Taxonomy { get; set; } = null!;
}
