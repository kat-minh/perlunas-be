using Cms.API.Extentions;
using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiteSettingService = Cms.Service.SiteSetting;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/site-settings")]
[Authorize(Policy = JwtExtensions.AdminPolicy)]
public class SiteSettingsController : ControllerBase
{
    private readonly SiteSettingService.IService _siteSettingService;

    public SiteSettingsController(SiteSettingService.IService siteSettingService)
    {
        _siteSettingService = siteSettingService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _siteSettingService.GetAllAsync();
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _siteSettingService.GetByIdAsync(id);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] SiteSettingService.Request.CreateSiteSettingRequest request)
    {
        var result = await _siteSettingService.CreateAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] SiteSettingService.Request.UpdateSiteSettingRequest request)
    {
        var result = await _siteSettingService.UpdateAsync(id, request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _siteSettingService.DeleteAsync(id);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }
}
