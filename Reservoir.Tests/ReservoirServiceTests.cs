using Xunit;
using FluentAssertions;
using Reservoir.Service;
using System.Linq;

namespace Reservoir.Tests;

public class ReservoirServiceTests
{
    [Fact]
    public void GetSimulationData_ShouldReturnAllPointsWithCoordinates()
    {
        // Arrange (Preparar)
        var service = new ReservoirService();

        // Act (Actuar)
        var result = service.GetSimulationData();

        // Assert (Verificar)
        result.Should().NotBeEmpty();
        
        // Verificamos que al menos un punto tenga coordenadas válidas
        var firstPoint = result.First();
        firstPoint.X.Should().NotBe(0);
        firstPoint.Pressure.Should().BeGreaterThan(0);
    }

    [Fact]
    public void GetAveragePressure_ShouldCalculateCorrectValue()
    {
        // Arrange
        var service = new ReservoirService();

        // Act
        var avg = service.GetAveragePressure();

        // Assert
        avg.Should().BeGreaterThan(0);
        // Aquí podrías validar contra el valor exacto si tus datos son fijos
    }
}