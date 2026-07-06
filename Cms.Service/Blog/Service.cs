using Cms.Repository;
using Cms.Service.Configurations;
using Cms.Service.Exceptions;
using Cms.Service.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.Blog;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<Request.CreateBlogRequest> _createValidator;
    private readonly IValidator<Request.UpdateBlogRequest> _updateValidator;

    public Service(AppDbContext dbContext, IValidator<Request.CreateBlogRequest> createValidator, IValidator<Request.UpdateBlogRequest> updateValidator)
    {
        _dbContext = dbContext;
        _createValidator = createValidator;
        _updateValidator = updateValidator;
    }

    public async Task<BasePaginationResponse> GetAllAsync(int pageIndex, int pageSize)
    {
        pageIndex = pageIndex <= 0 ? 1 : pageIndex;
        pageSize = pageSize <= 0 ? 10 : Math.Min(pageSize, 100);

        var query = _dbContext.Blogs
            .AsNoTracking()
            .Where(x => !x.IsDeleted);

        var totalCount = await query.CountAsync();
        var items = await query
            .OrderByDescending(x => x.CreatedAt)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .Select(x => ToResponse(x))
            .ToListAsync();

        return ApiResponseFactory.BasePagination(items, pageIndex, pageSize, totalCount);
    }

    public async Task<Response.BlogResponse> GetByIdAsync(Guid id)
    {
        var blog = await _dbContext.Blogs
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (blog is null) throw new NotFoundException("Blog not found.");

        var response = ToResponse(blog);

        response.RecentBlogs = await _dbContext.Blogs
            .AsNoTracking()
            .Where(x => !x.IsDeleted && x.Id != id)
            .OrderByDescending(x => x.CreatedAt)
            .Take(3)
            .Select(x => ToResponse(x))
            .ToListAsync();

        return response;
    }

    public async Task<Response.BlogResponse> CreateAsync(Request.CreateBlogRequest request)
    {
        await _createValidator.ValidateAndThrowAsync(request);

        var now = DateTime.UtcNow;
        var blog = new Repository.Entities.Blog
        {
            Id = Guid.NewGuid(),
            Titile = request.Titile.Trim(),
            SubTitile = request.SubTitile.Trim(),
            Author = request.Author.Trim(),
            ReadingTime = request.ReadingTime.Trim(),
            Description = request.Description.Trim(),
            Tag = request.Tag.Trim(),
            Slug = await GenerateUniqueSlugAsync(request.Titile),
            Cover = request.Cover.Trim(),
            Content = request.Content,
            CreatedAt = now,
            UpdatedAt = now,
        };

        _dbContext.Blogs.Add(blog);
        await _dbContext.SaveChangesAsync();

        return ToResponse(blog);
    }

    public async Task<Response.BlogResponse> UpdateAsync(Guid id, Request.UpdateBlogRequest request)
    {
        await _updateValidator.ValidateAndThrowAsync(request);

        var blog = await _dbContext.Blogs.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (blog is null) throw new NotFoundException("Blog not found.");

        blog.Titile = request.Titile.Trim();
        blog.SubTitile = request.SubTitile.Trim();
        blog.Author = request.Author.Trim();
        blog.ReadingTime = request.ReadingTime.Trim();
        blog.Description = request.Description.Trim();
        blog.Tag = request.Tag.Trim();
        // GIỮ NGUYÊN slug khi sửa (slug chỉ sinh 1 lần lúc tạo) — đổi tiêu đề không
        // đổi URL, tránh vỡ link/bookmark/ISR đã build. (KHÔNG regenerate ở đây.)
        blog.Cover = request.Cover.Trim();
        blog.Content = request.Content;
        blog.UpdatedAt = DateTime.UtcNow;

        await _dbContext.SaveChangesAsync();

        return ToResponse(blog);
    }

    public async Task<string> DeleteAsync(Guid id)
    {
        var blog = await _dbContext.Blogs.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (blog is null) throw new NotFoundException("Blog not found.");

        blog.IsDeleted = true;
        blog.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();

        return "Blog deleted successfully.";
    }

    private async Task<string> GenerateUniqueSlugAsync(string title, Guid? excludedBlogId = null)
    {
        var baseSlug = Slug.GenerateSlug(title.Trim());
        if (string.IsNullOrWhiteSpace(baseSlug)) baseSlug = Guid.NewGuid().ToString("N");

        var slug = baseSlug;
        var suffix = 1;

        while (await _dbContext.Blogs.AnyAsync(x => !x.IsDeleted && x.Slug == slug && (!excludedBlogId.HasValue || x.Id != excludedBlogId.Value)))
        {
            slug = $"{baseSlug}-{suffix}";
            suffix++;
        }

        return slug;
    }

    private static Response.BlogResponse ToResponse(Repository.Entities.Blog blog)
    {
        return new Response.BlogResponse
        {
            Id = blog.Id,
            Titile = blog.Titile ?? string.Empty,
            SubTitile = blog.SubTitile ?? string.Empty,
            Author = blog.Author ?? string.Empty,
            ReadingTime = blog.ReadingTime ?? string.Empty,
            Description = blog.Description ?? string.Empty,
            Tag = blog.Tag ?? string.Empty,
            Slug = blog.Slug ?? string.Empty,
            Cover = blog.Cover ?? string.Empty,
            Content = blog.Content ?? string.Empty,
            CreatedAt = blog.CreatedAt,
            UpdatedAt = blog.UpdatedAt,
        };
    }

    public async Task<Response.BlogResponse> GetBySlugAsync(string slug)
    {
        var blog = await _dbContext.Blogs
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Slug == slug && !x.IsDeleted);

        if (blog is null) throw new NotFoundException("Blog not found.");

        var response = ToResponse(blog);
        response.RecentBlogs = await _dbContext.Blogs
            .AsNoTracking()
            .Where(x => !x.IsDeleted && x.Id != blog.Id)
            .OrderByDescending(x => x.CreatedAt)
            .Take(3)
            .Select(x => ToResponse(x))
            .ToListAsync();

        return response;
    }
}
