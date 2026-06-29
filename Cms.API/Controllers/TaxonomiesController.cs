using Cms.Repository.Enums;
using Cms.Service.Common;
using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaxonomiesService = Cms.Service.Taxonomies;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/taxonomies")]
public class TaxonomiesController : ControllerBase
{
    private readonly TaxonomiesService.IService _service;
    public TaxonomiesController(TaxonomiesService.IService service) => _service = service;

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> GetAll([FromQuery] TaxonomyGroup? group)
    {
        var result = await _service.GetAllAsync(group);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost]
    [Authorize(Policy = "AdminPolicy")]
    public async Task<IActionResult> Create([FromBody] TaxonomiesService.Request.CreateTaxonomyRequest request)
    {
        var result = await _service.CreateAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPut("{id:guid}")]
    [Authorize(Policy = "AdminPolicy")]
    public async Task<IActionResult> Update(Guid id, [FromBody] TaxonomiesService.Request.UpdateTaxonomyRequest request)
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
