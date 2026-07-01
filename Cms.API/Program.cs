using System.Text.Json.Serialization;
using Cms.API.Extentions;
using Cms.API.Middleware;
using Cms.Repository;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

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
builder.Services.AddJwtServices(builder.Configuration);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var dataSourceBuilder = new NpgsqlDataSourceBuilder(connectionString);
dataSourceBuilder.EnableDynamicJson();
var dataSource = dataSourceBuilder.Build();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(dataSource)
);

builder.Services.AddHttpClient();
builder.Services.Configure<Cms.Service.JwtService.JwtOption>(builder.Configuration.GetSection(nameof(Cms.Service.JwtService.JwtOption)));
builder.Services.AddScoped<Cms.Service.JwtService.IService, Cms.Service.JwtService.Service>();
builder.Services.AddScoped<Cms.Service.Auth.IService, Cms.Service.Auth.Service>();
builder.Services.AddScoped<Cms.Service.Blog.IService, Cms.Service.Blog.Service>();
builder.Services.AddScoped<Cms.Service.PageContent.IService, Cms.Service.PageContent.Service>();
builder.Services.AddScoped<Cms.Service.Service.IService, Cms.Service.Service.Service>();
builder.Services.AddScoped<Cms.Service.Schedule.IService, Cms.Service.Schedule.Service>();
builder.Services.AddScoped<Cms.Service.RoomCategory.IService, Cms.Service.RoomCategory.Service>();
builder.Services.AddScoped<Cms.Service.DepartureSchedule.IService, Cms.Service.DepartureSchedule.Service>();
builder.Services.AddScoped<Cms.Service.ImportantInfor.IService, Cms.Service.ImportantInfor.Service>();
builder.Services.AddScoped<Cms.Service.SiteSetting.IService, Cms.Service.SiteSetting.Service>();
builder.Services.AddValidatorsFromAssembly(Cms.Service.AssemblyReference.Assembly);

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
