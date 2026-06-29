using Cms.Repository.Enums;
using Cms.Service.Common;
using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TourCardsService = Cms.Service.TourCards;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/private-tours")]
public class PrivateToursController : ControllerBase
{
    private readonly TourCardsService.IService _service;
    public PrivateToursController(TourCardsService.IService service) => _service = service;

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> GetAll()
    {
        var result = await _service.GetAllAsync(TourCardType.Private);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpGet("{id:guid}")]
    [AllowAnonymous]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _service.GetByIdAsync(id, TourCardType.Private);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost]
    [Authorize(Policy = "AdminPolicy")]
    public async Task<IActionResult> Create([FromBody] TourCardsService.Request.CreateTourCardRequest request)
    {
        request.Type = TourCardType.Private;
        var result = await _service.CreateAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPut("{id:guid}")]
    [Authorize(Policy = "AdminPolicy")]
    public async Task<IActionResult> Update(Guid id, [FromBody] TourCardsService.Request.UpdateTourCardRequest request)
    {
        var result = await _service.UpdateAsync(id, request, TourCardType.Private);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpDelete("{id:guid}")]
    [Authorize(Policy = "AdminPolicy")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _service.DeleteAsync(id, TourCardType.Private);
        return Ok(ApiResponseFactory.Base(null, true, "", HttpContext.TraceIdentifier));
    }
}
