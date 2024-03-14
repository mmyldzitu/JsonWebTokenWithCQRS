using MediatR;
using Onion.JWTAPP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.JWTAPP.Application.Features.CQRS.Queries
{
    public class GetCategoryByIdQueryRequest:IRequest<CategoryListDto?>
    {
        public int Id { get; set; }

        public GetCategoryByIdQueryRequest(int ıd)
        {
            Id = ıd;
        }
    }
}
