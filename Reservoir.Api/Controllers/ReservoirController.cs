using Microsoft.AspNetCore.Mvc;
using Reservoir.Service.Interfaces;
using Reservoir.Data.Models;

namespace Reservoir.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReservoirController : ControllerBase
{
    private readonly IReservoirService _service;

    public ReservoirController(IReservoirService service)
    {
        _service = service;
    }

    [HttpGet("data")]
    public IActionResult GetData()
    {
        var data = _service.GetSimulationData();
        return Ok(data);
    }

    [HttpGet("stats")]
    public IActionResult GetStats()
    {
        var avg = _service.GetAveragePressure();
        return Ok(new { AveragePressure = avg });
    }
}