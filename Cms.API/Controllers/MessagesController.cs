using Cms.Service.Queries;
using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ContactMessagesService = Cms.Service.ContactMessages;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/messages")]
[Authorize(Policy = "AdminPolicy")]
public class MessagesController : ControllerBase
{
    private readonly ContactMessagesService.IService _messages;
    public MessagesController(ContactMessagesService.IService messages) => _messages = messages;

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Create([FromBody] ContactMessagesService.Request.CreateContactMessageRequest request)
    {
        var result = await _messages.CreateAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] MessageQuery query)
        => Ok(await _messages.GetPagedAsync(query));

    [HttpGet("unread-count")]
    public async Task<IActionResult> UnreadCount()
    {
        var count = await _messages.CountUnreadAsync();
        return Ok(ApiResponseFactory.Base(new { count }, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPatch("{id:guid}/read")]
    public async Task<IActionResult> MarkRead(Guid id)
    {
        var result = await _messages.MarkReadAsync(id);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _messages.DeleteAsync(id);
        return Ok(ApiResponseFactory.Base(null, true, "", HttpContext.TraceIdentifier));
    }
}
