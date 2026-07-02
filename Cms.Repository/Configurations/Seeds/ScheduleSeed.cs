using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class ScheduleSeed
{
    public static void SeedSchedule(this EntityTypeBuilder<Schedule> builder)
    {
        builder.HasData(
            new Schedule { Id = SeedIds.ScheduleDay1, ServiceId = SeedIds.ServiceMain, Day = "Day 1", Titile = "Arrival", Sumary = "Arrive and settle in.", Description = "Airport pickup and welcome dinner.", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new Schedule { Id = SeedIds.ScheduleDay2, ServiceId = SeedIds.ServiceMain, Day = "Day 2", Titile = "Experience", Sumary = "Explore the destination.", Description = "Guided tour and local activities.", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new Schedule { Id = SeedIds.ScheduleResortDay1, ServiceId = SeedIds.ServiceResort, Day = "Day 1", Titile = "Resort check-in", Sumary = "Check in and relax.", Description = "Welcome drink, room check-in, free beach time.", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new Schedule { Id = SeedIds.SchedulePrivateDay1, ServiceId = SeedIds.ServicePrivate, Day = "Day 1", Titile = "Private discovery", Sumary = "Private tour with local guide.", Description = "Custom stops based on customer preference.", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt });
    }
}
