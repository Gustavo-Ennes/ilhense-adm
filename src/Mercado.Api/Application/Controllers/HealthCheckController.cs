using Mercado.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Mercado.Application.Controllers;

[ApiController]
public class HealthCheckRoute: ControllerBase
{
  [HttpGet]
  [Route("/health")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public HealthCheckRouteResponse HealthCheck()
  {
    return new HealthCheckRouteResponse
    {
      Response = "System is running.",
      ResponseCode = 200
    };
  }
    
}