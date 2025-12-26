using System.Text.Json;
using Reservoir.Data.Models;

namespace Reservoir.Data.Repositories;

public class ReservoirRepository
{
    private readonly string _filePath = Path.Combine(AppContext.BaseDirectory, "Data", "reservoir-initial-data.json");

    public IEnumerable<ReservoirPoint> GetAllPoints()
    {
        // En una app real, aquí iría un query de Entity Framework
        if (!File.Exists(_filePath)) return new List<ReservoirPoint>();
        
        var json = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<List<ReservoirPoint>>(json) ?? new List<ReservoirPoint>();
    }
}

/*
public class ReservoirRepository
{
    private readonly string _filePath;

    public ReservoirRepository()
    {
        // Esto buscará la carpeta Data que está al lado del ejecutable de la API
        _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "reservoir-initial-data.json");
    }

    public IEnumerable<ReservoirPoint> GetAllPoints()
    {
        if (!File.Exists(_filePath)) 
        {
            // Tip: poné un breakpoint acá o un Console.WriteLine para ver qué ruta está buscando
            Console.WriteLine($"Archivo no encontrado en: {_filePath}");
            return new List<ReservoirPoint>();
        }
        
        var json = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<List<ReservoirPoint>>(json) ?? new List<ReservoirPoint>();
    }
}
*/

