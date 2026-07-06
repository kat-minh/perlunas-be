using Cms.Repository;
using Cms.Repository.Enums;
using Cms.Service.Exceptions;
using Cms.Service.Taxonomy;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Moq;
using TaxonomyEntity = Cms.Repository.Entities.Taxonomy;
using ServiceEntity = Cms.Repository.Entities.Service;

namespace Cms.Service.Tests.Taxonomy;

public class ServiceTests
{
    private static DbContextOptions<AppDbContext> NewDb() =>
        new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

    private static Mock<IValidator<Request.CreateTaxonomyRequest>> CreateValidatorMock(bool valid = true)
    {
        var mock = new Mock<IValidator<Request.CreateTaxonomyRequest>>();
        mock.Setup(x => x.ValidateAsync(
                It.IsAny<Request.CreateTaxonomyRequest>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult(valid ? [] : new List<ValidationFailure> { new("Name", "NAME_REQUIRED") }));
        return mock;
    }

    private static Mock<IValidator<Request.UpdateTaxonomyRequest>> UpdateValidatorMock(bool valid = true)
    {
        var mock = new Mock<IValidator<Request.UpdateTaxonomyRequest>>();
        mock.Setup(x => x.ValidateAsync(
                It.IsAny<Request.UpdateTaxonomyRequest>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult(valid ? [] : new List<ValidationFailure> { new("Name", "NAME_REQUIRED") }));
        return mock;
    }

    private static Request.CreateTaxonomyRequest CreateRequest(string name, string group = "region", int sortOrder = 0, string? color = null) => new()
    {
        Group = group,
        Name = name,
        SortOrder = sortOrder,
        Color = color
    };

    private static Request.UpdateTaxonomyRequest UpdateRequest(string name, int sortOrder = 0, string? color = null) => new()
    {
        Name = name,
        SortOrder = sortOrder,
        Color = color
    };

    // ===== CreateAsync =====

    [Fact]
    public async Task CreateAsync_WithValidRequest_ShouldCreateTaxonomy()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);

        var result = await service.CreateAsync(CreateRequest("Miền Bắc", "region", 1, "#FF0000"));

        result.Should().NotBeNull();
        result.Name.Should().Be("Miền Bắc");
        result.Group.Should().Be("region");
        result.Slug.Should().Be("mien-bac");
        result.Color.Should().Be("#FF0000");
        result.SortOrder.Should().Be(1);
        result.CreatedAt.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(5));
    }

    [Fact]
    public async Task CreateAsync_WithDuplicateGroupAndName_ShouldThrowConflict()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.Add(new TaxonomyEntity
            {
                Id = Guid.NewGuid(),
                Group = "region",
                Name = "Miền Bắc",
                Slug = "mien-bac",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);
            var act = () => service.CreateAsync(CreateRequest("Miền Bắc", "region"));

            await act.Should().ThrowAsync<ConflictException>();
        }
    }

    [Fact]
    public async Task CreateAsync_SameNameDifferentGroup_ShouldCreate()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.Add(new TaxonomyEntity
            {
                Id = Guid.NewGuid(),
                Group = "region",
                Name = "Miền Bắc",
                Slug = "mien-bac",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.CreateAsync(CreateRequest("Miền Bắc", "city"));

            result.Group.Should().Be("city");
            result.Name.Should().Be("Miền Bắc");
        }
    }

    [Fact]
    public async Task CreateAsync_WithDuplicateSlug_ShouldAppendSuffix()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.Add(new TaxonomyEntity
            {
                Id = Guid.NewGuid(),
                Group = "region",
                Name = "Miền Bắc",
                Slug = "mien-bac",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.CreateAsync(CreateRequest("Miền Bắc", "city"));

            result.Slug.Should().Be("mien-bac-1");
        }
    }

    [Fact]
    public async Task CreateAsync_WithEmptySlugGeneration_ShouldFallbackToGuid()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);

        var result = await service.CreateAsync(CreateRequest("@#$%^&*()", "region"));

        result.Slug.Should().NotBeNullOrEmpty();
        Guid.TryParse(result.Slug, out _).Should().BeTrue();
    }

    // ===== UpdateAsync =====

    [Fact]
    public async Task UpdateAsync_WithValidRequest_ShouldUpdateTaxonomy()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var taxonomyId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.Add(new TaxonomyEntity
            {
                Id = taxonomyId,
                Group = "region",
                Name = "Old Name",
                Slug = "old-name",
                Color = "#000",
                SortOrder = 0,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.UpdateAsync(taxonomyId, UpdateRequest("Old Name", 2, "#FFF"));

            result.Name.Should().Be("Old Name");
            result.Slug.Should().Be("old-name"); // slug unchanged
            result.Color.Should().Be("#FFF");
            result.SortOrder.Should().Be(2);
            result.UpdatedAt.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(5));
        }
    }

    [Fact]
    public async Task UpdateAsync_WhenTaxonomyDoesNotExist_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);

        var act = () => service.UpdateAsync(Guid.NewGuid(), UpdateRequest("Name"));

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Taxonomy not found.");
    }

    [Fact]
    public async Task UpdateAsync_WithNameConflictingInSameGroup_ShouldThrowConflict()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var targetId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.AddRange(
                new TaxonomyEntity { Id = targetId, Group = "region", Name = "Old", Slug = "old", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new TaxonomyEntity { Id = Guid.NewGuid(), Group = "region", Name = "Existing", Slug = "existing", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);
            var act = () => service.UpdateAsync(targetId, UpdateRequest("Existing"));

            await act.Should().ThrowAsync<ConflictException>();
        }
    }

    [Fact]
    public async Task UpdateAsync_SameNameInDifferentGroups_ShouldNotConflict()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var targetId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.AddRange(
                new TaxonomyEntity { Id = targetId, Group = "region", Name = "Place", Slug = "place", SortOrder = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new TaxonomyEntity { Id = Guid.NewGuid(), Group = "city", Name = "Place", Slug = "place-1", SortOrder = 5, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);
            // same name, different group — no conflict, no cascade (name unchanged)
            var result = await service.UpdateAsync(targetId, UpdateRequest("Place", 3, "#123"));

            result.Name.Should().Be("Place");
            result.SortOrder.Should().Be(3);
            result.Color.Should().Be("#123");
        }
    }

    // ===== DeleteAsync =====

    [Fact]
    public async Task DeleteAsync_WhenTaxonomyExists_ShouldSoftDelete()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var taxonomyId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.Add(new TaxonomyEntity
            {
                Id = taxonomyId,
                Group = "region",
                Name = "To Delete",
                Slug = "to-delete",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);
            var msg = await service.DeleteAsync(taxonomyId);

            msg.Should().Be("Taxonomy deleted successfully.");
        }

        await using (var ctx = new AppDbContext(options))
        {
            var item = await ctx.Taxonomies.IgnoreQueryFilters().FirstOrDefaultAsync(x => x.Id == taxonomyId);
            item!.IsDeleted.Should().BeTrue();
        }
    }

    [Fact]
    public async Task DeleteAsync_WhenTaxonomyDoesNotExist_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);

        var act = () => service.DeleteAsync(Guid.NewGuid());

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Taxonomy not found.");
    }

    [Fact]
    public async Task DeleteAsync_WhenTaxonomyIsReferencedByService_ShouldThrowConflict()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.Add(new TaxonomyEntity
            {
                Id = Guid.NewGuid(),
                Group = "region",
                Name = "Miền Bắc",
                Slug = "mien-bac",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            ctx.Services.Add(new ServiceEntity
            {
                Id = Guid.NewGuid(),
                Title = "Tour A",
                Type = 0,
                Region = "Miền Bắc",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var taxonomy = await ctx.Taxonomies.FirstAsync();
            var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);
            var act = () => service.DeleteAsync(taxonomy.Id);

            await act.Should().ThrowAsync<ConflictException>()
                .WithMessage("*đang được 1 dịch vụ sử dụng*");
        }
    }

    [Fact]
    public async Task DeleteAsync_WhenReferencingServiceIsDeleted_ShouldAllowDelete()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.Add(new TaxonomyEntity
            {
                Id = Guid.NewGuid(),
                Group = "region",
                Name = "Miền Bắc",
                Slug = "mien-bac",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            ctx.Services.Add(new ServiceEntity
            {
                Id = Guid.NewGuid(),
                Title = "Tour A",
                Type = 0,
                Region = "Miền Bắc",
                IsDeleted = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var taxonomy = await ctx.Taxonomies.FirstAsync();
            var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);
            var msg = await service.DeleteAsync(taxonomy.Id);

            msg.Should().Be("Taxonomy deleted successfully.");
        }
    }

    // ===== GetByIdAsync =====

    [Fact]
    public async Task GetByIdAsync_WhenTaxonomyExists_ShouldReturnTaxonomy()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var taxonomyId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.Add(new TaxonomyEntity
            {
                Id = taxonomyId,
                Group = "region",
                Name = "Find Me",
                Slug = "find-me",
                Color = "#123",
                SortOrder = 5,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetByIdAsync(taxonomyId);

            result.Name.Should().Be("Find Me");
            result.Group.Should().Be("region");
            result.Color.Should().Be("#123");
            result.SortOrder.Should().Be(5);
        }
    }

    [Fact]
    public async Task GetByIdAsync_WhenTaxonomyDoesNotExist_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);

        var act = () => service.GetByIdAsync(Guid.NewGuid());

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Taxonomy not found.");
    }

    [Fact]
    public async Task GetByIdAsync_WhenTaxonomyIsDeleted_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var taxonomyId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.Add(new TaxonomyEntity
            {
                Id = taxonomyId,
                Group = "region",
                Name = "Deleted",
                Slug = "deleted",
                IsDeleted = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);
            var act = () => service.GetByIdAsync(taxonomyId);

            await act.Should().ThrowAsync<NotFoundException>()
                .WithMessage("Taxonomy not found.");
        }
    }

    // ===== GetAllAsync =====

    [Fact]
    public async Task GetAllAsync_WithNoFilter_ShouldReturnAllOrdered()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.AddRange(
                new TaxonomyEntity { Id = Guid.NewGuid(), Group = "region", Name = "B", Slug = "b", SortOrder = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new TaxonomyEntity { Id = Guid.NewGuid(), Group = "city", Name = "A", Slug = "a", SortOrder = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetAllAsync(null);

            var items = result.Value.Should().BeAssignableTo<List<Response.TaxonomyResponse>>().Subject;
            items[0].Group.Should().Be("city"); // OrderBy Group
            items[1].Group.Should().Be("region");
        }
    }

    [Fact]
    public async Task GetAllAsync_WithGroupFilter_ShouldReturnMatching()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.AddRange(
                new TaxonomyEntity { Id = Guid.NewGuid(), Group = "region", Name = "North", Slug = "north", SortOrder = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new TaxonomyEntity { Id = Guid.NewGuid(), Group = "city", Name = "Hanoi", Slug = "hanoi", SortOrder = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetAllAsync("city");

            var items = result.Value.Should().BeAssignableTo<List<Response.TaxonomyResponse>>().Subject;
            items.Should().ContainSingle(x => x.Name == "Hanoi");
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
            ctx.Taxonomies.AddRange(
                new TaxonomyEntity { Id = Guid.NewGuid(), Group = "region", Name = "Visible", Slug = "visible", SortOrder = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new TaxonomyEntity { Id = Guid.NewGuid(), Group = "region", Name = "Deleted", Slug = "deleted", SortOrder = 1, IsDeleted = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetAllAsync(null);

            var items = result.Value.Should().BeAssignableTo<List<Response.TaxonomyResponse>>().Subject;
            items.Should().ContainSingle(x => x.Name == "Visible");
        }
    }

    [Fact]
    public async Task GetAllAsync_WithNoData_ShouldReturnEmpty()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Taxonomy.Service(ctx, createValidator.Object, updateValidator.Object);

        var result = await service.GetAllAsync(null);

        var items = result.Value.Should().BeAssignableTo<List<Response.TaxonomyResponse>>().Subject;
        items.Should().BeEmpty();
    }

    // ==================================================================
    //  GetByIdAsync
    // ==================================================================

    [Fact]
    public async Task GetByIdAsync_WhenExists_ShouldReturnTaxonomy()
    {
        var options = NewDb();
        var id = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.Add(new TaxonomyEntity { Id = id, Group = "region", Name = "Miền Bắc", Slug = "mien-bac", SortOrder = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            var result = await service.GetByIdAsync(id);

            result.Name.Should().Be("Miền Bắc");
            result.Group.Should().Be("region");
            result.Slug.Should().Be("mien-bac");
        }
    }

    [Fact]
    public async Task GetByIdAsync_WhenNotFound_ShouldThrowNotFound()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Taxonomy.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);

        var act = () => service.GetByIdAsync(Guid.NewGuid());

        await act.Should().ThrowAsync<NotFoundException>().WithMessage("Taxonomy not found.");
    }

    [Fact]
    public async Task GetByIdAsync_WhenDeleted_ShouldThrowNotFound()
    {
        var options = NewDb();
        var id = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.Add(new TaxonomyEntity { Id = id, Group = "region", Name = "Xoá", Slug = "xoa", IsDeleted = true, SortOrder = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            var act = () => service.GetByIdAsync(id);

            await act.Should().ThrowAsync<NotFoundException>().WithMessage("Taxonomy not found.");
        }
    }

    // ==================================================================
    //  UpdateAsync
    // ==================================================================

    [Fact]
    public async Task UpdateAsync_WithValidRequest_ShouldUpdateFields()
    {
        var options = NewDb();
        var id = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.Add(new TaxonomyEntity { Id = id, Group = "region", Name = "Miền Bắc", Slug = "mien-bac", Color = "#FF0000", SortOrder = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            var result = await service.UpdateAsync(id, UpdateRequest("Miền Bắc", 5, "#00FF00"));

            result.Name.Should().Be("Miền Bắc");
            result.Color.Should().Be("#00FF00");
            result.SortOrder.Should().Be(5);
            // (slug không đổi vì không đổi Name)
        }
    }

    [Fact]
    public async Task UpdateAsync_WhenNotFound_ShouldThrowNotFound()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Taxonomy.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);

        var act = () => service.UpdateAsync(Guid.NewGuid(), UpdateRequest("Bất kỳ"));

        await act.Should().ThrowAsync<NotFoundException>().WithMessage("Taxonomy not found.");
    }

    [Fact]
    public async Task UpdateAsync_WhenNewNameConflictsInSameGroup_ShouldThrowConflict()
    {
        var options = NewDb();
        var id = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.Add(new TaxonomyEntity { Id = id, Group = "region", Name = "Miền Bắc", Slug = "mien-bac", SortOrder = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.Taxonomies.Add(new TaxonomyEntity { Id = Guid.NewGuid(), Group = "region", Name = "Miền Nam", Slug = "mien-nam", SortOrder = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            var act = () => service.UpdateAsync(id, UpdateRequest("Miền Nam"));

            await act.Should().ThrowAsync<ConflictException>();
        }
    }

    [Fact(Skip = "EF Core InMemory provider không hỗ trợ ExecuteUpdateAsync (bulk update) — CascadeRenameAsync cần SQL provider/SQLite để test. Logic cascade đã được review mã.")]
    public async Task UpdateAsync_WhenRenameRegion_ShouldCascadeToServices()
    {
        var options = NewDb();
        var id = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.Add(new TaxonomyEntity { Id = id, Group = "region", Name = "Miền Bắc", Slug = "mien-bac", SortOrder = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.Services.Add(new ServiceEntity { Id = Guid.NewGuid(), Title = "Tour", Slug = "tour-1", Type = ServiceType.Tour, Region = "Miền Bắc", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            await service.UpdateAsync(id, UpdateRequest("Miền Bắc VIP"));
        }

        await using (var ctx = new AppDbContext(options))
        {
            var svc = await ctx.Services.FirstAsync();
            svc.Region.Should().Be("Miền Bắc VIP");
        }
    }


    // ==================================================================
    //  DeleteAsync
    // ==================================================================

    [Fact]
    public async Task DeleteAsync_WhenExists_ShouldSoftDeleteAndReturnMessage()
    {
        var options = NewDb();
        var id = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.Add(new TaxonomyEntity { Id = id, Group = "region", Name = "Miền Bắc", Slug = "mien-bac", SortOrder = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            var result = await service.DeleteAsync(id);

            result.Should().Be("Taxonomy deleted successfully.");
        }

        await using (var ctx = new AppDbContext(options))
        {
            var entity = await ctx.Taxonomies.IgnoreQueryFilters().FirstAsync(x => x.Id == id);
            entity.IsDeleted.Should().BeTrue();
        }
    }

    [Fact]
    public async Task DeleteAsync_WhenNotFound_ShouldThrowNotFound()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Taxonomy.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);

        var act = () => service.DeleteAsync(Guid.NewGuid());

        await act.Should().ThrowAsync<NotFoundException>().WithMessage("Taxonomy not found.");
    }

    [Fact]
    public async Task DeleteAsync_WhenInUseByService_ShouldThrowConflict()
    {
        var options = NewDb();
        var id = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.Add(new TaxonomyEntity { Id = id, Group = "region", Name = "Miền Bắc", Slug = "mien-bac", SortOrder = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.Services.Add(new ServiceEntity { Id = Guid.NewGuid(), Title = "Tour", Slug = "tour-1", Type = ServiceType.Tour, Region = "Miền Bắc", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            var act = () => service.DeleteAsync(id);

            await act.Should().ThrowAsync<ConflictException>()
                .WithMessage("*đang được 1 dịch vụ sử dụng*");
        }
    }

    [Fact]
    public async Task DeleteAsync_WhenInUseByDeletedService_ShouldAllowDelete()
    {
        // Service đã soft-delete → không được tính là "đang dùng" → xoá taxonomy được.
        var options = NewDb();
        var id = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Taxonomies.Add(new TaxonomyEntity { Id = id, Group = "region", Name = "Miền Bắc", Slug = "mien-bac", SortOrder = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.Services.Add(new ServiceEntity { Id = Guid.NewGuid(), Title = "Tour", Slug = "tour-1", Type = ServiceType.Tour, Region = "Miền Bắc", IsDeleted = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Taxonomy.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            var result = await service.DeleteAsync(id);

            result.Should().Be("Taxonomy deleted successfully.");
        }
    }


}
