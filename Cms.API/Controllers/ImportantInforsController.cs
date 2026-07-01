using Cms.API.Extentions;
using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ImportantInforService = Cms.Service.ImportantInfor;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/important-infors")]
[Authorize(Policy = JwtExtensions.AdminPolicy)]
public class ImportantInforsController : ControllerBase
{
    private readonly ImportantInforService.IService _importantInforService;

    public ImportantInforsController(ImportantInforService.IService importantInforService)
    {
        _importantInforService = importantInforService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] int pageIndex = 1, [FromQuery] int pageSize = 10)
    {
        var result = await _importantInforService.GetAllAsync(pageIndex, pageSize);
        result.TraceId = HttpContext.TraceIdentifier;
        return Ok(result);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _importantInforService.GetByIdAsync(id);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ImportantInforService.Request.CreateImportantInforRequest request)
    {
        var result = await _importantInforService.CreateAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] ImportantInforService.Request.UpdateImportantInforRequest request)
    {
        var result = await _importantInforService.UpdateAsync(id, request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _importantInforService.DeleteAsync(id);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }
}
