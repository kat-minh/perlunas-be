using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class  ComboSeed
{
    // ComboTier GUIDs
    private static readonly Guid Akoya = Guid.Parse("60000000-0000-0000-0000-000000000001");
    private static readonly Guid Tahiti = Guid.Parse("60000000-0000-0000-0000-000000000002");
    private static readonly Guid SouthSea = Guid.Parse("60000000-0000-0000-0000-000000000003");

    // Hotel GUIDs
    private static readonly Guid IntercontinentalDn = Guid.Parse("40000000-0000-0000-0000-000000000010");
    private static readonly Guid SheratonHn = Guid.Parse("40000000-0000-0000-0000-000000000011");
    private static readonly Guid IntercontinentalPq = Guid.Parse("40000000-0000-0000-0000-000000000012");
    private static readonly Guid JwMarriottPq = Guid.Parse("40000000-0000-0000-0000-000000000013");
    private static readonly Guid VinpearlNt = Guid.Parse("40000000-0000-0000-0000-000000000014");
    private static readonly Guid AnaMandaraDl = Guid.Parse("40000000-0000-0000-0000-000000000015");
    private static readonly Guid TerracottaDl = Guid.Parse("40000000-0000-0000-0000-000000000016");
    private static readonly Guid SheratonHl = Guid.Parse("40000000-0000-0000-0000-000000000017");
    private static readonly Guid CoupoleSp = Guid.Parse("40000000-0000-0000-0000-000000000018");
    private static readonly Guid NamanDn = Guid.Parse("40000000-0000-0000-0000-000000000019");

    public static void SeedCombo(this EntityTypeBuilder<Combo> builder)
    {
        var now = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        builder.HasData(
            new Combo { Id = Guid.Parse("50000000-0000-0000-0000-000000000001"), Slug = "akoya-intercontinental-da-nang-2d", HotelId = IntercontinentalDn, ComboTierId = Akoya, Nights = 2, Price = "5.000.000đ/khách", Featured = true, Cover = "https://picsum.photos/seed/akoya-intercontinental-da-nang-2d/1200/800", SortOrder = 1, CreatedAt = now, UpdatedAt = now },
            new Combo { Id = Guid.Parse("50000000-0000-0000-0000-000000000002"), Slug = "tahiti-sheraton-ha-noi-3d", HotelId = SheratonHn, ComboTierId = Tahiti, Nights = 3, Price = "8.000.000đ/khách", Featured = true, Cover = "https://picsum.photos/seed/tahiti-sheraton-ha-noi-3d/1200/800", SortOrder = 2, CreatedAt = now, UpdatedAt = now },
            new Combo { Id = Guid.Parse("50000000-0000-0000-0000-000000000003"), Slug = "akoya-sheraton-ha-noi-2d", HotelId = SheratonHn, ComboTierId = Akoya, Nights = 2, Price = "5.000.000đ/khách", Featured = false, Cover = "https://picsum.photos/seed/akoya-sheraton-ha-noi-2d/1200/800", SortOrder = 3, CreatedAt = now, UpdatedAt = now },
            new Combo { Id = Guid.Parse("50000000-0000-0000-0000-000000000004"), Slug = "tahiti-sheraton-ha-noi-4d", HotelId = SheratonHn, ComboTierId = Tahiti, Nights = 4, Price = "15.000.000đ/khách", Featured = false, Cover = "https://picsum.photos/seed/tahiti-sheraton-ha-noi-4d/1200/800", SortOrder = 4, CreatedAt = now, UpdatedAt = now },
            new Combo { Id = Guid.Parse("50000000-0000-0000-0000-000000000005"), Slug = "south-sea-intercontinental-phu-quoc-3d", HotelId = IntercontinentalPq, ComboTierId = SouthSea, Nights = 3, Price = "12.000.000đ/khách", Featured = true, Cover = "https://picsum.photos/seed/south-sea-intercontinental-phu-quoc-3d/1200/800", SortOrder = 5, CreatedAt = now, UpdatedAt = now },
            new Combo { Id = Guid.Parse("50000000-0000-0000-0000-000000000006"), Slug = "tahiti-jw-marriott-phu-quoc-3d", HotelId = JwMarriottPq, ComboTierId = Tahiti, Nights = 3, Price = "9.000.000đ/khách", Featured = true, Cover = "https://picsum.photos/seed/tahiti-jw-marriott-phu-quoc-3d/1200/800", SortOrder = 6, CreatedAt = now, UpdatedAt = now },
            new Combo { Id = Guid.Parse("50000000-0000-0000-0000-000000000007"), Slug = "south-sea-jw-marriott-phu-quoc-4d", HotelId = JwMarriottPq, ComboTierId = SouthSea, Nights = 4, Price = "16.000.000đ/khách", Featured = false, Cover = "https://picsum.photos/seed/south-sea-jw-marriott-phu-quoc-4d/1200/800", SortOrder = 7, CreatedAt = now, UpdatedAt = now },
            new Combo { Id = Guid.Parse("50000000-0000-0000-0000-000000000008"), Slug = "akoya-vinpearl-nha-trang-2d", HotelId = VinpearlNt, ComboTierId = Akoya, Nights = 2, Price = "4.500.000đ/khách", Featured = true, Cover = "https://picsum.photos/seed/akoya-vinpearl-nha-trang-2d/1200/800", SortOrder = 8, CreatedAt = now, UpdatedAt = now },
            new Combo { Id = Guid.Parse("50000000-0000-0000-0000-000000000009"), Slug = "tahiti-vinpearl-nha-trang-3d", HotelId = VinpearlNt, ComboTierId = Tahiti, Nights = 3, Price = "7.500.000đ/khách", Featured = false, Cover = "https://picsum.photos/seed/tahiti-vinpearl-nha-trang-3d/1200/800", SortOrder = 9, CreatedAt = now, UpdatedAt = now },
            new Combo { Id = Guid.Parse("50000000-0000-0000-0000-00000000000a"), Slug = "south-sea-ana-mandara-da-lat-3d", HotelId = AnaMandaraDl, ComboTierId = SouthSea, Nights = 3, Price = "11.000.000đ/khách", Featured = true, Cover = "https://picsum.photos/seed/south-sea-ana-mandara-da-lat-3d/1200/800", SortOrder = 10, CreatedAt = now, UpdatedAt = now },
            new Combo { Id = Guid.Parse("50000000-0000-0000-0000-00000000000b"), Slug = "akoya-terracotta-da-lat-2d", HotelId = TerracottaDl, ComboTierId = Akoya, Nights = 2, Price = "4.000.000đ/khách", Featured = false, Cover = "https://picsum.photos/seed/akoya-terracotta-da-lat-2d/1200/800", SortOrder = 11, CreatedAt = now, UpdatedAt = now },
            new Combo { Id = Guid.Parse("50000000-0000-0000-0000-00000000000c"), Slug = "tahiti-sheraton-ha-long-3d", HotelId = SheratonHl, ComboTierId = Tahiti, Nights = 3, Price = "8.500.000đ/khách", Featured = true, Cover = "https://picsum.photos/seed/tahiti-sheraton-ha-long-3d/1200/800", SortOrder = 12, CreatedAt = now, UpdatedAt = now },
            new Combo { Id = Guid.Parse("50000000-0000-0000-0000-00000000000d"), Slug = "akoya-de-la-coupole-sa-pa-2d", HotelId = CoupoleSp, ComboTierId = Akoya, Nights = 2, Price = "5.500.000đ/khách", Featured = false, Cover = "https://picsum.photos/seed/akoya-de-la-coupole-sa-pa-2d/1200/800", SortOrder = 13, CreatedAt = now, UpdatedAt = now },
            new Combo { Id = Guid.Parse("50000000-0000-0000-0000-00000000000e"), Slug = "south-sea-naman-da-nang-3d", HotelId = NamanDn, ComboTierId = SouthSea, Nights = 3, Price = "13.000.000đ/khách", Featured = false, Cover = "https://picsum.photos/seed/south-sea-naman-da-nang-3d/1200/800", SortOrder = 14, CreatedAt = now, UpdatedAt = now }
        );
    }
}
