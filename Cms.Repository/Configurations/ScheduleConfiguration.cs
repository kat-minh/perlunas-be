using Cms.Repository.Entities;
using Cms.Repository.Configurations.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
{
    public void Configure(EntityTypeBuilder<Schedule> builder)
    {
        builder.ToTable("Schedules");

        builder.Property(x => x.Day).HasMaxLength(50);
        builder.Property(x => x.Titile).HasMaxLength(255);
        builder.Property(x => x.CreatedAt).HasDefaultValueSql("now()");

        builder.SeedSchedule();
    }
}
