using Cms.API.Extentions;
using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceService = Cms.Service.Service;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/services")]
public class ServicesController : ControllerBase
{
    private readonly ServiceService.IService _serviceService;

    public ServicesController(ServiceService.IService serviceService)
    {
        _serviceService = serviceService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] int pageIndex = 1, [FromQuery] int pageSize = 10)
    {
        var result = await _serviceService.GetAllAsync(pageIndex, pageSize);
        result.TraceId = HttpContext.TraceIdentifier;
        return Ok(result);
    }

    [HttpGet("tours")]
    public async Task<IActionResult> GetTours([FromQuery] string? keyword, [FromQuery] int pageIndex = 1, [FromQuery] int pageSize = 10)
    {
        var result = await _serviceService.GetToursAsync(keyword, pageIndex, pageSize);
        result.TraceId = HttpContext.TraceIdentifier;
        return Ok(result);
    }

    [HttpGet("combos")]
    public async Task<IActionResult> GetCombos(
        [FromQuery] string? keyword,
        [FromQuery] string? destination,
        [FromQuery] string? form,
        [FromQuery] string? classify,
        [FromQuery] string? purposeOfTrip,
        [FromQuery] int pageIndex = 1,
        [FromQuery] int pageSize = 10)
    {
        var result = await _serviceService.GetCombosAsync(keyword, destination, form, classify, purposeOfTrip, pageIndex, pageSize);
        result.TraceId = HttpContext.TraceIdentifier;
        return Ok(result);
    }

    [HttpGet("hotels")]
    public async Task<IActionResult> GetHotels(
        [FromQuery] string? keyword,
        [FromQuery] string? destination,
        [FromQuery] string? form,
        [FromQuery] string? purposeOfTrip,
        [FromQuery] int pageIndex = 1,
        [FromQuery] int pageSize = 10)
    {
        var result = await _serviceService.GetHotelsAsync(keyword, destination, form, purposeOfTrip, pageIndex, pageSize);
        result.TraceId = HttpContext.TraceIdentifier;
        return Ok(result);
    }

    [HttpGet("{key}")]
    public async Task<IActionResult> GetByKey(string key)
    {
        var result = await _serviceService.GetByKeyAsync(key);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost("tours")]
    [Authorize]
    public async Task<IActionResult> CreateTour([FromBody] ServiceService.Request.CreateTourRequest request)
    {
        var result = await _serviceService.CreateTourAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost("combos")]
    [Authorize]
    public async Task<IActionResult> CreateCombo([FromBody] ServiceService.Request.CreateComboRequest request)
    {
        var result = await _serviceService.CreateComboAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost("hotels")]
    [Authorize]
    public async Task<IActionResult> CreateHotel([FromBody] ServiceService.Request.CreateHotelRequest request)
    {
        var result = await _serviceService.CreateHotelAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPut("{id:guid}")]
    [Authorize]
    public async Task<IActionResult> Update(Guid id, [FromBody] ServiceService.Request.UpdateServiceRequest request)
    {
        var result = await _serviceService.UpdateAsync(id, request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpDelete("{id:guid}")]
    [Authorize]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _serviceService.DeleteAsync(id);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }
}
