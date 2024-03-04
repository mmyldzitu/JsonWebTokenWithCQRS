using AutoMapper;
using JWTAPP.BACK.Persistance.Core.Application.Dto;
using JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Queries;
using JWTAPP.BACK.Persistance.Core.Application.Interfaces;
using JWTAPP.BACK.Persistance.Core.Domain;
using MediatR;

namespace JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Handlers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllPrdoductQueryRequest, List<ProductListDto>>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public GetAllProductsQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ProductListDto>> Handle(GetAllPrdoductQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();
            var mappedData = _mapper.Map<List<ProductListDto>>(data);
            return mappedData;
        }
    }
}
