using System.Text.Json.Serialization;

namespace Mercado.Application.Responses;

public class HealthCheckRouteResponse
{
    [JsonPropertyName("response")]
    public required string Response { get; set; }
    [JsonPropertyName("responseCode")]
    public required int ResponseCode { get; set; }
}
