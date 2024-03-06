using JWTAPP.BACK.Persistance.Core.Application.Dto;
using JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Queries;
using JWTAPP.BACK.Persistance.Core.Application.Interfaces;
using JWTAPP.BACK.Persistance.Core.Domain;
using MediatR;

namespace JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Handlers
{
    public class CheckUserRequestHandler : IRequestHandler<CheckUserQueryRequest, CheckUserResponseDto>
    {
        private readonly IRepository<AppUser> _repository;
        private readonly IRepository<AppRole> _roleRepository;
        public CheckUserRequestHandler(IRepository<AppUser> repository, IRepository<AppRole> roleRepository)
        {
            _repository = repository;
            _roleRepository = roleRepository;
        }

        public async  Task<CheckUserResponseDto> Handle(CheckUserQueryRequest request, CancellationToken cancellationToken)
        {
            var dto = new CheckUserResponseDto();
            var user =  await _repository.GetByFilter(x=>x.Username== request.Username && x.Password==request.Password);
            if(user == null)
            {
                dto.IsExist=false;
            }
            else
            {
                dto.UserName=user.Username;
                dto.Id=user.Id;
                var role = await _roleRepository.GetByFilter(x => x.Id == user.AppRoleId);
                dto.Role = role?.Definition;

                dto.IsExist = true;
            }
            return dto;
        }
    }
}
