using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cms.Repository;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Tour> Tours => Set<Tour>();
    public DbSet<Hotel> Hotels => Set<Hotel>();
    public DbSet<Combo> Combos => Set<Combo>();
    public DbSet<ComboTier> ComboTiers => Set<ComboTier>();
    public DbSet<Taxonomy> Taxonomies => Set<Taxonomy>();
    public DbSet<TourCard> TourCards => Set<TourCard>();
    public DbSet<SiteSetting> SiteSettings => Set<SiteSetting>();
    public DbSet<ContactMessage> ContactMessages => Set<ContactMessage>();
    public DbSet<PageContent> PageContents => Set<PageContent>();
    public DbSet<HotelTaxonomyDetails> HotelTaxonomyDetails => Set<HotelTaxonomyDetails>();
    public DbSet<RefreshToken> RefreshTokens => Set<RefreshToken>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);
    }
}
