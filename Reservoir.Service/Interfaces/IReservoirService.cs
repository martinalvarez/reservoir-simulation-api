using Reservoir.Data.Models;

namespace Reservoir.Service.Interfaces;

public interface IReservoirService
{
    // Obtiene todos los puntos para el visualizador 3D y el dashboard
    IEnumerable<ReservoirPoint> GetSimulationData();
    
    // Un método extra que demuestre lógica de negocio (opcional para lucirse)
    double GetAveragePressure();
}