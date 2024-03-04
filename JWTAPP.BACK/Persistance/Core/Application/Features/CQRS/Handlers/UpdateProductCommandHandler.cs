using JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Commands;
using JWTAPP.BACK.Persistance.Core.Application.Interfaces;
using JWTAPP.BACK.Persistance.Core.Domain;
using MediatR;

namespace JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IRepository<Product> _repository;
        
        public UpdateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedEntity = await _repository.GetByIdAsync(request.Id);
            if(updatedEntity != null)
            {
                updatedEntity.Name = request.Name;
                updatedEntity.Price= request.Price;
                updatedEntity.Price = request.Price;
                updatedEntity.CategoryId= request.CategoryId;

                await _repository.UpdateAsync(updatedEntity);
            }
            return Unit.Value;
        }
    }
}
