using DUA.Application.DTOs;
using DUA.Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace DUA.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class HistoryController : ControllerBase
{
    [HttpGet("{userId:guid}")]
    public async Task<ActionResult<IReadOnlyCollection<DuaHistoryItemResponse>>> GetHistory(
        Guid userId,
        [FromServices] GetDuaHistory useCase,
        CancellationToken cancellationToken)
    {
        var request = new GetDuaHistoryRequest(userId);
        return Ok(await useCase.ExecuteAsync(request, cancellationToken));
    }
}
