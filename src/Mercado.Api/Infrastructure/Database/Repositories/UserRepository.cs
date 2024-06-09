using Azure;
using Mercado.Application.Dtos;
using Mercado.Domain.Entities;
using Mercado.Domain.Repositories;
using Mercado.Infrastructure.Database.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Mercado.Infrastructure.Database.Services;

public class UserRepository(AuthContext context) : IUserRepository
{
    private readonly AuthContext _authContext = context;

    // Create
    public async Task<User?> CreateUserAsync(UserCreateDto userDto)
    {
        User user= userDto.ToUser();
        _authContext.Users.Add(user);
        await _authContext.SaveChangesAsync();
        return user;
    }

    // Read
    public async Task<User?> GetUserByIdAsync(Guid id)
    {
        return await _authContext.Users.FindAsync(id);
    }

    public async Task<List<User>> GetAllUsersAsync()
    {
        return await _authContext.Users.ToListAsync();
    }

    // Update
    public async Task<bool> UpdateUserAsync(UserUpdateDto userDto)
    {
        _authContext.Users.Update(userDto.ToUser());
        await _authContext.SaveChangesAsync();
        return true;
    }

    // Delete
    public async Task<bool> DeleteUserAsync(Guid id)
    {
        var user = await _authContext.Users.FindAsync(id);
        if (user == null)
            return false;

        _authContext.Users.Remove(user);
        await _authContext.SaveChangesAsync();
        return true;
    }
    public async Task<bool> DeleteUserByEmailAsync(string email)
    {
        var user = await _authContext.Users.SingleOrDefaultAsync(u => u.Email == email);
        if (user == null)
            return false;

        _authContext.Users.Remove(user);
        await _authContext.SaveChangesAsync();
        return true;
    }
}
