using DUA.Application.DTOs;
using DUA.Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace DUA.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class TemplateController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<SetupDuaTemplateResponse>> SetupTemplate(
        [FromBody] SetupDuaTemplateRequest request,
        [FromServices] SetupDuaTemplate useCase,
        CancellationToken cancellationToken)
    {
        return Ok(await useCase.ExecuteAsync(request, cancellationToken));
    }
}
