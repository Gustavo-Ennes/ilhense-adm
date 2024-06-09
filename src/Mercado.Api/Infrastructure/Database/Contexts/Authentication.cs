using Mercado.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Mercado.Infrastructure.Database.Contexts;

public class AuthContext(DbContextOptions<AuthContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("User");
    }
}
