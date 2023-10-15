using AutoMapper;
using Library3.Entity.Authentication;
using Library3.WebMVC.Models.DTO_s;

namespace Library3.WebMVC.AutoMapperProfile
{
    public class Library3Profile : Profile
    {

        public Library3Profile() 
        {
            CreateMap<LoginDTO, AppUser>();
            CreateMap<RegisterDTO, AppUser>();
        }

    }
}
