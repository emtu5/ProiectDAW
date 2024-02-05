using AutoMapper;
using RunnerApp.Data.DTOs;
using RunnerApp.Data.Models;

namespace RunnerApp.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
