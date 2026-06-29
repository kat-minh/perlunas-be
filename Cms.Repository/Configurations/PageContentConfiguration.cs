using Cms.Repository.Configurations.Seeds;
using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class PageContentConfiguration : IEntityTypeConfiguration<PageContent>
{
    public void Configure(EntityTypeBuilder<PageContent> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Key).HasMaxLength(120);
        builder.HasIndex(p => p.ParentId);
        builder.Property(p => p.CreatedAt).HasDefaultValueSql("now()");

        builder.HasOne(p => p.Parent)
            .WithMany(p => p.Children)
            .HasForeignKey(p => p.ParentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.SeedPageContent();
    }
}
