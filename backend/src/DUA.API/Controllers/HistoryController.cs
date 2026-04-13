using Microsoft.AspNetCore.Mvc;

namespace DUA.API.Controllers;

[ApiController]
[Route("api/history")]
public sealed class HistoryController : ControllerBase
{
    [HttpGet("duas")]
    public IActionResult GetDuaHistory()
    {
        return StatusCode(StatusCodes.Status501NotImplemented, "History retrieval placeholder.");
    }
}
