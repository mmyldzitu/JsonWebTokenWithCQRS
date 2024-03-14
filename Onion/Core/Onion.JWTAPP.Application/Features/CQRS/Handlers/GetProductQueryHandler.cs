using AutoMapper;
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
    public class GetProductQueryHandler : IRequestHandler<GetProductQueryRequest, List<ProductListDto>>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;
        public GetProductQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public  async Task<List<ProductListDto>> Handle(GetProductQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();
            var mappedData = _mapper.Map<List<ProductListDto>>(data);
            return mappedData;
        }
    }
}
