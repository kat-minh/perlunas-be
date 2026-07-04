using Cms.Repository.Entities;
using Cms.Repository.Configurations.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class FormDetailsConfiguration : IEntityTypeConfiguration<FormDetails>
{
    public void Configure(EntityTypeBuilder<FormDetails> builder)
    {
        builder.ToTable("FormDetails");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.RoomCategory).HasColumnType("text[]");
        builder.Property(x => x.ReceiveTime).HasMaxLength(100);
        builder.Property(x => x.EndTime).HasMaxLength(100);
        builder.Property(x => x.UnitPrice).HasMaxLength(50);
        builder.Property(x => x.CreatedAt).HasDefaultValueSql("now()");

        // Relationships
        builder.HasOne(x => x.Form)
            .WithMany(x => x.FormDetails)
            .HasForeignKey(x => x.FormId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.SeedFormDetails();
    }
}
