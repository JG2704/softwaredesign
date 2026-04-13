using Microsoft.AspNetCore.Mvc;

namespace DUA.API.Controllers;

[ApiController]
[Route("api/templates")]
public sealed class TemplateController : ControllerBase
{
    [HttpPost]
    public IActionResult SetupDuaTemplate()
    {
        return StatusCode(StatusCodes.Status501NotImplemented, "Template setup placeholder.");
    }
}
