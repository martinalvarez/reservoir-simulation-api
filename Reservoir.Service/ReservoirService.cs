using Reservoir.Service.Interfaces;
using Reservoir.Data.Models;      // <--- Cambiar
using Reservoir.Data.Repositories; // <--- Cambiar

namespace Reservoir.Service;

public class ReservoirService : IReservoirService
{
    private readonly ReservoirRepository _repository;

    public ReservoirService()
    {
        // En una app más compleja usaríamos Inyección de Dependencias aquí también
        _repository = new ReservoirRepository();
    }

    public IEnumerable<ReservoirPoint> GetSimulationData()
    {
        return _repository.GetAllPoints();
    }

    public double GetAveragePressure()
    {
        var points = _repository.GetAllPoints();
        if (!points.Any()) return 0;
        return points.Average(p => p.Pressure);
    }
}