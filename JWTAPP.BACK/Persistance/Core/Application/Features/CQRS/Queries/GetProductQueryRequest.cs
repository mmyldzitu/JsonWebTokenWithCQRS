using JWTAPP.BACK.Persistance.Core.Application.Dto;
using MediatR;

namespace JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Queries
{
    public class GetProductQueryRequest:IRequest<ProductListDto>
    {
        public int Id { get; set; }

        public GetProductQueryRequest(int ıd)
        {
            Id = ıd;
        }
    }
}
