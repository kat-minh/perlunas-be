using Cms.Repository.Entities;
using Cms.Repository.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class TaxonomySeed
{
    public static void SeedTaxonomy(this EntityTypeBuilder<Taxonomy> builder)
    {
        var now = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        builder.HasData(
            // Cities
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-000000000001"), Group = TaxonomyGroup.City, Name = "Hà Nội", Slug = "ha-noi", SortOrder = 1, CreatedAt = now, UpdatedAt = now },
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-000000000002"), Group = TaxonomyGroup.City, Name = "TP. Hồ Chí Minh", Slug = "tp-ho-chi-minh", SortOrder = 2, CreatedAt = now, UpdatedAt = now },
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-000000000003"), Group = TaxonomyGroup.City, Name = "Hạ Long", Slug = "ha-long", SortOrder = 3, CreatedAt = now, UpdatedAt = now },
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-000000000004"), Group = TaxonomyGroup.City, Name = "Sa Pa", Slug = "sa-pa", SortOrder = 4, CreatedAt = now, UpdatedAt = now },
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-000000000005"), Group = TaxonomyGroup.City, Name = "Đà Nẵng", Slug = "da-nang", SortOrder = 5, CreatedAt = now, UpdatedAt = now },
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-000000000006"), Group = TaxonomyGroup.City, Name = "Hội An", Slug = "hoi-an", SortOrder = 6, CreatedAt = now, UpdatedAt = now },
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-000000000007"), Group = TaxonomyGroup.City, Name = "Huế", Slug = "hue", SortOrder = 7, CreatedAt = now, UpdatedAt = now },
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-000000000008"), Group = TaxonomyGroup.City, Name = "Đà Lạt", Slug = "da-lat", SortOrder = 8, CreatedAt = now, UpdatedAt = now },
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-000000000009"), Group = TaxonomyGroup.City, Name = "Nha Trang", Slug = "nha-trang", SortOrder = 9, CreatedAt = now, UpdatedAt = now },
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-00000000000a"), Group = TaxonomyGroup.City, Name = "Phú Quốc", Slug = "phu-quoc", SortOrder = 10, CreatedAt = now, UpdatedAt = now },
            // Stay types
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-00000000000b"), Group = TaxonomyGroup.StayType, Name = "Hotel", Slug = "hotel", SortOrder = 1, CreatedAt = now, UpdatedAt = now },
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-00000000000c"), Group = TaxonomyGroup.StayType, Name = "Resort", Slug = "resort", SortOrder = 2, CreatedAt = now, UpdatedAt = now },
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-00000000000d"), Group = TaxonomyGroup.StayType, Name = "Retreat", Slug = "retreat", SortOrder = 3, CreatedAt = now, UpdatedAt = now },
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-00000000000e"), Group = TaxonomyGroup.StayType, Name = "Wellness", Slug = "wellness", SortOrder = 4, CreatedAt = now, UpdatedAt = now },
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-00000000000f"), Group = TaxonomyGroup.StayType, Name = "Boutique Hotel", Slug = "boutique-hotel", SortOrder = 5, CreatedAt = now, UpdatedAt = now },
            // Regions
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-000000000010"), Group = TaxonomyGroup.Region, Name = "Miền Bắc", Slug = "mien-bac", SortOrder = 1, CreatedAt = now, UpdatedAt = now },
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-000000000011"), Group = TaxonomyGroup.Region, Name = "Miền Trung", Slug = "mien-trung", SortOrder = 2, CreatedAt = now, UpdatedAt = now },
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-000000000012"), Group = TaxonomyGroup.Region, Name = "Miền Nam", Slug = "mien-nam", SortOrder = 3, CreatedAt = now, UpdatedAt = now },
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-000000000013"), Group = TaxonomyGroup.Region, Name = "Tây Nguyên", Slug = "tay-nguyen", SortOrder = 4, CreatedAt = now, UpdatedAt = now },
            new Taxonomy { Id = Guid.Parse("70000000-0000-0000-0000-000000000014"), Group = TaxonomyGroup.Region, Name = "Quốc tế", Slug = "quoc-te", SortOrder = 5, CreatedAt = now, UpdatedAt = now }
        );
    }
}
