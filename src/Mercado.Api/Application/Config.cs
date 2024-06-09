using Mercado.Application.Mappings;

namespace Mercado.Application;

public static class ApplicationConfig
{
  public static void AddApplicationServices(this IServiceCollection services)
  {
    services.AddAutoMapper(typeof(UserProfile));
  }
}