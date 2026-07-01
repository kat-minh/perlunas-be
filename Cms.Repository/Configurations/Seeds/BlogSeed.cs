using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class BlogSeed
{
    public static void SeedBlog(this EntityTypeBuilder<Blog> builder)
    {
        builder.HasData(
            new Blog { Id = SeedIds.BlogMain, Titile = "Sample travel guide", SubTitile = "Start here", Author = "Perlunas Admin", ReadingTime = "5 min", Description = "Sample blog content.", Tag = "guide", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new Blog { Id = SeedIds.BlogResort, Titile = "How to choose a resort", SubTitile = "Family travel tips", Author = "Perlunas Admin", ReadingTime = "7 min", Description = "Tips for selecting a resort package.", Tag = "resort", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new Blog { Id = SeedIds.BlogPrivate, Titile = "Private tour planning", SubTitile = "Flexible journeys", Author = "Perlunas Admin", ReadingTime = "6 min", Description = "How to prepare for a private custom trip.", Tag = "private-tour", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt });
    }
}
