using Cms.Service.Common;
using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ComboTiersService = Cms.Service.ComboTiers;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/combo-tiers")]
public class ComboTiersController : ControllerBase
{
    private readonly ComboTiersService.IService _service;
    public ComboTiersController(ComboTiersService.IService service) => _service = service;

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> GetAll()
    {
        var result = await _service.GetAllAsync();
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost]
    [Authorize(Policy = "AdminPolicy")]
    public async Task<IActionResult> Create([FromBody] ComboTiersService.Request.CreateComboTierRequest request)
    {
        var result = await _service.CreateAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPut("{id:guid}")]
    [Authorize(Policy = "AdminPolicy")]
    public async Task<IActionResult> Update(Guid id, [FromBody] ComboTiersService.Request.UpdateComboTierRequest request)
    {
        var result = await _service.UpdateAsync(id, request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpDelete("{id:guid}")]
    [Authorize(Policy = "AdminPolicy")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _service.DeleteAsync(id);
        return Ok(ApiResponseFactory.Base(null, true, "", HttpContext.TraceIdentifier));
    }
}
