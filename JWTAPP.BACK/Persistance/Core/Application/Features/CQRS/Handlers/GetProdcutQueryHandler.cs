using AutoMapper;
using JWTAPP.BACK.Persistance.Core.Application.Dto;
using JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Queries;
using JWTAPP.BACK.Persistance.Core.Application.Interfaces;
using JWTAPP.BACK.Persistance.Core.Domain;
using MediatR;

namespace JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Handlers
{
    public class GetProdcutQueryHandler : IRequestHandler<GetProductQueryRequest, ProductListDto>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public GetProdcutQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ProductListDto> Handle(GetProductQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.Id);
            var mappedData = _mapper.Map<ProductListDto>(data);
            return mappedData;
        }
    }
}
