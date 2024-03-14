using AutoMapper;
using MediatR;
using Onion.JWTAPP.Application.Dtos;
using Onion.JWTAPP.Application.Features.CQRS.Commands;
using Onion.JWTAPP.Application.Interfaces;
using Onion.JWTAPP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Onion.JWTAPP.Application.Features.CQRS.Handlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest,CreatedCategoryDto?>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;
        public CreateCategoryCommandHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }



        async Task<CreatedCategoryDto?> IRequestHandler<CreateCategoryCommandRequest, CreatedCategoryDto?>.Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {

            var category = new Category {Definition=request.Definition };
            await _repository.CreateAsync(category);
            var categoryDto =  _mapper.Map<CreatedCategoryDto>(category);
            return categoryDto;
        }
    }
}
