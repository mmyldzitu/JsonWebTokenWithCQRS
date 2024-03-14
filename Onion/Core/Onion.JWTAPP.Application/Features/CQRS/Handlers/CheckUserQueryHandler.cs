using MediatR;
using Onion.JWTAPP.Application.Dtos;
using Onion.JWTAPP.Application.Features.CQRS.Queries;
using Onion.JWTAPP.Application.Interfaces;
using Onion.JWTAPP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.JWTAPP.Application.Features.CQRS.Handlers
{
    public class CheckUserQueryHandler : IRequestHandler<CheckUserQueryRequest, CheckUserResponseDto?>
    {
        private readonly IRepository<AppUser> _userRepository;
        private readonly IRepository<AppRole> _roleRepository;

        public CheckUserQueryHandler(IRepository<AppUser> userRepository, IRepository<AppRole> roleRepository)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }

        public async Task<CheckUserResponseDto?> Handle(CheckUserQueryRequest request, CancellationToken cancellationToken)
        {
            var dto = new CheckUserResponseDto();
            var user = await _userRepository.GetByFilterAsync(x => x.Username == request.UserName && x.Password == request.PassWord);
            if(user == null)
            {
                dto.IsExist=false;
            }
            else
            {
                dto.IsExist=true;
                dto.UserName = user.Username;
                dto.Role = (await _roleRepository.GetByFilterAsync(x => x.Id == user.AppRoleId))?.Definition;
                dto.Id = user.Id;
            }
            return dto;
        }
    }
}
