using MediatR;

namespace JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Commands
{
    public class UpdateCategoryCommandRequest:IRequest
    {
        public int Id { get; set; }
        public string? Definition { get; set; }
    }
}
