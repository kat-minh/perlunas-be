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

    public AuthController(AuthService.IService auth) => _auth = auth;

    [HttpPost("login")]
    [AllowAnonymous]
    public async Task<IActionResult> Login([FromBody] AuthService.Request.LoginRequest request)
    {
        var result = await _auth.LoginAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "", HttpContext.TraceIdentifier));
    }

    [HttpPost("register")]
    [AllowAnonymous]
    public async Task<IActionResult> Register([FromBody] AuthService.Request.RegisterRequest request)
    {
        var result = await _auth.RegisterAsync(request);
        return Ok(ApiResponseFactory.Base(result, true, "Registration successful", HttpContext.TraceIdentifier));
    }

    [HttpGet("me")]
    [Authorize]
    public async Task<IActionResult> Me()
    {
        var profile = await _auth.GetProfileAsync();
        return Ok(ApiResponseFactory.Base(profile, true, "", HttpContext.TraceIdentifier));
    }
}
