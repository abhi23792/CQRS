using CQRS_Skeleton.Models;
using MediatR;

namespace CQRS_Skeleton.Handlers.Product
{
    public class GetProductsQuery: IRequest<IEnumerable<ProductDTO>>
    {
    }
}
