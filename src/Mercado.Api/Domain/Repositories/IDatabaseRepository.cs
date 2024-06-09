namespace Mercado.Domain.Repositories;

public interface IDatabaseRepository
{
  public Task<bool> HealthCheck();
}