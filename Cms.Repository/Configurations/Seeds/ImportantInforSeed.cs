using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class ImportantInforSeed
{
    public static void SeedImportantInfor(this EntityTypeBuilder<ImportantInfor> builder)
    {
        builder.HasData(
            new ImportantInfor { Id = SeedIds.ImportantPolicy, ServiceId = SeedIds.ServiceMain, Title = "Cancellation policy", SubTitle = "Important before booking", Description = "Cancellation terms depend on departure date.", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new ImportantInfor { Id = SeedIds.ImportantResort, ServiceId = SeedIds.ServiceResort, Title = "Resort check-in", SubTitle = "Required documents", Description = "Guests must present valid identification at check-in.", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new ImportantInfor { Id = SeedIds.ImportantPrivate, ServiceId = SeedIds.ServicePrivate, Title = "Private itinerary", SubTitle = "Custom planning", Description = "Final itinerary must be confirmed 48 hours before departure.", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt });
    }
}
