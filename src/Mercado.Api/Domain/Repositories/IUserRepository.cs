using Mercado.Application.Dtos;
using Mercado.Domain.Entities;

namespace Mercado.Domain.Repositories;

public interface IUserRepository
{
    public Task<User?> GetUserByIdAsync(Guid id);
    public Task<List<User>> GetAllUsersAsync();
    public Task<User?> CreateUserAsync(UserCreateDto user);
    public Task<bool> UpdateUserAsync(UserUpdateDto user);
    public Task<bool> DeleteUserAsync(Guid id);
    public Task<bool> DeleteUserByEmailAsync(string email);
} 