using Mercado.Application.Response;
using Mercado.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Mercado.Application.Controllers;

[ApiController]
public class HealthCheckRoute: ControllerBase
{
  [HttpGet]
  [Route("/health")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status500InternalServerError)]
  // TODO por Result<HealthCh...>
  public async Task<HealthCheckRouteResponse> HealthCheck(IDatabaseRepository databaseRepository)
  {
    bool databaseRepositoryRespose = await databaseRepository.HealthCheck();
    return new HealthCheckRouteResponse()
    {
      
    };
  }
    
}