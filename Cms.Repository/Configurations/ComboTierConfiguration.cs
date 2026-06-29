using Cms.Repository.Configurations.Seeds;
using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class ComboTierConfiguration : IEntityTypeConfiguration<ComboTier>
{
    public void Configure(EntityTypeBuilder<ComboTier> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Tagline).HasMaxLength(200);
        builder.Property(c => c.CreatedAt).HasDefaultValueSql("now()");

        builder.SeedComboTier();
    }
}
