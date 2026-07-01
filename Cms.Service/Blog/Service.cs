using Cms.Repository;
using Cms.Service.Exceptions;
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

    public async Task<List<Response.BlogResponse>> GetAllAsync()
    {
        return await _dbContext.Blogs
            .AsNoTracking()
            .Where(x => !x.IsDeleted)
            .OrderByDescending(x => x.CreatedAt)
            .Select(x => ToResponse(x))
            .ToListAsync();
    }

    public async Task<Response.BlogResponse> GetByIdAsync(Guid id)
    {
        var blog = await _dbContext.Blogs
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (blog is null) throw new NotFoundException("Blog not found.");

        return ToResponse(blog);
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
            CreatedAt = blog.CreatedAt,
            UpdatedAt = blog.UpdatedAt,
        };
    }
}
