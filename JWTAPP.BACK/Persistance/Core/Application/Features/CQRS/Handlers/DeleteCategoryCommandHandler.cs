using AutoMapper;
using JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Commands;
using JWTAPP.BACK.Persistance.Core.Application.Interfaces;
using JWTAPP.BACK.Persistance.Core.Domain;
using MediatR;

namespace JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Handlers
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Category> _repository;

        public DeleteCategoryCommandHandler(IMapper mapper, IRepository<Category> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async  Task<Unit> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var deletedEntity = await _repository.GetByIdAsync(request.Id);
            if(deletedEntity != null)
            {
                await _repository.RemoveAsync(deletedEntity);   
                
            }
            return Unit.Value;
        }
    }
}
