using Cms.Repository;
using Cms.Service.Exceptions;
using Cms.Service.PageContent;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Moq;
using PageContentEntity = Cms.Repository.Entities.PageContent;

namespace Cms.Service.Tests.PageContent;

public class ServiceTests
{
    private static DbContextOptions<AppDbContext> NewDb() =>
        new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

    private static Mock<IValidator<Request.CreatePageContentRequest>> CreateValidatorMock(bool valid = true)
    {
        var mock = new Mock<IValidator<Request.CreatePageContentRequest>>();
        mock.Setup(x => x.ValidateAsync(
                It.IsAny<Request.CreatePageContentRequest>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult(valid ? [] : new List<ValidationFailure> { new("Key", "KEY_REQUIRED") }));
        return mock;
    }

    private static Mock<IValidator<Request.UpdatePageContentRequest>> UpdateValidatorMock(bool valid = true)
    {
        var mock = new Mock<IValidator<Request.UpdatePageContentRequest>>();
        mock.Setup(x => x.ValidateAsync(
                It.IsAny<Request.UpdatePageContentRequest>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult(valid ? [] : new List<ValidationFailure> { new("Key", "KEY_REQUIRED") }));
        return mock;
    }

    private static Request.CreatePageContentRequest ValidCreateRequest => new()
    {
        PageKey = "home",
        SectionKey = "hero",
        Key = "title",
        ContentValue = "Welcome",
        Label = "Title",
        Kind = "text",
        SoftOrder = 1
    };

    private static Request.UpdatePageContentRequest ValidUpdateRequest => new()
    {
        PageKey = "about",
        SectionKey = "intro",
        Key = "description",
        ContentValue = "About us",
        Label = "Description",
        Kind = "richtext",
        SoftOrder = 2
    };

    // ===== CreateAsync =====

    [Fact]
    public async Task CreateAsync_WithValidRequest_ShouldCreatePageContent()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);

        var result = await service.CreateAsync(ValidCreateRequest);

        result.Should().NotBeNull();
        result.PageKey.Should().Be("home");
        result.SectionKey.Should().Be("hero");
        result.Key.Should().Be("title");
        result.ContentValue.Should().Be("Welcome");
        result.Label.Should().Be("Title");
        result.Kind.Should().Be("text");
        result.SoftOrder.Should().Be(1);
        result.CreatedAt.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(5));
    }

    [Fact]
    public async Task CreateAsync_WithParentId_WhenParentExists_ShouldCreateWithParent()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var parentId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.PageContents.Add(new PageContentEntity
            {
                Id = parentId,
                PageKey = "home",
                SectionKey = "hero",
                Key = "parent",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        var createRequest = new Request.CreatePageContentRequest
        {
            PageKey = "home",
            SectionKey = "hero",
            Key = "title",
            ContentValue = "Welcome",
            Label = "Title",
            Kind = "text",
            SoftOrder = 1,
            ParentId = parentId
        };

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.CreateAsync(createRequest);

            result.ParentId.Should().Be(parentId);
        }
    }

    [Fact]
    public async Task CreateAsync_WithParentId_WhenParentNotFound_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var createRequest = new Request.CreatePageContentRequest
        {
            PageKey = "home",
            SectionKey = "hero",
            Key = "title",
            ContentValue = "Welcome",
            Label = "Title",
            Kind = "text",
            SoftOrder = 1,
            ParentId = Guid.NewGuid()
        };

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);

        var act = () => service.CreateAsync(createRequest);

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Parent page content not found.");
    }

    // ===== UpdateAsync =====

    [Fact]
    public async Task UpdateAsync_WithValidRequest_ShouldUpdatePageContent()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var contentId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.PageContents.Add(new PageContentEntity
            {
                Id = contentId,
                PageKey = "home",
                SectionKey = "hero",
                Key = "title",
                ContentValue = "Old",
                Label = "Old Label",
                Kind = "text",
                SoftOrder = 0,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.UpdateAsync(contentId, ValidUpdateRequest);

            result.PageKey.Should().Be("about");
            result.SectionKey.Should().Be("intro");
            result.Key.Should().Be("description");
            result.ContentValue.Should().Be("About us");
            result.Label.Should().Be("Description");
            result.Kind.Should().Be("richtext");
            result.SoftOrder.Should().Be(2);
            result.UpdatedAt.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(5));
        }
    }

    [Fact]
    public async Task UpdateAsync_WhenPageContentDoesNotExist_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);

        var act = () => service.UpdateAsync(Guid.NewGuid(), ValidUpdateRequest);

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Page content not found.");
    }

    [Fact]
    public async Task UpdateAsync_WithNewParentId_WhenParentNotFound_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var contentId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.PageContents.Add(new PageContentEntity
            {
                Id = contentId,
                PageKey = "home",
                SectionKey = "hero",
                Key = "title",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        var updateRequest = new Request.UpdatePageContentRequest
        {
            PageKey = "about",
            SectionKey = "intro",
            Key = "description",
            ContentValue = "About us",
            Label = "Description",
            Kind = "richtext",
            SoftOrder = 2,
            ParentId = Guid.NewGuid()
        };

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);
            var act = () => service.UpdateAsync(contentId, updateRequest);

            await act.Should().ThrowAsync<NotFoundException>()
                .WithMessage("Parent page content not found.");
        }
    }

    // ===== DeleteAsync =====

    [Fact]
    public async Task DeleteAsync_WhenPageContentExists_ShouldSoftDelete()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var contentId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.PageContents.Add(new PageContentEntity
            {
                Id = contentId,
                PageKey = "home",
                SectionKey = "hero",
                Key = "to-delete",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);
            var msg = await service.DeleteAsync(contentId);

            msg.Should().Be("Page content deleted successfully.");
        }

        await using (var ctx = new AppDbContext(options))
        {
            var item = await ctx.PageContents.IgnoreQueryFilters().FirstOrDefaultAsync(x => x.Id == contentId);
            item!.IsDeleted.Should().BeTrue();
        }
    }

    [Fact]
    public async Task DeleteAsync_ShouldCascadeToChildren()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var parentId = Guid.NewGuid();
        var childId = Guid.NewGuid();
        var grandchildId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.PageContents.AddRange(
                new PageContentEntity { Id = parentId, PageKey = "home", Key = "parent", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new PageContentEntity { Id = childId, PageKey = "home", Key = "child", ParentId = parentId, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new PageContentEntity { Id = grandchildId, PageKey = "home", Key = "grandchild", ParentId = childId, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);
            await service.DeleteAsync(parentId);
        }

        await using (var ctx = new AppDbContext(options))
        {
            var items = await ctx.PageContents.IgnoreQueryFilters().ToListAsync();
            items.Where(x => x.Id == parentId).Single().IsDeleted.Should().BeTrue();
            items.Where(x => x.Id == childId).Single().IsDeleted.Should().BeTrue();
            items.Where(x => x.Id == grandchildId).Single().IsDeleted.Should().BeTrue();
        }
    }

    [Fact]
    public async Task DeleteAsync_WhenPageContentDoesNotExist_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);

        var act = () => service.DeleteAsync(Guid.NewGuid());

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Page content not found.");
    }

    // ===== GetByIdAsync =====

    [Fact]
    public async Task GetByIdAsync_WhenPageContentExists_ShouldReturnPageContent()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var contentId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.PageContents.Add(new PageContentEntity
            {
                Id = contentId,
                PageKey = "home",
                SectionKey = "hero",
                Key = "title",
                ContentValue = "Welcome",
                Label = "Title",
                Kind = "text",
                SoftOrder = 1,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetByIdAsync(contentId);

            result.PageKey.Should().Be("home");
            result.Key.Should().Be("title");
            result.Children.Should().BeEmpty();
        }
    }

    [Fact]
    public async Task GetByIdAsync_WithChildren_ShouldBuildTree()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var parentId = Guid.NewGuid();
        var childId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.PageContents.AddRange(
                new PageContentEntity { Id = parentId, PageKey = "home", Key = "parent", SoftOrder = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new PageContentEntity { Id = childId, PageKey = "home", Key = "child", ParentId = parentId, SoftOrder = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetByIdAsync(parentId);

            result.Children.Should().ContainSingle();
            result.Children[0].Key.Should().Be("child");
        }
    }

    [Fact]
    public async Task GetByIdAsync_WhenPageContentDoesNotExist_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);

        var act = () => service.GetByIdAsync(Guid.NewGuid());

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Page content not found.");
    }

    [Fact]
    public async Task GetByIdAsync_WhenPageContentIsDeleted_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var contentId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.PageContents.Add(new PageContentEntity
            {
                Id = contentId,
                PageKey = "home",
                Key = "deleted",
                IsDeleted = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);
            var act = () => service.GetByIdAsync(contentId);

            await act.Should().ThrowAsync<NotFoundException>()
                .WithMessage("Page content not found.");
        }
    }

    // ===== GetAllAsync =====

    [Fact]
    public async Task GetAllAsync_WithNoFilters_ShouldReturnAllOrdered()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.PageContents.AddRange(
                new PageContentEntity { Id = Guid.NewGuid(), PageKey = "home", SectionKey = "b", Key = "k1", SoftOrder = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new PageContentEntity { Id = Guid.NewGuid(), PageKey = "about", SectionKey = "a", Key = "k2", SoftOrder = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetAllAsync(null, null);

            var items = result.Value.Should().BeAssignableTo<List<Response.PageContentResponse>>().Subject;
            items.Should().HaveCount(2);
            items[0].PageKey.Should().Be("about"); // OrderBy PageKey
            items[1].PageKey.Should().Be("home");
        }
    }

    [Fact]
    public async Task GetAllAsync_ByPageKey_ShouldReturnMatching()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.PageContents.AddRange(
                new PageContentEntity { Id = Guid.NewGuid(), PageKey = "home", SectionKey = "hero", Key = "title", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new PageContentEntity { Id = Guid.NewGuid(), PageKey = "about", SectionKey = "intro", Key = "desc", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetAllAsync("home", null);

            var items = result.Value.Should().BeAssignableTo<List<Response.PageContentResponse>>().Subject;
            items.Should().ContainSingle(x => x.Key == "title");
        }
    }

    [Fact]
    public async Task GetAllAsync_BySectionKey_ShouldReturnMatching()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.PageContents.AddRange(
                new PageContentEntity { Id = Guid.NewGuid(), PageKey = "home", SectionKey = "hero", Key = "title", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new PageContentEntity { Id = Guid.NewGuid(), PageKey = "home", SectionKey = "footer", Key = "copyright", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetAllAsync(null, "hero");

            var items = result.Value.Should().BeAssignableTo<List<Response.PageContentResponse>>().Subject;
            items.Should().ContainSingle(x => x.Key == "title");
        }
    }

    [Fact]
    public async Task GetAllAsync_CombinedFilters_ShouldIntersect()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.PageContents.AddRange(
                new PageContentEntity { Id = Guid.NewGuid(), PageKey = "home", SectionKey = "hero", Key = "title", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new PageContentEntity { Id = Guid.NewGuid(), PageKey = "home", SectionKey = "footer", Key = "copyright", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetAllAsync("home", "hero");

            var items = result.Value.Should().BeAssignableTo<List<Response.PageContentResponse>>().Subject;
            items.Should().ContainSingle(x => x.Key == "title");
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
            ctx.PageContents.AddRange(
                new PageContentEntity { Id = Guid.NewGuid(), PageKey = "home", Key = "visible", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new PageContentEntity { Id = Guid.NewGuid(), PageKey = "home", Key = "deleted", IsDeleted = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetAllAsync(null, null);

            var items = result.Value.Should().BeAssignableTo<List<Response.PageContentResponse>>().Subject;
            items.Should().ContainSingle(x => x.Key == "visible");
        }
    }

    [Fact]
    public async Task GetAllAsync_WithNoData_ShouldReturnEmpty()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.PageContent.Service(ctx, createValidator.Object, updateValidator.Object);

        var result = await service.GetAllAsync(null, null);

        var items = result.Value.Should().BeAssignableTo<List<Response.PageContentResponse>>().Subject;
        items.Should().BeEmpty();
    }

    // ==================================================================
    //  GetByIdAsync
    // ==================================================================

    [Fact]
    public async Task GetByIdAsync_WhenExists_ShouldReturnWithChildrenTree()
    {
        var options = NewDb();
        var parent = Guid.NewGuid();
        var child = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.PageContents.Add(new PageContentEntity { Id = parent, PageKey = "home", SectionKey = "hero", Key = "banner", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.PageContents.Add(new PageContentEntity { Id = child, ParentId = parent, PageKey = "home", SectionKey = "hero", Key = "title", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.PageContent.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            var result = await service.GetByIdAsync(parent);

            result.Key.Should().Be("banner");
            result.Children.Should().ContainSingle(c => c.Key == "title");
        }
    }

    [Fact]
    public async Task GetByIdAsync_WhenNotFound_ShouldThrowNotFound()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.PageContent.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);

        var act = () => service.GetByIdAsync(Guid.NewGuid());

        await act.Should().ThrowAsync<NotFoundException>().WithMessage("Page content not found.");
    }

    [Fact]
    public async Task GetByIdAsync_WhenDeleted_ShouldThrowNotFound()
    {
        var options = NewDb();
        var id = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.PageContents.Add(new PageContentEntity { Id = id, PageKey = "home", Key = "deleted", IsDeleted = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.PageContent.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            var act = () => service.GetByIdAsync(id);

            await act.Should().ThrowAsync<NotFoundException>().WithMessage("Page content not found.");
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
            ctx.PageContents.Add(new PageContentEntity { Id = id, PageKey = "home", Key = "title", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.PageContent.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            var result = await service.DeleteAsync(id);

            result.Should().Be("Page content deleted successfully.");
        }

        await using (var ctx = new AppDbContext(options))
        {
            var entity = await ctx.PageContents.IgnoreQueryFilters().FirstAsync(x => x.Id == id);
            entity.IsDeleted.Should().BeTrue();
        }
    }

    [Fact]
    public async Task DeleteAsync_ShouldCascadeSoftDeleteDescendants()
    {
        var options = NewDb();
        var parent = Guid.NewGuid();
        var child = Guid.NewGuid();
        var grandchild = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.PageContents.Add(new PageContentEntity { Id = parent, PageKey = "home", Key = "banner", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.PageContents.Add(new PageContentEntity { Id = child, ParentId = parent, PageKey = "home", Key = "title", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.PageContents.Add(new PageContentEntity { Id = grandchild, ParentId = child, PageKey = "home", Key = "subtitle", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.PageContent.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            await service.DeleteAsync(parent);
        }

        await using (var ctx = new AppDbContext(options))
        {
            (await ctx.PageContents.IgnoreQueryFilters().FirstAsync(x => x.Id == child)).IsDeleted.Should().BeTrue();
            (await ctx.PageContents.IgnoreQueryFilters().FirstAsync(x => x.Id == grandchild)).IsDeleted.Should().BeTrue();
        }
    }

    [Fact]
    public async Task DeleteAsync_WhenNotFound_ShouldThrowNotFound()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.PageContent.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);

        var act = () => service.DeleteAsync(Guid.NewGuid());

        await act.Should().ThrowAsync<NotFoundException>().WithMessage("Page content not found.");
    }

}
