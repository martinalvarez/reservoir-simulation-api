using Microsoft.AspNetCore.Mvc;
using Reservoir.Service.Interfaces;
using Reservoir.Api.DTOs;

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
    public async Task<ActionResult<IEnumerable<ReservoirPointDto>>> GetData()    
    {
        await Task.Delay(500);

        var rawData = _service.GetSimulationData();
        
        var dtoData = rawData.Select(p => new ReservoirPointDto(
            p.Id, 
            p.LayerName, 
            p.Pressure, 
            p.Temperature,
            p.X,
            p.Y,
            p.Z
        ));

        return Ok(dtoData);
    }

    [HttpGet("stats")]
    public ActionResult<ReservoirStatsDto> GetStats()
    {
        var avg = _service.GetAveragePressure();
        return Ok(new ReservoirStatsDto(avg));
    }
}