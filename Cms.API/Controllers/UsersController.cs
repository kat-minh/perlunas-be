using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UsersService = Cms.Service.Users;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/users")]
[Authorize]
public class UsersController : ControllerBase
{
    private readonly UsersService.IService _users;

    public UsersController(UsersService.IService users) => _users = users;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _users.GetAllAsync();
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] UsersService.Request.CreateUserRequest request)
    {
        var result = await _users.CreateAsync(request);
        return CreatedAtAction(nameof(GetAll), ApiResponseFactory.Base(result, true, result.Message, HttpContext.TraceIdentifier));
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UsersService.Request.UpdateUserRequest request)
    {
        var result = await _users.UpdateAsync(id, request);
        return Ok(ApiResponseFactory.Base(result, true, result.Message, HttpContext.TraceIdentifier));
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _users.DeleteAsync(id);
        return Ok(ApiResponseFactory.Base(null, true, result.Message, HttpContext.TraceIdentifier));
    }
}
