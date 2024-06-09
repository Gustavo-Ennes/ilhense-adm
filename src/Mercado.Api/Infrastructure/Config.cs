using Mercado.Domain.Repositories;
using Mercado.Infrastructure.Database.Contexts;
using Mercado.Infrastructure.Database.Services;
using Microsoft.EntityFrameworkCore;

namespace Mercado.Infrastructure;

public static class DatabaseConfig
{
    public static void AddInfrastructureServices(
        this IServiceCollection services,
        IConfiguration config
    )
    {
        services.AddDbContext<AuthContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DBConnection"))
        );
        services.AddControllersWithViews();
        services.AddScoped<IDatabaseRepository, DatabaseRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
    }
}
