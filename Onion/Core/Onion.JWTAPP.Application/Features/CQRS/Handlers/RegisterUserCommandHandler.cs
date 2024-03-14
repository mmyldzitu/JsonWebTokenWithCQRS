using AutoMapper;
using MediatR;
using Onion.JWTAPP.Application.Dtos;
using Onion.JWTAPP.Application.Enums;
using Onion.JWTAPP.Application.Features.CQRS.Commands;
using Onion.JWTAPP.Application.Interfaces;
using Onion.JWTAPP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.JWTAPP.Application.Features.CQRS.Handlers
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommandRequest, CreatedUserDto?>
    {
        private readonly IRepository<AppUser> _repository;
        private readonly IMapper _mapper;
        public RegisterUserCommandHandler(IRepository<AppUser> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async  Task<CreatedUserDto?> Handle(RegisterUserCommandRequest request, CancellationToken cancellationToken)
        {
           var user = new AppUser { Username=request.UserName, Password=request.Password, AppRoleId=(int)RoleType.Member };
            await _repository.CreateAsync(user);
            var mappedUser = _mapper.Map<CreatedUserDto>(user);    
            return mappedUser;
        }
    }
}
