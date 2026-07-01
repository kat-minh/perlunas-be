using Cms.Repository.Entities;
using Cms.Repository.Configurations.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class RoomCategoryConfiguration : IEntityTypeConfiguration<RoomCategory>
{
    public void Configure(EntityTypeBuilder<RoomCategory> builder)
    {
        builder.ToTable("RoomCategories");

        builder.Property(x => x.Titile).HasMaxLength(255);
        builder.Property(x => x.Acreage).HasMaxLength(100);
        builder.Property(x => x.CreatedAt).HasDefaultValueSql("now()");

        builder.SeedRoomCategory();
    }
}
