using Microsoft.AspNetCore.Mvc;
using Takid.Api.Interfaces;

namespace Takid.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SupervisorsController : ControllerBase
{
    private readonly ISupervisorInfoRepository _supervisorRepo;

    public SupervisorsController(ISupervisorInfoRepository supervisorRepo)
    {
        _supervisorRepo = supervisorRepo;
    }

    [HttpGet]
    public async Task<IActionResult> GetTop5WorkingSupervisors([FromQuery] int companyId)
    {
        return Ok(await _supervisorRepo.GetTopWorkingSupervisorsAsync(companyId));
    }
}