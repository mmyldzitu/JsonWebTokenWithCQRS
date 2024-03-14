using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion.JWTAPP.Application.Features.CQRS.Commands;
using Onion.JWTAPP.Application.Features.CQRS.Queries;

namespace Onion.JWTAPP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send( new GetCategoryQueryRequest() );
            return Ok( result );
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetCategoryByIdQueryRequest(id));
            if(result!=null)
            {
                return Ok(result);

            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryCommandRequest command)
        {
            var result =await _mediator.Send(command);
            return Created("", result);
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateCategoryCommandRequest request)
        {
            await _mediator.Send(request);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteCategoryCommandRequest(id));
            return NoContent();
        }
    }
}
