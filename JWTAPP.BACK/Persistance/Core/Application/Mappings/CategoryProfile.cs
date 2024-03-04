using AutoMapper;
using JWTAPP.BACK.Persistance.Core.Application.Dto;
using JWTAPP.BACK.Persistance.Core.Domain;

namespace JWTAPP.BACK.Persistance.Core.Application.Mappings
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            this.CreateMap<CategoryListDto, Category>().ReverseMap();  
        }
    }
}
