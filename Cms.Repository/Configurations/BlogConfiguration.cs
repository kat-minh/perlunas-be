using Cms.Repository.Entities;
using Cms.Repository.Configurations.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations;

public class BlogConfiguration : IEntityTypeConfiguration<Blog>
{
    public void Configure(EntityTypeBuilder<Blog> builder)
    {
        builder.ToTable("Blogs");

        builder.Property(x => x.Titile).HasMaxLength(255);
        builder.Property(x => x.SubTitile).HasMaxLength(255);
        builder.Property(x => x.Author).HasMaxLength(255);
        builder.Property(x => x.ReadingTime).HasMaxLength(50);
        builder.Property(x => x.Tag).HasMaxLength(255);
        builder.Property(x => x.Slug).HasMaxLength(255);
        builder.Property(x => x.Cover).HasMaxLength(1024);
        builder.HasIndex(x => x.Slug);
        builder.Property(x => x.CreatedAt).HasDefaultValueSql("now()");

        builder.SeedBlog();
    }
}
