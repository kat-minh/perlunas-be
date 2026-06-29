using Cms.Repository.Configurations.Seeds;
using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class ContactMessageConfiguration : IEntityTypeConfiguration<ContactMessage>
{
    public void Configure(EntityTypeBuilder<ContactMessage> builder)
    {
        builder.HasKey(m => m.Id);
        builder.Property(m => m.Name).IsRequired().HasMaxLength(150);
        builder.Property(m => m.Email).IsRequired().HasMaxLength(256);
        builder.Property(m => m.Phone).HasMaxLength(50);
        builder.Property(m => m.Subject).HasMaxLength(200);
        builder.Property(m => m.CreatedAt).HasDefaultValueSql("now()");

        builder.SeedContactMessage();
    }
}
