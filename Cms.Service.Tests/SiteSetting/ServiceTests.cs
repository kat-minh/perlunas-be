using Cms.Repository;
using SiteSettingEntity = Cms.Repository.Entities.SiteSetting;
using Cms.Service.Exceptions;
using Cms.Service.SiteSetting;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace Cms.Service.Tests.SiteSetting;

public class ServiceTests
{
    private static DbContextOptions<AppDbContext> NewDb() =>
        new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

    private static Mock<IValidator<Request.CreateSiteSettingRequest>> CreateValidatorMock(bool valid = true)
    {
        var mock = new Mock<IValidator<Request.CreateSiteSettingRequest>>();
        mock.Setup(x => x.ValidateAsync(
                It.IsAny<Request.CreateSiteSettingRequest>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult(valid ? [] : new List<ValidationFailure> { new("Name", "NAME_REQUIRED") }));
        return mock;
    }

    private static Mock<IValidator<Request.UpdateSiteSettingRequest>> UpdateValidatorMock(bool valid = true)
    {
        var mock = new Mock<IValidator<Request.UpdateSiteSettingRequest>>();
        mock.Setup(x => x.ValidateAsync(
                It.IsAny<ValidationContext<Request.UpdateSiteSettingRequest>>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult(valid ? [] : new List<ValidationFailure> { new("Name", "NAME_REQUIRED") }));
        return mock;
    }

    private static Request.CreateSiteSettingRequest ValidCreateRequest => new()
    {
        Name = "Perlunas",
        LegalName = "Perlunas Travel Co.",
        Tagline = "Explore Vietnam",
        Manifesto = "We believe in travel",
        Description = "A travel platform",
        Phone = "+84 123 456 789",
        Email = "hello@perlunas.com",
        TaxId = "1234567890",
        OfficesJson = "[{\"city\":\"Hanoi\"}]",
        SocialJson = "[{\"platform\":\"facebook\"}]"
    };

    private static Request.UpdateSiteSettingRequest ValidUpdateRequest => new()
    {
        Name = "Perlunas Updated",
        LegalName = "Perlunas Travel Updated",
        Tagline = "Explore Vietnam Better",
        Manifesto = "Updated manifesto",
        Description = "Updated description",
        Phone = "+84 987 654 321",
        Email = "updated@perlunas.com",
        TaxId = "0987654321",
        OfficesJson = "[{\"city\":\"HCMC\"}]",
        SocialJson = "[{\"platform\":\"instagram\"}]"
    };

    // ===== CreateAsync =====

    [Fact]
    public async Task CreateAsync_WithValidRequest_ShouldCreateSiteSetting()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.SiteSetting.Service(ctx, createValidator.Object, updateValidator.Object);

        var result = await service.CreateAsync(ValidCreateRequest);

        result.Should().NotBeNull();
        result.Name.Should().Be("Perlunas");
        result.LegalName.Should().Be("Perlunas Travel Co.");
        result.Tagline.Should().Be("Explore Vietnam");
        result.Manifesto.Should().Be("We believe in travel");
        result.Description.Should().Be("A travel platform");
        result.Phone.Should().Be("+84 123 456 789");
        result.Email.Should().Be("hello@perlunas.com");
        result.TaxId.Should().Be("1234567890");
        result.OfficesJson.Should().Be("[{\"city\":\"Hanoi\"}]");
        result.SocialJson.Should().Be("[{\"platform\":\"facebook\"}]");
        result.CreatedAt.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(5));
        result.UpdatedAt.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(5));
    }

    // ===== UpdateAsync =====

    [Fact]
    public async Task UpdateAsync_WithValidRequest_ShouldUpdateSiteSetting()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var siteSettingId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.SiteSettings.Add(new SiteSettingEntity
            {
                Id = siteSettingId,
                Name = "Original",
                LegalName = "Original Legal",
                Tagline = "Original Tagline",
                Manifesto = "Original Manifesto",
                Description = "Original desc",
                Phone = "000",
                Email = "original@test.com",
                TaxId = "000",
                OfficesJson = "[]",
                SocialJson = "[]",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.SiteSetting.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.UpdateAsync(siteSettingId, ValidUpdateRequest);

            result.Name.Should().Be("Perlunas Updated");
            result.LegalName.Should().Be("Perlunas Travel Updated");
            result.Tagline.Should().Be("Explore Vietnam Better");
            result.Manifesto.Should().Be("Updated manifesto");
            result.Description.Should().Be("Updated description");
            result.Phone.Should().Be("+84 987 654 321");
            result.Email.Should().Be("updated@perlunas.com");
            result.TaxId.Should().Be("0987654321");
            result.OfficesJson.Should().Be("[{\"city\":\"HCMC\"}]");
            result.SocialJson.Should().Be("[{\"platform\":\"instagram\"}]");
            result.UpdatedAt.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(5));
        }
    }

    [Fact]
    public async Task UpdateAsync_WhenSiteSettingDoesNotExist_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.SiteSetting.Service(ctx, createValidator.Object, updateValidator.Object);

        var act = () => service.UpdateAsync(Guid.NewGuid(), ValidUpdateRequest);

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Site setting not found.");
    }

    // ===== DeleteAsync =====

    [Fact]
    public async Task DeleteAsync_WhenSiteSettingExists_ShouldSoftDelete()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var siteSettingId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.SiteSettings.Add(new SiteSettingEntity
            {
                Id = siteSettingId,
                Name = "To Delete",
                LegalName = "",
                Tagline = "",
                Manifesto = "",
                Description = "",
                Phone = "",
                Email = "",
                TaxId = "",
                OfficesJson = "",
                SocialJson = "",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.SiteSetting.Service(ctx, createValidator.Object, updateValidator.Object);
            var msg = await service.DeleteAsync(siteSettingId);

            msg.Should().Be("Site setting deleted successfully.");
        }

        await using (var ctx = new AppDbContext(options))
        {
            var siteSetting = await ctx.SiteSettings.IgnoreQueryFilters().FirstOrDefaultAsync(x => x.Id == siteSettingId);
            siteSetting!.IsDeleted.Should().BeTrue();
        }
    }

    [Fact]
    public async Task DeleteAsync_WhenSiteSettingDoesNotExist_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.SiteSetting.Service(ctx, createValidator.Object, updateValidator.Object);

        var act = () => service.DeleteAsync(Guid.NewGuid());

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Site setting not found.");
    }

    // ===== GetByIdAsync =====

    [Fact]
    public async Task GetByIdAsync_WhenSiteSettingExists_ShouldReturnSiteSetting()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var siteSettingId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.SiteSettings.Add(new SiteSettingEntity
            {
                Id = siteSettingId,
                Name = "Find Me",
                LegalName = "Legal",
                Tagline = "Tagline",
                Manifesto = "Manifesto",
                Description = "Desc",
                Phone = "123",
                Email = "find@test.com",
                TaxId = "456",
                OfficesJson = "[]",
                SocialJson = "[]",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.SiteSetting.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetByIdAsync(siteSettingId);

            result.Name.Should().Be("Find Me");
            result.Email.Should().Be("find@test.com");
        }
    }

    [Fact]
    public async Task GetByIdAsync_WhenSiteSettingDoesNotExist_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.SiteSetting.Service(ctx, createValidator.Object, updateValidator.Object);

        var act = () => service.GetByIdAsync(Guid.NewGuid());

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Site setting not found.");
    }

    [Fact]
    public async Task GetByIdAsync_WhenSiteSettingIsDeleted_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var siteSettingId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.SiteSettings.Add(new SiteSettingEntity
            {
                Id = siteSettingId,
                Name = "Deleted",
                LegalName = "",
                Tagline = "",
                Manifesto = "",
                Description = "",
                Phone = "",
                Email = "",
                TaxId = "",
                OfficesJson = "",
                SocialJson = "",
                IsDeleted = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.SiteSetting.Service(ctx, createValidator.Object, updateValidator.Object);
            var act = () => service.GetByIdAsync(siteSettingId);

            await act.Should().ThrowAsync<NotFoundException>()
                .WithMessage("Site setting not found.");
        }
    }

    // ===== GetAllAsync =====

    [Fact]
    public async Task GetAllAsync_WithNoFilters_ShouldReturnAllNonDeleted()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.SiteSettings.AddRange(
                new SiteSettingEntity { Id = Guid.NewGuid(), Name = "Site A", LegalName = "", Tagline = "", Manifesto = "", Description = "", Phone = "", Email = "", TaxId = "", OfficesJson = "", SocialJson = "", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new SiteSettingEntity { Id = Guid.NewGuid(), Name = "Site B", LegalName = "", Tagline = "", Manifesto = "", Description = "", Phone = "", Email = "", TaxId = "", OfficesJson = "", SocialJson = "", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.SiteSetting.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetAllAsync(null, null, null);

            result.Value.Should().BeAssignableTo<List<Response.SiteSettingResponse>>().Which.Should().HaveCount(2);
        }
    }

    [Fact]
    public async Task GetAllAsync_WithIdFilter_ShouldReturnMatching()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var targetId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.SiteSettings.AddRange(
                new SiteSettingEntity { Id = targetId, Name = "Target", LegalName = "", Tagline = "", Manifesto = "", Description = "", Phone = "", Email = "", TaxId = "", OfficesJson = "", SocialJson = "", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new SiteSettingEntity { Id = Guid.NewGuid(), Name = "Other", LegalName = "", Tagline = "", Manifesto = "", Description = "", Phone = "", Email = "", TaxId = "", OfficesJson = "", SocialJson = "", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.SiteSetting.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetAllAsync(targetId, null, null);

            var items = result.Value.Should().BeAssignableTo<List<Response.SiteSettingResponse>>().Subject;
            items.Should().ContainSingle(x => x.Id == targetId);
        }
    }

    [Fact]
    public async Task GetAllAsync_WithNameFilter_ShouldReturnMatching()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.SiteSettings.AddRange(
                new SiteSettingEntity { Id = Guid.NewGuid(), Name = "Perlunas Vietnam", LegalName = "", Tagline = "", Manifesto = "", Description = "", Phone = "", Email = "", TaxId = "", OfficesJson = "", SocialJson = "", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new SiteSettingEntity { Id = Guid.NewGuid(), Name = "Other Company", LegalName = "", Tagline = "", Manifesto = "", Description = "", Phone = "", Email = "", TaxId = "", OfficesJson = "", SocialJson = "", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.SiteSetting.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetAllAsync(null, "Perlunas", null);

            var items = result.Value.Should().BeAssignableTo<List<Response.SiteSettingResponse>>().Subject;
            items.Should().ContainSingle(x => x.Name == "Perlunas Vietnam");
        }
    }

    [Fact]
    public async Task GetAllAsync_WithTaglineFilter_ShouldReturnMatching()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.SiteSettings.AddRange(
                new SiteSettingEntity { Id = Guid.NewGuid(), Name = "A", LegalName = "", Tagline = "Explore Vietnam", Manifesto = "", Description = "", Phone = "", Email = "", TaxId = "", OfficesJson = "", SocialJson = "", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new SiteSettingEntity { Id = Guid.NewGuid(), Name = "B", LegalName = "", Tagline = "Something Else", Manifesto = "", Description = "", Phone = "", Email = "", TaxId = "", OfficesJson = "", SocialJson = "", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.SiteSetting.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetAllAsync(null, null, "Explore");

            var items = result.Value.Should().BeAssignableTo<List<Response.SiteSettingResponse>>().Subject;
            items.Should().ContainSingle(x => x.Name == "A");
        }
    }

    [Fact]
    public async Task GetAllAsync_ShouldExcludeDeleted()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.SiteSettings.AddRange(
                new SiteSettingEntity { Id = Guid.NewGuid(), Name = "Active", LegalName = "", Tagline = "", Manifesto = "", Description = "", Phone = "", Email = "", TaxId = "", OfficesJson = "", SocialJson = "", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new SiteSettingEntity { Id = Guid.NewGuid(), Name = "Deleted", LegalName = "", Tagline = "", Manifesto = "", Description = "", Phone = "", Email = "", TaxId = "", OfficesJson = "", SocialJson = "", IsDeleted = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.SiteSetting.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetAllAsync(null, null, null);

            var items = result.Value.Should().BeAssignableTo<List<Response.SiteSettingResponse>>().Subject;
            items.Should().ContainSingle(x => x.Name == "Active");
        }
    }

    [Fact]
    public async Task GetAllAsync_WithNoData_ShouldReturnEmpty()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.SiteSetting.Service(ctx, createValidator.Object, updateValidator.Object);

        var result = await service.GetAllAsync(null, null, null);

        var items = result.Value.Should().BeAssignableTo<List<Response.SiteSettingResponse>>().Subject;
        items.Should().BeEmpty();
    }

    // ==================================================================
    //  GetByIdAsync
    // ==================================================================

    [Fact]
    public async Task GetByIdAsync_WhenExists_ShouldReturnSiteSetting()
    {
        var options = NewDb();
        var id = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.SiteSettings.Add(new SiteSettingEntity { Id = id, Name = "Perlunas", Tagline = "Explore", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.SiteSetting.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            var result = await service.GetByIdAsync(id);

            result.Name.Should().Be("Perlunas");
            result.Tagline.Should().Be("Explore");
        }
    }

    [Fact]
    public async Task GetByIdAsync_WhenNotFound_ShouldThrowNotFound()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.SiteSetting.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);

        var act = () => service.GetByIdAsync(Guid.NewGuid());

        await act.Should().ThrowAsync<NotFoundException>().WithMessage("Site setting not found.");
    }

    [Fact]
    public async Task GetByIdAsync_WhenDeleted_ShouldThrowNotFound()
    {
        var options = NewDb();
        var id = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.SiteSettings.Add(new SiteSettingEntity { Id = id, Name = "Xoá", IsDeleted = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.SiteSetting.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            var act = () => service.GetByIdAsync(id);

            await act.Should().ThrowAsync<NotFoundException>().WithMessage("Site setting not found.");
        }
    }

    // ==================================================================
    //  UpdateAsync / DeleteAsync
    // ==================================================================

    [Fact]
    public async Task UpdateAsync_WhenNotFound_ShouldThrowNotFound()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.SiteSetting.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);

        var act = () => service.UpdateAsync(Guid.NewGuid(), ValidUpdateRequest);

        await act.Should().ThrowAsync<NotFoundException>().WithMessage("Site setting not found.");
    }

    [Fact]
    public async Task DeleteAsync_WhenExists_ShouldSoftDeleteAndReturnMessage()
    {
        var options = NewDb();
        var id = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.SiteSettings.Add(new SiteSettingEntity { Id = id, Name = "Perlunas", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.SiteSetting.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            var result = await service.DeleteAsync(id);

            result.Should().Be("Site setting deleted successfully.");
        }

        await using (var ctx = new AppDbContext(options))
        {
            var entity = await ctx.SiteSettings.IgnoreQueryFilters().FirstAsync(x => x.Id == id);
            entity.IsDeleted.Should().BeTrue();
        }
    }

    [Fact]
    public async Task DeleteAsync_WhenNotFound_ShouldThrowNotFound()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.SiteSetting.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);

        var act = () => service.DeleteAsync(Guid.NewGuid());

        await act.Should().ThrowAsync<NotFoundException>().WithMessage("Site setting not found.");
    }

    // ==================================================================
    //  GetAllAsync — filter id
    // ==================================================================

    [Fact]
    public async Task GetAllAsync_WithIdFilter_ShouldReturnSingleMatching()
    {
        var options = NewDb();
        var targetId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.SiteSettings.Add(new SiteSettingEntity { Id = targetId, Name = "Target", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.SiteSettings.Add(new SiteSettingEntity { Id = Guid.NewGuid(), Name = "Other", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.SiteSetting.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            var result = await service.GetAllAsync(targetId, null, null);

            var items = result.Value.Should().BeAssignableTo<List<Response.SiteSettingResponse>>().Subject;
            items.Should().ContainSingle(x => x.Name == "Target");
        }
    }

}
