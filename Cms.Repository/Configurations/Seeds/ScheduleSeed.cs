using Cms.Repository.Enums;
using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class ScheduleSeed
{
    public static void SeedSchedule(this EntityTypeBuilder<Schedule> builder) { }
}
