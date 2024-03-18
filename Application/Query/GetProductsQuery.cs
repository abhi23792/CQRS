using CQRS_Skeleton.Models;
using MediatR;

namespace CQRS_Skeleton.Application.Query
{
    public class GetProductsQuery: IRequest<ProductDTO>
    {
        public int Id { get; set; }
    }
}
