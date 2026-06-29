using Cms.Repository.Configurations.Seeds;
using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class ComboConfiguration : IEntityTypeConfiguration<Combo>
{
    public void Configure(EntityTypeBuilder<Combo> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Slug).IsRequired().HasMaxLength(200);
        builder.HasIndex(c => c.Slug).IsUnique();
        builder.Property(c => c.Price).HasMaxLength(100);
        builder.Property(c => c.CreatedAt).HasDefaultValueSql("now()");

        builder.HasOne(c => c.Hotel)
            .WithMany(h => h.Combos)
            .HasForeignKey(c => c.HotelId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(c => c.ComboTier)
            .WithMany(ct => ct.Combos)
            .HasForeignKey(c => c.ComboTierId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.SeedCombo();
    }
}
