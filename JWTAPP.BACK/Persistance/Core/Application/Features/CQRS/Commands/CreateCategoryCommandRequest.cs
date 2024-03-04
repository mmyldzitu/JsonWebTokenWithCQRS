using MediatR;

namespace JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Commands
{
    public class CreateCategoryCommandRequest:IRequest
    {
        public string? Definition { get; set; }
    }
}
