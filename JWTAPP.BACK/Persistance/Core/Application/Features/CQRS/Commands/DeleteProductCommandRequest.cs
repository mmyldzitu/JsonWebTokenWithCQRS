using MediatR;

namespace JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Commands
{
    public class DeleteProductCommandRequest:IRequest
    {
        public int Id { get; set; }

        public DeleteProductCommandRequest(int ıd)
        {
            Id = ıd;
        }
    }
}
