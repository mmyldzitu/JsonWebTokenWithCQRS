using MediatR;
using Onion.JWTAPP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.JWTAPP.Application.Features.CQRS.Queries
{
    public class CheckUserQueryRequest:IRequest<CheckUserResponseDto?>
    {
        public string UserName { get; set; } = null!;
        public string PassWord { get; set; } = null!;
    }
}
