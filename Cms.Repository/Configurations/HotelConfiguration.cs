using Cms.Repository.Configurations.Seeds;
using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
{
    public void Configure(EntityTypeBuilder<Hotel> builder)
    {
        builder.HasKey(h => h.Id);
        builder.Property(h => h.Slug).IsRequired().HasMaxLength(200);
        builder.HasIndex(h => h.Slug).IsUnique();
        builder.Property(h => h.Name).IsRequired().HasMaxLength(300);
        builder.Property(h => h.Price).HasMaxLength(100);
        builder.Property(h => h.CreatedAt).HasDefaultValueSql("now()");

        builder.SeedHotel();
    }
}
