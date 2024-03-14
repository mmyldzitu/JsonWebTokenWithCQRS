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
    public class GetCategoryByIdHandler : IRequestHandler<GetCategoryByIdQueryRequest, CategoryListDto?>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public GetCategoryByIdHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CategoryListDto?> Handle(GetCategoryByIdQueryRequest request, CancellationToken cancellationToken)
        {
        var entity = await _repository.GetByIdAsync(request.Id);
            if(entity != null)
            {
                var mappedData= _mapper.Map<CategoryListDto?>(entity);   
                return mappedData;
            }
            return new CategoryListDto();
        }
    }
}
