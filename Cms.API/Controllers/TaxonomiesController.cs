using Cms.API.Extentions;
using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaxonomyService = Cms.Service.Taxonomy;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/taxonomies")]
public class TaxonomiesController : ControllerBase
{
    private readonly TaxonomyService.IService _taxonomyService;

    public TaxonomiesController(TaxonomyService.IService taxonomyService)
    {
        _taxonomyService = taxonomyService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] string? group)
    {
        var result = await _taxonomyService.GetAllAsync(group);
        result.TraceId = HttpContext.TraceIdentifier;
        return Ok(result);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _taxonomyService.GetByIdAsync(id);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create([FromBody] TaxonomyService.Request.CreateTaxonomyRequest request)
    {
        var result = await _taxonomyService.CreateAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPut("{id:guid}")]
    [Authorize]
    public async Task<IActionResult> Update(Guid id, [FromBody] TaxonomyService.Request.UpdateTaxonomyRequest request)
    {
        var result = await _taxonomyService.UpdateAsync(id, request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpDelete("{id:guid}")]
    [Authorize]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _taxonomyService.DeleteAsync(id);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }
}
