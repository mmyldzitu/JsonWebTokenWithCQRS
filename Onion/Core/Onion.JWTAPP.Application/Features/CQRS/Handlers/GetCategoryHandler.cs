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
    public class GetCategoryHandler : IRequestHandler<GetCategoryQueryRequest, List<CategoryListDto?>>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;
        public GetCategoryHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<CategoryListDto?>> Handle(GetCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var entities = await _repository.GetAllAsync();
            if(entities.Count != 0)
            {
                var mappedData= _mapper.Map<List<CategoryListDto?>>(entities);
                return mappedData;
            }
            return new List<CategoryListDto?>();
        }
    }
}
