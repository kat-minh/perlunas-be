using Cms.Repository.Entities;
using Cms.Repository.Configurations.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class FormConfiguration : IEntityTypeConfiguration<Form>
{
    public void Configure(EntityTypeBuilder<Form> builder)
    {
        builder.ToTable("Forms");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Where).HasMaxLength(255);
        builder.Property(x => x.Slug).HasMaxLength(255);
        builder.Property(x => x.Month).HasMaxLength(50);
        builder.Property(x => x.Year).HasMaxLength(50);
        builder.Property(x => x.LongTime).HasMaxLength(255);
        builder.Property(x => x.ComboService).HasMaxLength(255);
        builder.Property(x => x.Note).HasMaxLength(2000);
        builder.Property(x => x.FullName).HasMaxLength(255);
        builder.Property(x => x.Phone).HasMaxLength(50);
        builder.Property(x => x.Email).HasMaxLength(255);
        builder.Property(x => x.Website).HasMaxLength(255);
        builder.Property(x => x.ContactName).HasMaxLength(255);
        builder.Property(x => x.PromotionalInformation).HasDefaultValue(false);
        builder.Property(x => x.Type).HasConversion<string>().HasMaxLength(50);
        builder.Property(x => x.CreatedAt).HasDefaultValueSql("now()");

        // Relationships
        builder.HasOne(x => x.Service)
            .WithMany(x => x.Forms)
            .HasForeignKey(x => x.ServiceId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.SeedForm();
    }
}
