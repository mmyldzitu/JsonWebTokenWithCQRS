using MediatR;
using Onion.JWTAPP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.JWTAPP.Application.Features.CQRS.Commands
{
    public class RegisterUserCommandRequest:IRequest<CreatedUserDto?>
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;  
    }
}
