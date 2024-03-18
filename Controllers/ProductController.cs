using CQRS_Skeleton.Application.Query;
using CQRS_Skeleton.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Skeleton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ProductDTO> GetProductAsync([FromQuery] GetProductsQuery query)
        {
            return await _mediator.Send(query);
        }
    }
}
