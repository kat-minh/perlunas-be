using System.Text.Json.Serialization;
using Cms.API.Extentions;
using Cms.API.Middleware;
using Cms.Repository;
using Cms.Service.Common;
using Cms.Service.JwtService;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Npgsql;

// Feature aliases for DI registration
using AuthService = Cms.Service.Auth;
using ToursService = Cms.Service.Tours;
using HotelsService = Cms.Service.Hotels;
using CombosService = Cms.Service.Combos;
using SiteSettingsService = Cms.Service.SiteSettings;
using ContactMessagesService = Cms.Service.ContactMessages;
using UsersService = Cms.Service.Users;
using TourCardsService = Cms.Service.TourCards;
using ComboTiersService = Cms.Service.ComboTiers;
using TaxonomiesService = Cms.Service.Taxonomies;
using PageContentService = Cms.Service.PageContent;
using JwtService = Cms.Service.JwtService;
using Cms.Service.CurrentUser;

var builder = WebApplication.CreateBuilder(args);

// PaaS platforms (Railway, Render, Heroku…) inject the public port via $PORT.
var port = Environment.GetEnvironmentVariable("PORT");
if (!string.IsNullOrWhiteSpace(port))
    builder.WebHost.UseUrls($"http://0.0.0.0:{port}");

builder.Services.AddTransient<GlobalExceptionHandlerMiddleware>();

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerServices();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var dataSourceBuilder = new NpgsqlDataSourceBuilder(connectionString);
dataSourceBuilder.EnableDynamicJson();
var dataSource = dataSourceBuilder.Build();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(dataSource)
);

builder.Services.AddJwtServices(builder.Configuration);
builder.Services.AddHttpContextAccessor();
builder.Services.AddHttpClient();
builder.Services.AddValidatorsFromAssembly(Cms.Service.AssemblyReference.Assembly);

// ── DI ─────────────────────────────────────────────────────────────────────
builder.Services.Configure<JwtOption>(builder.Configuration.GetSection("Jwt"));
builder.Services.AddScoped<ICurrentUserService, CurrentUserService>();

builder.Services.AddScoped<JwtService.IService, JwtService.Service>();

builder.Services.AddScoped<AuthService.IService, AuthService.Service>();
builder.Services.AddScoped<ToursService.IService, ToursService.Service>();
builder.Services.AddScoped<HotelsService.IService, HotelsService.Service>();
builder.Services.AddScoped<CombosService.IService, CombosService.Service>();
builder.Services.AddScoped<SiteSettingsService.IService, SiteSettingsService.Service>();
builder.Services.AddScoped<ContactMessagesService.IService, ContactMessagesService.Service>();
builder.Services.AddScoped<UsersService.IService, UsersService.Service>();
builder.Services.AddScoped<TourCardsService.IService, TourCardsService.Service>();
builder.Services.AddScoped<ComboTiersService.IService, ComboTiersService.Service>();
builder.Services.AddScoped<TaxonomiesService.IService, TaxonomiesService.Service>();
builder.Services.AddScoped<PageContentService.IService, PageContentService.Service>();

// ── CORS ───────────────────────────────────────────────────────────────────
const string CorsPolicy = "NextjsFrontend";
var allowedOrigins =
    (builder.Configuration.GetSection("Cors:AllowedOrigins").Get<string[]>()
    ?? new[] { "http://localhost:3000", "http://localhost:3001" })
    .Select(o => o.TrimEnd('/')).ToArray();

builder.Services.AddCors(options =>
{
    options.AddPolicy(CorsPolicy, policy =>
        policy.WithOrigins(allowedOrigins)
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials());
});

var app = builder.Build();

// ── Auto migration ─────────────────────────────────────────────────────────
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await db.Database.MigrateAsync();
}

// ── Middleware pipeline ────────────────────────────────────────────────────
app.UseMiddleware<GlobalExceptionHandlerMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerAPI();
}

app.UseCors(CorsPolicy);
app.UseAuthentication();
app.UseAuthorization();

app.UseMiddleware<RevalidationMiddleware>();
app.MapControllers();

app.Run();
