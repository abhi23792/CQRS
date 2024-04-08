using CQRS_Skeleton.Handlers.Product;
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
        [Route("{id}")]
        public async Task<ProductDTO> GetProductsByIdAsync(int id)
        {
            var query = new GetProductsByIdQuery { Id = id };
            return await _mediator.Send(query);
        }

        [HttpGet]
        [Route("all")]
        public async Task<IEnumerable<ProductDTO>> GetAllProductsAsync()
        {
            var query = new GetProductsQuery();
            return await _mediator.Send(query);
        }
    }
}
