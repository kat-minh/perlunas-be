using Cms.Repository.Entities;
using Cms.Repository.Configurations.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class TaxonomyConfiguration : IEntityTypeConfiguration<Taxonomy>
{
    public void Configure(EntityTypeBuilder<Taxonomy> builder)
    {
        builder.ToTable("Taxonomies");

        builder.Property(x => x.Group).HasMaxLength(50).IsRequired();
        builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
        builder.Property(x => x.Slug).HasMaxLength(255);
        builder.Property(x => x.Color).HasMaxLength(50);
        builder.Property(x => x.CreatedAt).HasDefaultValueSql("now()");

        // Lọc theo group là truy vấn chính; tên không trùng trong cùng 1 group.
        builder.HasIndex(x => x.Group);
        builder.HasIndex(x => new { x.Group, x.Name }).IsUnique();

        builder.SeedTaxonomy();
    }
}
