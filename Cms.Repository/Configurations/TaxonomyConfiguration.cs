using Cms.Repository.Configurations.Seeds;
using Cms.Repository.Entities;
using Cms.Repository.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class TaxonomyConfiguration : IEntityTypeConfiguration<Taxonomy>
{
    public void Configure(EntityTypeBuilder<Taxonomy> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Group).IsRequired().HasMaxLength(50).HasConversion<string>();
        builder.Property(t => t.Name).IsRequired().HasMaxLength(150);
        builder.Property(t => t.Slug).HasMaxLength(150);
        builder.HasIndex(t => new { t.Group, t.Name }).IsUnique();
        builder.Property(t => t.CreatedAt).HasDefaultValueSql("now()");

        builder.SeedTaxonomy();
    }
}
