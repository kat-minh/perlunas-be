using Cms.Repository.Enums;
using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class RoomCategorySeed
{
    public static void SeedRoomCategory(this EntityTypeBuilder<RoomCategory> builder) { }
}
