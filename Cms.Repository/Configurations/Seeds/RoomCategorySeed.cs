using Cms.Repository.Enums;
using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class RoomCategorySeed
{
    // Hotel: Đà Nẵng Grand Hotel
    private static readonly Guid HotelDaNangId = Guid.Parse("e50a45c4-40d6-316f-0e40-2e58860b0f8e");
    // Combo: Intercontinental Đà Nẵng
    private static readonly Guid ComboDaNangId = Guid.Parse("6fc490b0-6501-7066-2716-f195529f23d3");
    // Hotel: Sa Pa Cloud Retreat
    private static readonly Guid HotelSaPaId = Guid.Parse("1c319bb9-c82d-5a4a-22b3-2f5d6625fbd2");
    // Hotel: Metropole Lune
    private static readonly Guid HotelHaNoiId = Guid.Parse("8e401cad-0a9e-259e-9819-bf4842528f05");

    public static void SeedRoomCategory(this EntityTypeBuilder<RoomCategory> builder)
    {
        builder.HasData(
            // Room categories for Đà Nẵng Grand Hotel
            new RoomCategory { Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-bbbbbbbbbb01"), ServiceId = HotelDaNangId, Titile = "Deluxe Room", NumberOfCustomer = 2, NumberOfBed = "1 giường đôi", Acreage = "30m²", Price = "1200000", Unit = "VNĐ", CreatedAt = SeedIds.CreatedAt },
            new RoomCategory { Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-bbbbbbbbbb02"), ServiceId = HotelDaNangId, Titile = "Suite Room", NumberOfCustomer = 2, NumberOfBed = "1 giường king", Acreage = "45m²", Price = "1800000", Unit = "VNĐ", CreatedAt = SeedIds.CreatedAt },
            new RoomCategory { Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-bbbbbbbbbb03"), ServiceId = HotelDaNangId, Titile = "Family Room", NumberOfCustomer = 4, NumberOfBed = "2 giường đôi", Acreage = "50m²", Price = "2200000", Unit = "VNĐ", CreatedAt = SeedIds.CreatedAt },

            // Room categories for Intercontinental Đà Nẵng (Combo)
            new RoomCategory { Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-bbbbbbbbbb04"), ServiceId = ComboDaNangId, Titile = "Heritage Suite", NumberOfCustomer = 2, NumberOfBed = "1 giường king", Acreage = "55m²", Price = "2200000", Unit = "VNĐ", CreatedAt = SeedIds.CreatedAt },
            new RoomCategory { Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-bbbbbbbbbb05"), ServiceId = ComboDaNangId, Titile = "Ocean View Suite", NumberOfCustomer = 2, NumberOfBed = "1 giường king", Acreage = "60m²", Price = "2800000", Unit = "VNĐ", CreatedAt = SeedIds.CreatedAt },
            new RoomCategory { Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-bbbbbbbbbb06"), ServiceId = ComboDaNangId, Titile = "Presidential Suite", NumberOfCustomer = 4, NumberOfBed = "2 giường king", Acreage = "90m²", Price = "5000000", Unit = "VNĐ", CreatedAt = SeedIds.CreatedAt },

            // Room categories for Sa Pa Cloud Retreat
            new RoomCategory { Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-bbbbbbbbbb07"), ServiceId = HotelSaPaId, Titile = "Eco Lodge Room", NumberOfCustomer = 2, NumberOfBed = "1 giường đôi", Acreage = "28m²", Price = "950000", Unit = "VNĐ", CreatedAt = SeedIds.CreatedAt },
            new RoomCategory { Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-bbbbbbbbbb08"), ServiceId = HotelSaPaId, Titile = "Mountain View Room", NumberOfCustomer = 2, NumberOfBed = "1 giường king", Acreage = "35m²", Price = "1200000", Unit = "VNĐ", CreatedAt = SeedIds.CreatedAt },

            // Room categories for Metropole Lune (Hà Nội)
            new RoomCategory { Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-bbbbbbbbbb09"), ServiceId = HotelHaNoiId, Titile = "Royal Suite", NumberOfCustomer = 2, NumberOfBed = "1 giường king", Acreage = "50m²", Price = "2100000", Unit = "VNĐ", CreatedAt = SeedIds.CreatedAt },
            new RoomCategory { Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-bbbbbbbbbb10"), ServiceId = HotelHaNoiId, Titile = "Classic Room", NumberOfCustomer = 2, NumberOfBed = "1 giường đôi", Acreage = "30m²", Price = "1400000", Unit = "VNĐ", CreatedAt = SeedIds.CreatedAt }
        );
    }
}
