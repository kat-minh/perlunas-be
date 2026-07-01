using Cms.Repository.Entities;
using Cms.Repository.Configurations.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class PageContentConfiguration : IEntityTypeConfiguration<PageContent>
{
    public void Configure(EntityTypeBuilder<PageContent> builder)
    {
        builder.ToTable("PageContents");

        builder.Property(x => x.ParentId).IsRequired(false);
        builder.Property(x => x.PageKey).HasMaxLength(100);
        builder.Property(x => x.SectionKey).HasMaxLength(100);
        builder.Property(x => x.Key).HasMaxLength(100);
        builder.Property(x => x.Label).HasMaxLength(255);
        builder.Property(x => x.Kind).HasMaxLength(50);
        builder.Property(x => x.CreatedAt).HasDefaultValueSql("now()");

        builder.HasIndex(x => new { x.PageKey, x.SectionKey });

        builder.HasOne(x => x.Parent)
            .WithMany(x => x.Children)
            .HasForeignKey(x => x.ParentId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.SeedPageContent();
    }
}
