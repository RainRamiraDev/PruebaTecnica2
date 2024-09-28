using AutoMapper;
using PruebaTecnica.Dto;
using PruebaTecnica.Models;


namespace PruebaTecnica.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {

            //CreateMap<User, UserDto>().ReverseMap();
            //CreateMap<UserDbReadDto, User>().ReverseMap();

            CreateMap<User, UserDbReadDto>().ReverseMap();
            CreateMap<UserDbAlterDto, User>().ReverseMap();
            CreateMap<UserDbAlterDto, UserDbReadDto>().ReverseMap();

        }

    }
}
