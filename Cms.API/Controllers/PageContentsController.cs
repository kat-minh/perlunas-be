using Cms.API.Extentions;
using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PageContentService = Cms.Service.PageContent;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/page-contents")]
public class PageContentsController : ControllerBase
{
    private readonly PageContentService.IService _pageContentService;

    public PageContentsController(PageContentService.IService pageContentService)
    {
        _pageContentService = pageContentService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] string? pageKey, [FromQuery] string? sectionKey)
    {
        var result = await _pageContentService.GetAllAsync(pageKey, sectionKey);
        result.TraceId = HttpContext.TraceIdentifier;
        return Ok(result);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _pageContentService.GetByIdAsync(id);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create([FromBody] PageContentService.Request.CreatePageContentRequest request)
    {
        var result = await _pageContentService.CreateAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPut("{id:guid}")]
    [Authorize]
    public async Task<IActionResult> Update(Guid id, [FromBody] PageContentService.Request.UpdatePageContentRequest request)
    {
        var result = await _pageContentService.UpdateAsync(id, request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpDelete("{id:guid}")]
    [Authorize]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _pageContentService.DeleteAsync(id);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }
}
