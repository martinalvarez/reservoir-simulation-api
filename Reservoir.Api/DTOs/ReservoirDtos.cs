using System.Text.Json.Serialization;

namespace Reservoir.Api.DTOs;

public record ReservoirPointDto(
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("layerName")] string LayerName,
    [property: JsonPropertyName("pressure")] double Pressure,
    [property: JsonPropertyName("temperature")] double Temperature,
    [property: JsonPropertyName("x")] double X,
    [property: JsonPropertyName("y")] double Y,
    [property: JsonPropertyName("z")] double Z
);

public record ReservoirStatsDto(
    [property: JsonPropertyName("averagePressure")] double AveragePressure
);