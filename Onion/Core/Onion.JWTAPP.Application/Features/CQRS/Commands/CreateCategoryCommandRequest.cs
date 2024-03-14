using MediatR;
using Onion.JWTAPP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.JWTAPP.Application.Features.CQRS.Commands
{
    public class CreateCategoryCommandRequest:IRequest<CreatedCategoryDto?>
    {
        public string? Definition { get; set; }
    }
}
