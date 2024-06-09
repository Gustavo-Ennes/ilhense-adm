using AutoMapper;
using Mercado.Application.Dtos;
using Mercado.Domain.Entities;
using Mercado.Shared.Utils.String;

namespace Mercado.Application.Mappings;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserCreateDto, User>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.Password, opt => opt.MapFrom(dto => dto.Password.ToHash()))
            .ForMember(dest => dest.CreationDate, opt => opt.MapFrom(dto => DateTime.UtcNow));
            
        CreateMap<UserUpdateDto, User>();
    }
}
