using Moq;
using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Reservoir.Api.Controllers;
using Reservoir.Api.DTOs;
using Reservoir.Service.Interfaces;
using Reservoir.Data.Models;

namespace Reservoir.Tests;

public class ReservoirControllerTests
{
    [Fact]
    public async Task GetData_ShouldReturnCorrectDtoMapping()
    {
        // Arrange (Configuramos el Mock)
        var mockService = new Mock<IReservoirService>();
        
        // Simulamos que el servicio devuelve UN punto con coordenadas
        var fakeData = new List<ReservoirPoint> 
        { 
            new() { Id = 1, LayerName = "Test", Pressure = 100, X = 10.5, Y = 20.5, Z = 30.5 } 
        };
        mockService.Setup(s => s.GetSimulationData()).Returns(fakeData);

        var controller = new ReservoirController(mockService.Object);

        // Act
        var result = await controller.GetData();

        // Assert
        var okResult = result.Result as OkObjectResult;
        okResult.Should().NotBeNull();
        
        var dtos = okResult.Value as IEnumerable<ReservoirPointDto>;
        dtos.First().X.Should().Be(10.5); // <--- ESTO garantiza que no nos olvidemos de X!
        dtos.First().LayerName.Should().Be("Test");
    }
}