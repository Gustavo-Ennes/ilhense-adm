using Mercado.Domain.Repositories;
using Mercado.Infrastructure.Database.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Mercado.Infrastructure.Database.Services;

public class DatabaseRepository(AuthContext context) : IDatabaseRepository
{
    private readonly AuthContext _authContext = context;

    public async Task<bool> HealthCheck()
    {
        await _authContext.Database.OpenConnectionAsync();
        await _authContext.Database.ExecuteSqlRawAsync("SELECT 1");
        await _authContext.Database.CloseConnectionAsync();

        return true;
    }
}
