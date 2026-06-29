using Cms.Repository.Configurations.Seeds;
using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class HotelTaxonomyDetailsConfiguration : IEntityTypeConfiguration<HotelTaxonomyDetails>
{
    public void Configure(EntityTypeBuilder<HotelTaxonomyDetails> builder)
    {
        builder.HasKey(ht => new { ht.HotelId, ht.TaxonomyId });

        builder.HasOne(ht => ht.Hotel)
            .WithMany(h => h.HotelTaxonomyDetails)
            .HasForeignKey(ht => ht.HotelId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ht => ht.Taxonomy)
            .WithMany(t => t.HotelTaxonomyDetails)
            .HasForeignKey(ht => ht.TaxonomyId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.SeedHotelTaxonomyDetails();
    }
}
