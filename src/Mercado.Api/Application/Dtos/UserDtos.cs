using AutoMapper;
using Mercado.Domain.Entities;

namespace Mercado.Application.Dtos;

public class UserCreateDto(IMapper mapper)
{
    public IMapper _mapper = mapper;
    public required string Name { get; set; }
    public required string LastName { get; set; }
    public required string UserName { get; set; }
    public required string Password { get; set; }
    public required string Email { get; set; }

    public User ToUser() => _mapper.Map<User>(this);
}

public class UserUpdateDto(IMapper mapper)
{
    public IMapper _mapper = mapper;
    public required Guid UserId { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }

    public User ToUser() => _mapper.Map<User>(this);
}
