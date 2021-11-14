using AutoMapper;
using IaunProject.Models;

namespace IaunProject.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterModel, User>();
        }
    }
}
