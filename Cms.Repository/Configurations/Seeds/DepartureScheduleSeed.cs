using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class DepartureScheduleSeed
{
    public static void SeedDepartureSchedule(this EntityTypeBuilder<DepartureSchedule> builder)
    {
        builder.HasData(
            new DepartureSchedule { Id = SeedIds.DepartureSummer, ServiceId = SeedIds.ServiceMain, StartTime = "2026-07-15", Code = "DEP-001", Price = "3500000/customer", AccommodationStandards = "3-star hotel", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new DepartureSchedule { Id = SeedIds.DepartureAutumn, ServiceId = SeedIds.ServiceMain, StartTime = "2026-09-20", Code = "DEP-002", Price = "5200000/customer", AccommodationStandards = "4-star resort", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new DepartureSchedule { Id = SeedIds.DeparturePrivate, ServiceId = SeedIds.ServiceMain, StartTime = "On request", Code = "DEP-003", Price = "Quote on request", AccommodationStandards = "Boutique hotel", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new DepartureSchedule { Id = Guid.Parse("44444444-4444-4444-4444-333333333311"), ServiceId = Guid.Parse("11111111-1111-1111-1111-333333333311"), StartTime = "Weekly", Code = "DEP-VN1", Price = "4000000/customer", AccommodationStandards = "3-star hotel", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new DepartureSchedule { Id = Guid.Parse("44444444-4444-4444-4444-333333333312"), ServiceId = Guid.Parse("11111111-1111-1111-1111-333333333312"), StartTime = "Weekly", Code = "DEP-VN2", Price = "4500000/customer", AccommodationStandards = "3-star hotel", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new DepartureSchedule { Id = Guid.Parse("44444444-4444-4444-4444-333333333313"), ServiceId = Guid.Parse("11111111-1111-1111-1111-333333333313"), StartTime = "Weekly", Code = "DEP-TH1", Price = "3800000/customer", AccommodationStandards = "3-star hotel", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt });
    }
}
