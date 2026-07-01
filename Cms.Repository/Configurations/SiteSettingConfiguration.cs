using Cms.Repository.Entities;
using Cms.Repository.Configurations.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class SiteSettingConfiguration : IEntityTypeConfiguration<SiteSetting>
{
    public void Configure(EntityTypeBuilder<SiteSetting> builder)
    {
        builder.ToTable("SiteSettings");

        builder.Property(x => x.Name).HasMaxLength(255);
        builder.Property(x => x.LegalName).HasMaxLength(255);
        builder.Property(x => x.Tagline).HasMaxLength(255);
        builder.Property(x => x.Phone).HasMaxLength(50);
        builder.Property(x => x.Email).HasMaxLength(100);
        builder.Property(x => x.TaxId).HasMaxLength(50);
        builder.Property(x => x.CreatedAt).HasDefaultValueSql("now()");

        builder.SeedSiteSetting();
    }
}
