using JWTAPP.BACK.Persistance.Core.Application.Dto;
using MediatR;

namespace JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Queries
{
    public class CheckUserQueryRequest : IRequest<CheckUserResponseDto>
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
