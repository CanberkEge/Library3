using AutoMapper;
using Library3.Entity.Authentication;
using Library3.Entity.Concrete;
using Library3.WebMVC.Areas.Admin.Models.DTOs;

namespace Library3.WebMVC.Areas.Admin.AutoMapperProfile
{
    public class Library3Profile : Profile
    {
        public Library3Profile() 
        {
            CreateMap<BookCreateDTO, Book>();
            CreateMap<CategoryCreateDTO, Category>();
            CreateMap<UserCreateDTO, AppUser>();
            CreateMap<RoleCreateDTO, AppRole>();
        }

    }
}
