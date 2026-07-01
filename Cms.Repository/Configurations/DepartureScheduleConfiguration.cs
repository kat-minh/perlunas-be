using Cms.Repository.Entities;
using Cms.Repository.Configurations.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class DepartureScheduleConfiguration : IEntityTypeConfiguration<DepartureSchedule>
{
    public void Configure(EntityTypeBuilder<DepartureSchedule> builder)
    {
        builder.ToTable("DepartureSchedules");

        builder.Property(x => x.StartTime).HasMaxLength(100);
        builder.Property(x => x.Code).HasMaxLength(50);
        builder.Property(x => x.CreatedAt).HasDefaultValueSql("now()");

        builder.SeedDepartureSchedule();
    }
}
