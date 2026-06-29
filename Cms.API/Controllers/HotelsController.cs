using Cms.Service.Queries;
using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HotelsService = Cms.Service.Hotels;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/hotels")]
[Authorize(Policy = "AdminPolicy")]
public class HotelsController : ControllerBase
{
    private readonly HotelsService.IService _hotels;
    public HotelsController(HotelsService.IService hotels) => _hotels = hotels;

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> GetAll([FromQuery] CatalogQuery query)
    {
       return Ok(await _hotels.GetPagedAsync(query));
    }

    [HttpGet("{slug}")]
    [AllowAnonymous]
    public async Task<IActionResult> GetBySlug(string slug)
    {
        var result = await _hotels.GetBySlugAsync(slug);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] HotelsService.Request.CreateHotelRequest request)
    {
        var result = await _hotels.CreateAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPut("{slug}")]
    public async Task<IActionResult> Update(string slug, [FromBody] HotelsService.Request.UpdateHotelRequest request)
    {
        var result = await _hotels.UpdateAsync(slug, request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpDelete("{slug}")]
    public async Task<IActionResult> Delete(string slug)
    {
        await _hotels.DeleteAsync(slug);
        return Ok(ApiResponseFactory.Base(null, true, "", HttpContext.TraceIdentifier));
    }
}
