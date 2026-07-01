using Cms.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AuthService = Cms.Service.Auth;

namespace Cms.API.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly AuthService.IService _auth;

    public AuthController(AuthService.IService auth)
    {
        _auth = auth;
    }

    [HttpPost("login")]
    [AllowAnonymous]
    public IActionResult Login([FromBody] AuthService.Request.LoginRequest request)
    {
        var result = _auth.Login(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost("logout")]
    [Authorize]
    public IActionResult Logout()
    {
        var result = _auth.Logout();
        return Ok(ApiResponseFactory.Base(result, true, result.Message, HttpContext.TraceIdentifier));
    }
}
