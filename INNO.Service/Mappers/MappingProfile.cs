using AutoMapper;
using INNO.Domain.Entities.Users;
using INNO.Service.DTOs.Users;

namespace INNO.Service.Mappers;
public class MappingProfile : Profile
{
    public MappingProfile() 
    { 
        CreateMap<User,UserForCreationDTO>
    }


}
