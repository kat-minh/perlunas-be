using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class RoomCategorySeed
{
    public static void SeedRoomCategory(this EntityTypeBuilder<RoomCategory> builder)
    {
        builder.HasData(
            new RoomCategory { Id = SeedIds.RoomDeluxe, ServiceId = SeedIds.ServiceResort, Album = "[]", Titile = "Deluxe Room", NumberOfCustomer = 2, Acreage = "35m2", NumberOfBed = 1, Description = "Sample deluxe room.", Feature = "Balcony, breakfast, sea view", Price = "1200000/night", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new RoomCategory { Id = SeedIds.RoomVilla, ServiceId = SeedIds.ServiceResort, Album = "[]", Titile = "Family Villa", NumberOfCustomer = 4, Acreage = "80m2", NumberOfBed = 2, Description = "Private family villa near the beach.", Feature = "Private pool, kitchen, breakfast", Price = "3500000/night", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new RoomCategory { Id = SeedIds.RoomSuite, ServiceId = SeedIds.ServicePrivate, Album = "[]", Titile = "Heritage Suite", NumberOfCustomer = 2, Acreage = "45m2", NumberOfBed = 1, Description = "Suite for private journey guests.", Feature = "Old town view, breakfast", Price = null, CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt });
    }
}
