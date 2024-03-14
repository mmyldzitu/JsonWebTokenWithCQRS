using AutoMapper;
using MediatR;
using Onion.JWTAPP.Application.Dtos;
using Onion.JWTAPP.Application.Features.CQRS.Commands;
using Onion.JWTAPP.Application.Interfaces;
using Onion.JWTAPP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.JWTAPP.Application.Features.CQRS.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreatedProductDto?>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;
        public CreateProductCommandHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        async Task<CreatedProductDto?> IRequestHandler<CreateProductCommandRequest, CreatedProductDto?>.Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var newProduct = new Product { Name=request.Name, Stock=request.Stock, Price=request.Price, CategoryId=request.CategoryId };
            await _repository.CreateAsync(newProduct);
            var mappedProduct = _mapper.Map<CreatedProductDto>(newProduct);

            return mappedProduct;
        }
    }
}
