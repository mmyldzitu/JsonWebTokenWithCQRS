using AutoMapper;
using JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Commands;
using JWTAPP.BACK.Persistance.Core.Application.Interfaces;
using JWTAPP.BACK.Persistance.Core.Domain;
using MediatR;

namespace JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Product> _repository;
        public DeleteProductCommandHandler(IMapper mapper, IRepository<Product> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var deletedEntity = await _repository.GetByIdAsync(request.Id);
            if(deletedEntity!= null)
            {
                await _repository.RemoveAsync(deletedEntity);

            }
            return Unit.Value;
        }
    }
}
