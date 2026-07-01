using Cms.Repository.Entities;
using Cms.Repository.Configurations.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class ImportantInforConfiguration : IEntityTypeConfiguration<ImportantInfor>
{
    public void Configure(EntityTypeBuilder<ImportantInfor> builder)
    {
        builder.ToTable("ImportantInfors");

        builder.Property(x => x.Title).HasMaxLength(255);
        builder.Property(x => x.SubTitle).HasMaxLength(255);
        builder.Property(x => x.CreatedAt).HasDefaultValueSql("now()");

        builder.SeedImportantInfor();
    }
}
