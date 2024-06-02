using System.Text.Json;
using FluentAssertions;
using Mercado.Application.Responses;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Mercado.Tests.Application.Routes;

public class HealthStatusTests(
    WebApplicationFactory<Mercado.Application.Controllers.HealthCheckRoute> factory
) : IClassFixture<WebApplicationFactory<Mercado.Application.Controllers.HealthCheckRoute>>
{
    private readonly HttpClient _client = factory.CreateClient();

    [Fact]
    public async Task Health_Status_Returns_OK()
    {
        // Arrange
        var url = "/health"; 
        // Act
        var response = await _client.GetAsync(url);
        // Assert
        response.EnsureSuccessStatusCode(); // Status Code 200-299
        string? contentString = await response.Content.ReadAsStringAsync();
        HealthCheckRouteResponse? content = JsonSerializer.Deserialize<HealthCheckRouteResponse>(contentString);
        content?.Should().NotBeNull();
    }
}
