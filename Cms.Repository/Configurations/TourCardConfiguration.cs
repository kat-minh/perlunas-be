using Cms.Repository.Configurations.Seeds;
using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class TourCardConfiguration : IEntityTypeConfiguration<TourCard>
{
    public void Configure(EntityTypeBuilder<TourCard> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Title).IsRequired().HasMaxLength(300);
        builder.Property(t => t.Type).IsRequired().HasConversion<string>().HasMaxLength(50);
        builder.Property(t => t.CreatedAt).HasDefaultValueSql("now()");

        builder.HasIndex(t => t.Type);

        builder.SeedTourCard();
    }
}
