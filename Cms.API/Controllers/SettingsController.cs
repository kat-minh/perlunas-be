using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiteSettingsService = Cms.Service.SiteSettings;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/settings")]
[Authorize(Policy = "AdminPolicy")]
public class SettingsController : ControllerBase
{
    private readonly SiteSettingsService.IService _settings;
    public SettingsController(SiteSettingsService.IService settings) => _settings = settings;

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> Get()
    {
        var result = await _settings.GetAsync();
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] SiteSettingsService.Request.UpdateSiteSettingRequest dto)
    {
        var result = await _settings.UpdateAsync(dto);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }
}
