using AutoMapper;
using INNO.Domain.Entities.Organizations;
using INNO.Domain.Entities.Users;
using INNO.Service.DTOs.Organizations;
using INNO.Service.DTOs.PastExperiences;
using INNO.Service.DTOs.Startups;
using INNO.Service.DTOs.Users;

namespace INNO.Service.Mappers;
public class MappingProfile : Profile
{
    public MappingProfile() 
    {
        CreateMap<User, UserForCreationDTO>().ReverseMap();
        CreateMap<User, UserForUpdateDTO>().ReverseMap();
        CreateMap<User, UserForViewDTO>().ReverseMap();

        CreateMap<OwnerStartup, StartupForCreationDTO>().ReverseMap();
        CreateMap<OwnerStartup, StartupForUpdateDTO>().ReverseMap();
        CreateMap<OwnerStartup, StartupForViewDTO>().ReverseMap();

        CreateMap<PastExperience, PastExperienceForCreationDTO>().ReverseMap();
        CreateMap<PastExperience, PastExperienceForUpdateDTO>().ReverseMap();
        CreateMap<PastExperience, PastExperienceForViewDTO>().ReverseMap();

        CreateMap<Organization, OrganizationForCreationDTO>().ReverseMap();
        CreateMap<Organization, OrganizationForViewDTO>().ReverseMap();
        CreateMap<Organization, OrganizationForUpdateDTO>().ReverseMap();
    }


}
