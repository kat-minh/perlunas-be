using Cms.Repository.Entities;
using Cms.Repository.Configurations.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class ServiceConfiguration : IEntityTypeConfiguration<Entities.Service>
{
    public void Configure(EntityTypeBuilder<Entities.Service> builder)
    {
        builder.ToTable("Services");

        builder.Property(x => x.Title).HasMaxLength(255);
        builder.Property(x => x.Slug).HasMaxLength(255).IsRequired();
        builder.Property(x => x.BestSeller).HasDefaultValue(false);
        builder.Property(x => x.Label).HasMaxLength(255);
        builder.Property(x => x.Region).HasMaxLength(255);
        builder.Property(x => x.Code).HasMaxLength(50);
        builder.Property(x => x.Type).HasMaxLength(50).HasConversion<string>();
        builder.Property(x => x.PurposeOfTrip).HasMaxLength(50);
        builder.Property(x => x.Destination).HasMaxLength(255);
        builder.Property(x => x.Form).HasMaxLength(100);
        builder.Property(x => x.Classify).HasMaxLength(50);
        builder.Property(x => x.CreatedAt).HasDefaultValueSql("now()");

        builder.HasIndex(x => x.Slug).IsUnique();
        builder.HasIndex(x => x.Code);
        builder.HasIndex(x => x.Type);

        builder.HasMany(x => x.Schedules).WithOne(x => x.Service).HasForeignKey("ServiceId").OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(x => x.RoomCategories).WithOne(x => x.Service).HasForeignKey("ServiceId").OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(x => x.DepartureSchedules).WithOne(x => x.Service).HasForeignKey("ServiceId").OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(x => x.ImportantInfors).WithOne(x => x.Service).HasForeignKey("ServiceId").OnDelete(DeleteBehavior.Cascade);

        builder.SeedService();
    }
}
