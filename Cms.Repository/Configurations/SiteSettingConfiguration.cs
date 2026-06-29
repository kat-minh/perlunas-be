using Cms.Repository.Configurations.Seeds;
using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class SiteSettingConfiguration : IEntityTypeConfiguration<SiteSetting>
{
    public void Configure(EntityTypeBuilder<SiteSetting> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Name).HasMaxLength(200);
        builder.Property(s => s.LegalName).HasMaxLength(300);
        builder.Property(s => s.Phone).HasMaxLength(50);
        builder.Property(s => s.Email).HasMaxLength(256);
        builder.Property(s => s.TaxId).HasMaxLength(50);
        builder.Property(s => s.OfficesJson).HasColumnType("jsonb");
        builder.Property(s => s.SocialJson).HasColumnType("jsonb");
        builder.Property(s => s.CreatedAt).HasDefaultValueSql("now()");

        builder.SeedSiteSetting();
    }
}
