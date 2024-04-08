using AutoMapper;
using CQRS_Skeleton.Models;
using CQRS_Skeleton.Repository;
using MediatR;

namespace CQRS_Skeleton.Handlers.Product
{
    public class GetProductsQueryHandler: IRequestHandler<GetProductsQuery, IEnumerable<ProductDTO>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public GetProductsQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProductDTO>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllProducts();

            if (products == null || !products.Any())
            {
                throw new Exception("No products found");
            }

            var result = _mapper.Map<IEnumerable<ProductDTO>>(products);

            return result;
        }
    }
}
