using AutoMapper;
using Onion.JWTAPP.Application.Dtos;
using Onion.JWTAPP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.JWTAPP.Application.Mappings
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            this.CreateMap<CategoryListDto, Category>().ReverseMap();
            
            this.CreateMap<CreatedCategoryDto, Category>().ReverseMap();
        }
    }
}
