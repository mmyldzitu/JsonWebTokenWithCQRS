using AutoMapper;
using JWTAPP.BACK.Persistance.Core.Application.Dto;
using JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Queries;
using JWTAPP.BACK.Persistance.Core.Application.Interfaces;
using JWTAPP.BACK.Persistance.Core.Domain;
using MediatR;

namespace JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Handlers
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQueryRequest, CategoryListDto>
    {
        private readonly IRepository<Category> _repostiory;
        private readonly IMapper _mapper;

        public GetCategoryByIdQueryHandler(IRepository<Category> repostiory, IMapper mapper)
        {
            _repostiory = repostiory;
            _mapper = mapper;
        }

        public async Task<CategoryListDto> Handle(GetCategoryByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _repostiory.GetByIdAsync(request.Id);
            if (data != null)
            {
                var mappedData = _mapper.Map<CategoryListDto>(data);
                return mappedData;
            }
            return new CategoryListDto();
        }
    }
}
