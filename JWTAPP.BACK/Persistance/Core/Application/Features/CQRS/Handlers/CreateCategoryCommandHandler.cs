using AutoMapper;
using JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Commands;
using JWTAPP.BACK.Persistance.Core.Application.Interfaces;
using JWTAPP.BACK.Persistance.Core.Domain;
using MediatR;

namespace JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Handlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Category> _repository;
        public CreateCategoryCommandHandler(IMapper mapper, IRepository<Category> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync( new Category { Definition=request.Definition } );
            return Unit.Value;
        }
    }
}
