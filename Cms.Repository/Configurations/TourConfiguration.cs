using Cms.Repository.Configurations.Seeds;
using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class TourConfiguration : IEntityTypeConfiguration<Tour>
{
    public void Configure(EntityTypeBuilder<Tour> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Slug).IsRequired().HasMaxLength(200);
        builder.HasIndex(t => t.Slug).IsUnique();
        builder.Property(t => t.Name).IsRequired().HasMaxLength(300);
        builder.Property(t => t.Nights).HasMaxLength(100);
        builder.Property(t => t.Price).HasMaxLength(100);
        builder.Property(t => t.CreatedAt).HasDefaultValueSql("now()");

        builder.HasOne(t => t.Taxonomy)
            .WithMany(tax => tax.Tours)
            .HasForeignKey(t => t.TaxonomyId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.SeedTour();
    }
}
