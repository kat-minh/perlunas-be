using Cms.Service.Common;
using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PageContentService = Cms.Service.PageContent;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/page-content")]
public class PageContentController : ControllerBase
{
    private readonly PageContentService.IService _service;
    public PageContentController(PageContentService.IService service) => _service = service;

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> GetAll()
    {
        var result = await _service.GetAllAsync();
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPut]
    [Authorize(Policy = "AdminPolicy")]
    public async Task<IActionResult> Update([FromBody] List<PageContentService.Request.PageContentUpdate> updates)
    {
        await _service.UpdateValuesAsync(updates);
        var result = await _service.GetAllAsync();
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }
}
