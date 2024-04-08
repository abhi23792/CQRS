using CQRS_Skeleton.Models;
using MediatR;

namespace CQRS_Skeleton.Handlers.Product
{
    public class GetProductsByIdQuery : IRequest<ProductDTO>
    {
        public int Id { get; set; }
    }
}
