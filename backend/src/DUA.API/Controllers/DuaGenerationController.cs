using DUA.Application.DTOs;
using DUA.Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace DUA.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class DuaGenerationController : ControllerBase
{
    [HttpPost("upload")]
    public async Task<ActionResult<UploadFilesToGenerateDuaResponse>> Upload(
        [FromBody] UploadFilesToGenerateDuaRequest request,
        [FromServices] UploadFilesToGenerateDua useCase,
        CancellationToken cancellationToken)
    {
        return Ok(await useCase.ExecuteAsync(request, cancellationToken));
    }
}
