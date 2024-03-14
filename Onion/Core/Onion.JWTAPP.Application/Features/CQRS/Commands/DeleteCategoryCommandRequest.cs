using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.JWTAPP.Application.Features.CQRS.Commands
{
    public class DeleteCategoryCommandRequest:IRequest
    {
        public int Id { get; set; }

        public DeleteCategoryCommandRequest(int ıd)
        {
            Id = ıd;
        }
    }
}
