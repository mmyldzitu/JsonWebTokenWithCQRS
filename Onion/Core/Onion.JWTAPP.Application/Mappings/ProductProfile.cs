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
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            this.CreateMap<ProductListDto,Product>().ReverseMap();
            this.CreateMap<CreatedProductDto,Product>().ReverseMap();
        }
    }
}
