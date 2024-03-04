using AutoMapper;
using JWTAPP.BACK.Persistance.Core.Application.Dto;
using JWTAPP.BACK.Persistance.Core.Domain;

namespace JWTAPP.BACK.Persistance.Core.Application.Mappings
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            this.CreateMap<Product, ProductListDto>().ReverseMap();   
        }
    }
}
