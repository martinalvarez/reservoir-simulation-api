namespace Reservoir.Data.Models;

public class ReservoirPoint
{
    public int Id { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }
    public double Pressure { get; set; }
    public double Temperature { get; set; }
    public string LayerName { get; set; } = string.Empty;
}