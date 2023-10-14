using AutoMapper;
using Library3.Entity.Authentication;
using Library3.Entity.Concrete;
using Library3.WebMVC.Areas.Member.Models.DTOs;

namespace Library3.WebMVC.Areas.Member.AutoMapperProfile
{
    public class Library3Profile : Profile
    {

        public Library3Profile() 
        {
            CreateMap<CartDTO, Book>();
            CreateMap<CartDTO, AppUser>();
            CreateMap<CartDTO, Cart>();
        }

    }
}
