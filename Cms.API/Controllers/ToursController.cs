using Cms.Service.Queries;
using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToursService = Cms.Service.Tours;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/tours")]
[Authorize(Policy = "AdminPolicy")]
public class ToursController : ControllerBase
{
    private readonly ToursService.IService _tours;
    public ToursController(ToursService.IService tours) => _tours = tours;

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> GetAll([FromQuery] CatalogQuery query)
    {
        return Ok(await _tours.GetPagedAsync(query));
    }

    [HttpGet("{slug}")]
    [AllowAnonymous]
    public async Task<IActionResult> GetBySlug(string slug)
    {
        var result = await _tours.GetBySlugAsync(slug);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ToursService.Request.CreateTourRequest request)
    {
        var result = await _tours.CreateAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPut("{slug}")]
    public async Task<IActionResult> Update(string slug, [FromBody] ToursService.Request.UpdateTourRequest request)
    {
        var result = await _tours.UpdateAsync(slug, request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpDelete("{slug}")]
    public async Task<IActionResult> Delete(string slug)
    {
        await _tours.DeleteAsync(slug);
        return Ok(ApiResponseFactory.Base(null, true, "", HttpContext.TraceIdentifier));
    }
}
