using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cms.Repository;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Entities.Service> Services => Set<Entities.Service>();
    public DbSet<Schedule> Schedules => Set<Schedule>();
    public DbSet<RoomCategory> RoomCategories => Set<RoomCategory>();
    public DbSet<DepartureSchedule> DepartureSchedules => Set<DepartureSchedule>();
    public DbSet<ImportantInfor> ImportantInfors => Set<ImportantInfor>();
    public DbSet<PageContent> PageContents => Set<PageContent>();
    public DbSet<SiteSetting> SiteSettings => Set<SiteSetting>();
    public DbSet<Blog> Blogs => Set<Blog>();
    public DbSet<Taxonomy> Taxonomies => Set<Taxonomy>();
    public DbSet<Form> Forms => Set<Form>();
    public DbSet<FormDetails> FormDetails => Set<FormDetails>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);
    }
}
