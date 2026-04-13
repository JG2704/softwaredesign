using Microsoft.AspNetCore.Mvc;

namespace DUA.API.Controllers;

[ApiController]
[Route("api/dua-generation")]
public sealed class DuaGenerationController : ControllerBase
{
    [HttpPost("upload")]
    public IActionResult UploadFilesToGenerateDua()
    {
        return StatusCode(StatusCodes.Status501NotImplemented, "DUA generation upload placeholder.");
    }

    [HttpPost("run")]
    public IActionResult GenerateDuaFromUploadedDocuments()
    {
        return StatusCode(StatusCodes.Status501NotImplemented, "DUA generation processing placeholder.");
    }
}
