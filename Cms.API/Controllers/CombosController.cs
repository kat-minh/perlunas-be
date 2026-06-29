using Cms.Service.Queries;
using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CombosService = Cms.Service.Combos;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/combos")]
[Authorize(Policy = "AdminPolicy")]
public class CombosController : ControllerBase
{
    private readonly CombosService.IService _combos;
    public CombosController(CombosService.IService combos) => _combos = combos;

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> GetAll([FromQuery] CatalogQuery query)
    {
        return Ok(await _combos.GetPagedAsync(query));
    }

    [HttpGet("{slug}")]
    [AllowAnonymous]
    public async Task<IActionResult> GetBySlug(string slug)
    {
        var result = await _combos.GetBySlugAsync(slug);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CombosService.Request.CreateComboRequest request)
    {
        var result = await _combos.CreateAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPut("{slug}")]
    public async Task<IActionResult> Update(string slug, [FromBody] CombosService.Request.UpdateComboRequest request)
    {
        var result = await _combos.UpdateAsync(slug, request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpDelete("{slug}")]
    public async Task<IActionResult> Delete(string slug)
    {
        await _combos.DeleteAsync(slug);
        return Ok(ApiResponseFactory.Base(null, true, "", HttpContext.TraceIdentifier));
    }
}