using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class SiteSettingSeed
{
    public static void SeedSiteSetting(this EntityTypeBuilder<SiteSetting> builder)
    {
        builder.HasData(
            new SiteSetting { Id = SeedIds.SiteMain, Name = "Perlunas", LegalName = "Perlunas Travel Co., Ltd.", Tagline = "Travel with care", Manifesto = "Sample manifesto.", Description = "Sample site description.", Phone = "+84000000000", Email = "hello@perlunas.local", TaxId = "0000000000", OfficesJson = "[]", SocialJson = "{}", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new SiteSetting { Id = SeedIds.SiteSupport, Name = "Perlunas Support", LegalName = "Perlunas Travel Co., Ltd.", Tagline = "Always here to help", Manifesto = "Support-focused contact settings.", Description = "Support channel information.", Phone = "+84111111111", Email = "support@perlunas.local", TaxId = "0000000000", OfficesJson = "[]", SocialJson = "{}", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new SiteSetting { Id = SeedIds.SiteBranch, Name = "Perlunas Da Nang", LegalName = "Perlunas Da Nang Branch", Tagline = "Central Vietnam office", Manifesto = "Local branch settings.", Description = "Branch contact information.", Phone = "+84222222222", Email = "danang@perlunas.local", TaxId = "0000000001", OfficesJson = "[]", SocialJson = "{}", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt });
    }
}
