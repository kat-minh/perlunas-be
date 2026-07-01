using Cms.API.Extentions;
using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DepartureScheduleService = Cms.Service.DepartureSchedule;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/departure-schedules")]
[Authorize(Policy = JwtExtensions.AdminPolicy)]
public class DepartureSchedulesController : ControllerBase
{
    private readonly DepartureScheduleService.IService _departureScheduleService;

    public DepartureSchedulesController(DepartureScheduleService.IService departureScheduleService)
    {
        _departureScheduleService = departureScheduleService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _departureScheduleService.GetAllAsync();
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _departureScheduleService.GetByIdAsync(id);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] DepartureScheduleService.Request.CreateDepartureScheduleRequest request)
    {
        var result = await _departureScheduleService.CreateAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] DepartureScheduleService.Request.UpdateDepartureScheduleRequest request)
    {
        var result = await _departureScheduleService.UpdateAsync(id, request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _departureScheduleService.DeleteAsync(id);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }
}
