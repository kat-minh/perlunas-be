using Cms.Repository.Enums;
using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class DepartureScheduleSeed
{
    public static void SeedDepartureSchedule(this EntityTypeBuilder<DepartureSchedule> builder) { }
}
