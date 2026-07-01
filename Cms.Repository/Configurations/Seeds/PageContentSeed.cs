using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class PageContentSeed
{
    public static void SeedPageContent(this EntityTypeBuilder<PageContent> builder)
    {
        builder.HasData(
            new PageContent { Id = SeedIds.PageHomeHero, PageKey = "home", SectionKey = "hero", Key = "title", ContentValue = "Discover Perlunas", Label = "Hero title", Kind = "text", SoftOrder = 1, CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new PageContent { Id = SeedIds.PageAboutIntro, PageKey = "about", SectionKey = "intro", Key = "description", ContentValue = "We craft thoughtful travel experiences.", Label = "About intro", Kind = "textarea", SoftOrder = 1, CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new PageContent { Id = SeedIds.PageServiceBanner, PageKey = "services", SectionKey = "banner", Key = "subtitle", ContentValue = "Choose a journey that fits your style.", Label = "Service banner subtitle", Kind = "text", SoftOrder = 2, CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new PageContent { Id = SeedIds.PageHomeHeroChild1, ParentId = SeedIds.PageHomeHero, PageKey = "home", SectionKey = "hero", Key = "subtitle", ContentValue = "Explore breathtaking destinations with us", Label = "Hero subtitle", Kind = "text", SoftOrder = 2, CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt },
            new PageContent { Id = SeedIds.PageHomeHeroChild2, ParentId = SeedIds.PageHomeHero, PageKey = "home", SectionKey = "hero", Key = "cta", ContentValue = "Book Now", Label = "Hero CTA button", Kind = "text", SoftOrder = 3, CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt });
    }
}
