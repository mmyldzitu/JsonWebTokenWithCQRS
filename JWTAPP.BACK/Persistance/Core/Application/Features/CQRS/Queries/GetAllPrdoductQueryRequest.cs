﻿using JWTAPP.BACK.Persistance.Core.Application.Dto;
using MediatR;

namespace JWTAPP.BACK.Persistance.Core.Application.Features.CQRS.Queries
{
    public class GetAllPrdoductQueryRequest:IRequest<List<ProductListDto>>
    {
    }
}
