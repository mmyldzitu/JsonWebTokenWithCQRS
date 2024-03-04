using JWTAPP.BACK.Persistance.Core.Application.Dto;
using MediatR;

namespace JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Queries
{
    public class GetCategoryByIdQueryRequest:IRequest<CategoryListDto>
    {
        public int Id { get; set; }

        public GetCategoryByIdQueryRequest(int ıd)
        {
            Id = ıd;
        }
    }
}
