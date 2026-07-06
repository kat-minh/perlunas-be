using Cms.Repository;
using BlogEntity = Cms.Repository.Entities.Blog;
using Cms.Service.Blog;
using Cms.Service.Exceptions;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace Cms.Service.Tests.Blog;

public class ServiceTests
{
    private static DbContextOptions<AppDbContext> NewDb() =>
        new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

    private static Mock<IValidator<Request.CreateBlogRequest>> CreateValidatorMock(bool valid = true)
    {
        var mock = new Mock<IValidator<Request.CreateBlogRequest>>();
        mock.Setup(x => x.ValidateAsync(
                It.IsAny<ValidationContext<Request.CreateBlogRequest>>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult(valid ? new List<ValidationFailure>() : new List<ValidationFailure> { new("Titile", "TITLE_REQUIRED") }));
        return mock;
    }

    private static Mock<IValidator<Request.UpdateBlogRequest>> UpdateValidatorMock(bool valid = true)
    {
        var mock = new Mock<IValidator<Request.UpdateBlogRequest>>();
        mock.Setup(x => x.ValidateAsync(
                It.IsAny<ValidationContext<Request.UpdateBlogRequest>>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult(valid ? new List<ValidationFailure>() : new List<ValidationFailure> { new("Titile", "TITLE_REQUIRED") }));
        return mock;
    }

    private static Request.CreateBlogRequest ValidCreateRequest => new()
    {
        Titile = "Test Blog Title",
        SubTitile = "Test Subtitle",
        Author = "Test Author",
        ReadingTime = "5 phút",
        Description = "Test Description",
        Tag = "test",
        Cover = "https://example.com/cover.jpg",
        Content = "<p>Test content</p>"
    };

    private static Request.UpdateBlogRequest ValidUpdateRequest => new()
    {
        Titile = "Updated Title",
        SubTitile = "Updated Subtitle",
        Author = "Updated Author",
        ReadingTime = "10 phút",
        Description = "Updated Description",
        Tag = "updated",
        Cover = "https://example.com/cover2.jpg",
        Content = "<p>Updated content</p>"
    };

    // ===== CreateAsync =====

    [Fact]
    public async Task CreateAsync_WithValidRequest_ShouldCreateBlog()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Blog.Service(ctx, createValidator.Object, updateValidator.Object);

        var result = await service.CreateAsync(ValidCreateRequest);

        result.Should().NotBeNull();
        result.Titile.Should().Be("Test Blog Title");
        result.Slug.Should().Be("test-blog-title");
        result.Author.Should().Be("Test Author");
        result.CreatedAt.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(5));
    }

    [Fact]
    public async Task CreateAsync_WithDuplicateTitle_ShouldAppendSuffix()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.Blogs.Add(new BlogEntity
            {
                Id = Guid.NewGuid(),
                Titile = "Test Blog Title",
                Slug = "test-blog-title",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Blog.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.CreateAsync(ValidCreateRequest);

            result.Slug.Should().Be("test-blog-title-1");
        }
    }

    [Fact]
    public async Task CreateAsync_WithTitleGeneratingEmptySlug_ShouldFallbackToGuid()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();
        var request = new Request.CreateBlogRequest
        {
            Titile = "@#$%^&*()",
            SubTitile = "Test Subtitle",
            Author = "Test Author",
            ReadingTime = "5 phút",
            Description = "Test Description",
            Tag = "test",
            Cover = "https://example.com/cover.jpg",
            Content = "<p>Test content</p>"
        };

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Blog.Service(ctx, createValidator.Object, updateValidator.Object);

        var result = await service.CreateAsync(request);

        result.Slug.Should().NotBeNullOrEmpty();
        Guid.TryParse(result.Slug, out var guidResult).Should().BeTrue();
    }

    // ===== UpdateAsync =====

    [Fact]
    public async Task UpdateAsync_WithValidRequest_ShouldUpdateBlog()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var blogId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Blogs.Add(new BlogEntity
            {
                Id = blogId,
                Titile = "Original Title",
                Slug = "original-title",
                Author = "Original Author",
                SubTitile = "Original Sub",
                ReadingTime = "5 phút",
                Description = "Original desc",
                Tag = "original",
                Cover = "https://example.com/cover.jpg",
                Content = "<p>Original</p>",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Blog.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.UpdateAsync(blogId, ValidUpdateRequest);

            result.Titile.Should().Be("Updated Title");
            result.Slug.Should().Be("updated-title");
            result.UpdatedAt.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(5));
        }
    }

    [Fact]
    public async Task UpdateAsync_WhenBlogDoesNotExist_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Blog.Service(ctx, createValidator.Object, updateValidator.Object);

        var act = () => service.UpdateAsync(Guid.NewGuid(), ValidUpdateRequest);

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Blog not found.");
    }

    [Fact]
    public async Task UpdateAsync_WithTitleExistingElsewhere_ShouldAppendSuffix()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var blogId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Blogs.Add(new BlogEntity { Id = blogId, Titile = "Old Title", Slug = "old-title", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.Blogs.Add(new BlogEntity { Id = Guid.NewGuid(), Titile = "Updated Title", Slug = "updated-title", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Blog.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.UpdateAsync(blogId, ValidUpdateRequest);

            result.Slug.Should().Be("updated-title-1");
        }
    }

    // ===== DeleteAsync =====

    [Fact]
    public async Task DeleteAsync_WhenBlogExists_ShouldSoftDelete()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var blogId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Blogs.Add(new BlogEntity { Id = blogId, Titile = "To Delete", Slug = "to-delete", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Blog.Service(ctx, createValidator.Object, updateValidator.Object);
            var msg = await service.DeleteAsync(blogId);

            msg.Should().Be("Blog deleted successfully.");
        }

        await using (var ctx = new AppDbContext(options))
        {
            var blog = await ctx.Blogs.IgnoreQueryFilters().FirstOrDefaultAsync(x => x.Id == blogId);
            blog!.IsDeleted.Should().BeTrue();
        }
    }

    [Fact]
    public async Task DeleteAsync_WhenBlogDoesNotExist_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Blog.Service(ctx, createValidator.Object, updateValidator.Object);

        var act = () => service.DeleteAsync(Guid.NewGuid());

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Blog not found.");
    }

    // ===== GetByIdAsync =====

    [Fact]
    public async Task GetByIdAsync_WhenBlogExists_ShouldReturnBlog()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var blogId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Blogs.Add(new BlogEntity { Id = blogId, Titile = "Find Me", Slug = "find-me", Author = "Author", SubTitile = "Sub", ReadingTime = "5", Description = "Desc", Tag = "tag", Cover = "cover", Content = "content", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Blog.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetByIdAsync(blogId);

            result.Titile.Should().Be("Find Me");
            result.Slug.Should().Be("find-me");
        }
    }

    [Fact]
    public async Task GetByIdAsync_WhenBlogDoesNotExist_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Blog.Service(ctx, createValidator.Object, updateValidator.Object);

        var act = () => service.GetByIdAsync(Guid.NewGuid());

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Blog not found.");
    }

    [Fact]
    public async Task GetByIdAsync_WhenBlogIsDeleted_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        var blogId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Blogs.Add(new BlogEntity { Id = blogId, Titile = "Deleted", Slug = "deleted", IsDeleted = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Blog.Service(ctx, createValidator.Object, updateValidator.Object);
            var act = () => service.GetByIdAsync(blogId);

            await act.Should().ThrowAsync<NotFoundException>()
                .WithMessage("Blog not found.");
        }
    }

    // ===== GetBySlugAsync =====

    [Fact]
    public async Task GetBySlugAsync_WhenBlogExists_ShouldReturnBlog()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.Blogs.Add(new BlogEntity { Id = Guid.NewGuid(), Titile = "Slug Test", Slug = "slug-test", Author = "Author", SubTitile = "Sub", ReadingTime = "5", Description = "Desc", Tag = "tag", Cover = "cover", Content = "content", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Blog.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetBySlugAsync("slug-test");

            result.Titile.Should().Be("Slug Test");
        }
    }

    [Fact]
    public async Task GetBySlugAsync_WhenBlogDoesNotExist_ShouldThrowNotFound()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Blog.Service(ctx, createValidator.Object, updateValidator.Object);

        var act = () => service.GetBySlugAsync("non-existent-slug");

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Blog not found.");
    }

    // ===== GetAllAsync =====

    [Fact]
    public async Task GetAllAsync_WithBlogs_ShouldReturnPaginatedResult()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            for (int i = 0; i < 5; i++)
            {
                ctx.Blogs.Add(new BlogEntity { Id = Guid.NewGuid(), Titile = $"Blog {i}", Slug = $"blog-{i}", CreatedAt = DateTime.UtcNow.AddMinutes(-i), UpdatedAt = DateTime.UtcNow.AddMinutes(-i) });
            }
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Blog.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetAllAsync(1, 3);

            result.Value.Items.Should().HaveCount(3);
            result.Value.TotalCount.Should().Be(5);
            result.Value.PageIndex.Should().Be(1);
            result.Value.PageSize.Should().Be(3);
            result.Value.HasNextPage.Should().BeTrue();
            result.Value.HasPreviousPage.Should().BeFalse();
        }
    }

    [Fact]
    public async Task GetAllAsync_WithDeletedBlogs_ShouldExcludeDeleted()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.Blogs.Add(new BlogEntity { Id = Guid.NewGuid(), Titile = "Visible", Slug = "visible", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.Blogs.Add(new BlogEntity { Id = Guid.NewGuid(), Titile = "Deleted", Slug = "deleted", IsDeleted = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Blog.Service(ctx, createValidator.Object, updateValidator.Object);
            var result = await service.GetAllAsync(1, 10);

            result.Value.TotalCount.Should().Be(1);
            result.Value.Items.Should().ContainSingle(x => ((Response.BlogResponse)x).Titile == "Visible");
        }
    }

    [Fact]
    public async Task GetAllAsync_WithNoBlogs_ShouldReturnEmpty()
    {
        var options = NewDb();
        var createValidator = CreateValidatorMock();
        var updateValidator = UpdateValidatorMock();

        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Blog.Service(ctx, createValidator.Object, updateValidator.Object);

        var result = await service.GetAllAsync(1, 10);

        result.Value.Items.Should().BeEmpty();
        result.Value.TotalCount.Should().Be(0);
    }

    // ==================================================================
    //  GetByIdAsync
    // ==================================================================

    [Fact]
    public async Task GetByIdAsync_WhenExists_ShouldReturnBlogWithRecentBlogs()
    {
        var options = NewDb();
        var main = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Blogs.Add(new BlogEntity { Id = main, Titile = "Main", Slug = "main", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            for (int i = 0; i < 3; i++)
                ctx.Blogs.Add(new BlogEntity { Id = Guid.NewGuid(), Titile = $"Recent {i}", Slug = $"recent-{i}", CreatedAt = DateTime.UtcNow.AddMinutes(-i), UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Blog.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            var result = await service.GetByIdAsync(main);

            result.Titile.Should().Be("Main");
            result.RecentBlogs.Should().HaveCount(3);
        }
    }

    [Fact]
    public async Task GetByIdAsync_WhenNotFound_ShouldThrowNotFound()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Blog.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);

        var act = () => service.GetByIdAsync(Guid.NewGuid());

        await act.Should().ThrowAsync<NotFoundException>().WithMessage("Blog not found.");
    }

    // ==================================================================
    //  UpdateAsync
    // ==================================================================

    [Fact]
    public async Task UpdateAsync_WhenNotFound_ShouldThrowNotFound()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Blog.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);

        var act = () => service.UpdateAsync(Guid.NewGuid(), ValidUpdateRequest);

        await act.Should().ThrowAsync<NotFoundException>().WithMessage("Blog not found.");
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
            ctx.Blogs.Add(new BlogEntity { Id = id, Titile = "Xoá", Slug = "xoa", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Blog.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            var result = await service.DeleteAsync(id);

            result.Should().Be("Blog deleted successfully.");
        }

        await using (var ctx = new AppDbContext(options))
        {
            (await ctx.Blogs.IgnoreQueryFilters().FirstAsync(x => x.Id == id)).IsDeleted.Should().BeTrue();
        }
    }

    [Fact]
    public async Task DeleteAsync_WhenNotFound_ShouldThrowNotFound()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var service = new Cms.Service.Blog.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);

        var act = () => service.DeleteAsync(Guid.NewGuid());

        await act.Should().ThrowAsync<NotFoundException>().WithMessage("Blog not found.");
    }

    // ==================================================================
    //  GetAllAsync — paging defaults
    // ==================================================================

    [Theory]
    [InlineData(0, 0)]   // pageIndex/pageSize <= 0 → mặc định 1/10
    [InlineData(-1, -5)]
    public async Task GetAllAsync_WithNonPositivePaging_ShouldUseDefaults(int pageIndex, int pageSize)
    {
        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            for (int i = 0; i < 12; i++)
                ctx.Blogs.Add(new BlogEntity { Id = Guid.NewGuid(), Titile = $"B{i}", Slug = $"b-{i}", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = new Cms.Service.Blog.Service(ctx, CreateValidatorMock().Object, UpdateValidatorMock().Object);
            var result = await service.GetAllAsync(pageIndex, pageSize);

            result.Value.PageIndex.Should().Be(1);
            result.Value.PageSize.Should().Be(10);
            result.Value.TotalCount.Should().Be(12);
            result.Value.Items.Should().HaveCount(10);
        }
    }

}
