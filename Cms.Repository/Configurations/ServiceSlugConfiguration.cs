using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class ServiceSlugConfiguration : IEntityTypeConfiguration<ServiceSlug>
{
    public void Configure(EntityTypeBuilder<ServiceSlug> builder)
    {
        builder.ToTable("ServiceSlugs", table =>
            table.HasCheckConstraint("CK_ServiceSlugs_Slug_NotBlank", "BTRIM(\"Slug\") <> ''"));

        builder.Property(x => x.Slug).HasMaxLength(255).IsRequired();
        builder.Property(x => x.CreatedAt).HasDefaultValueSql("now()");

        builder.HasIndex(x => x.Slug).IsUnique();
        builder.HasIndex(x => x.ServiceId);
        builder.HasIndex(x => x.ServiceId)
            .HasDatabaseName("IX_ServiceSlugs_ServiceId_Canonical")
            .IsUnique()
            .HasFilter("\"IsCanonical\" = TRUE");

        builder.HasOne(x => x.Service)
            .WithMany(x => x.ServiceSlugs)
            .HasForeignKey(x => x.ServiceId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
