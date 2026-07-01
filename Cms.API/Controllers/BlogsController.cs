using Cms.API.Extentions;
using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BlogService = Cms.Service.Blog;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/blogs")]
[Authorize(Policy = JwtExtensions.AdminPolicy)]
public class BlogsController : ControllerBase
{
    private readonly BlogService.IService _blogService;

    public BlogsController(BlogService.IService blogService)
    {
        _blogService = blogService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _blogService.GetAllAsync();
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _blogService.GetByIdAsync(id);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] BlogService.Request.CreateBlogRequest request)
    {
        var result = await _blogService.CreateAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] BlogService.Request.UpdateBlogRequest request)
    {
        var result = await _blogService.UpdateAsync(id, request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _blogService.DeleteAsync(id);
        return Ok(ApiResponseFactory.Base(result, true, result, HttpContext.TraceIdentifier));
    }
}
