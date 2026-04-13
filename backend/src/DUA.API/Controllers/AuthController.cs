using Microsoft.AspNetCore.Mvc;

namespace DUA.API.Controllers;

[ApiController]
[Route("api/auth")]
public sealed class AuthController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login()
    {
        return StatusCode(StatusCodes.Status501NotImplemented, "Auth flow placeholder.");
    }
}
