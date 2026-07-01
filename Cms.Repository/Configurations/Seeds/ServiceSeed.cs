using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class ServiceSeed
{
    public static void SeedService(this EntityTypeBuilder<Entities.Service> builder)
    {
        builder.HasData(
            new Entities.Service
            {
                Id = SeedIds.ServiceMain,
                Title = "Perlunas Signature Tour",
                Introducetion = "Sample introduction for the main service.",
                Day = 3,
                Night = 2,
                Label = "Featured",
                Album = "[]",
                Region = "Vietnam",
                Description = "Sample service description.",
                Infor = "Sample service information.",
                Highlight = "Sample service highlights.",
                Code = "PLN-001",
                Instruct = "Sample instructions.",
                Feature = "Sample features.",
                Type = "Tour",
                IsPublic = true,
                CreatedAt = SeedIds.CreatedAt,
                UpdatedAt = SeedIds.CreatedAt,
            },
            new Entities.Service
            {
                Id = SeedIds.ServiceResort,
                Title = "Beach Resort Package",
                Introducetion = "Relaxing resort stay for families.",
                Day = 4,
                Night = 3,
                Label = "Family",
                Album = "[]",
                Region = "Da Nang",
                Description = "Beachfront resort package.",
                Infor = "Includes room and breakfast.",
                Highlight = "Private beach, spa, local dining",
                Code = "PLN-002",
                Instruct = "Bring identification for check-in.",
                Feature = "Resort, breakfast, pool",
                Type = "Hotel",
                IsPublic = true,
                CreatedAt = SeedIds.CreatedAt,
                UpdatedAt = SeedIds.CreatedAt,
            },
            new Entities.Service
            {
                Id = SeedIds.ServicePrivate,
                Title = "Private Custom Journey",
                Introducetion = "Custom private trip with flexible schedule.",
                Day = 2,
                Night = 1,
                Label = "Private",
                Album = "[]",
                Region = "Hoi An",
                Description = "Private travel experience.",
                Infor = "Dedicated guide and vehicle.",
                Highlight = "Flexible route, private guide",
                Code = "PLN-003",
                Instruct = "Confirm itinerary before departure.",
                Feature = "Private guide, custom route",
                Type = "PrivateTour",
                IsPublic = true,
                CreatedAt = SeedIds.CreatedAt,
                UpdatedAt = SeedIds.CreatedAt,
            });
    }
}
