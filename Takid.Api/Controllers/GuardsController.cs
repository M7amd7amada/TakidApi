using Microsoft.AspNetCore.Mvc;
using Takid.Api.Interfaces;

namespace Takid.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GuardsController : ControllerBase
{
    private readonly IGuardInfoRepository _guardsRepo;

    public GuardsController(IGuardInfoRepository guardsRepo)
    {
        _guardsRepo = guardsRepo;
    }

    [HttpGet]
    public async Task<IActionResult> GetTop5WorkingGurads([FromQuery] int companyId)
    {
        return Ok(await _guardsRepo.GetTopWorkingGuardsAsync(companyId));
    }
}