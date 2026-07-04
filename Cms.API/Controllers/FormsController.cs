using Cms.API.Extentions;
using Cms.Repository.Enums;
using Cms.Service.Models;
using Microsoft.AspNetCore.Mvc;
using FormService = Cms.Service.Form;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/forms")]
public class FormsController : ControllerBase
{
    private readonly FormService.IService _formService;

    public FormsController(FormService.IService formService)
    {
        _formService = formService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(
        [FromQuery] int pageIndex = 1,
        [FromQuery] int pageSize = 10,
        [FromQuery] FormType? type = null)
    {
        var result = await _formService.GetAllAsync(pageIndex, pageSize, type);
        result.TraceId = HttpContext.TraceIdentifier;
        return Ok(result);
    }

    [HttpGet("{key}")]
    public async Task<IActionResult> GetByKey(string key)
    {
        var result = await _formService.GetByKeyAsync(key);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost("advise")]
    public async Task<IActionResult> CreateAdvise([FromBody] FormService.Request.CreateAdviseFormRequest request)
    {
        var result = await _formService.CreateAdviseAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost("tour")]
    public async Task<IActionResult> CreateTour([FromBody] FormService.Request.CreateTourFormRequest request)
    {
        var result = await _formService.CreateTourAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost("combo")]
    public async Task<IActionResult> CreateCombo([FromBody] FormService.Request.CreateBookingFormRequest request)
    {
        var result = await _formService.CreateComboAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }
}
