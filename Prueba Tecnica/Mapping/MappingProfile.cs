using AutoMapper;
using PruebaTecnica.Dto;
using PruebaTecnica.Models;


namespace PruebaTecnica.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {

            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UpdateUserDto, User>().ReverseMap();

        }

    }
}
