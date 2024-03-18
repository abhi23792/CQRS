using AutoMapper;
using CQRS_Skeleton.Models;
using CQRS_Skeleton.Repository;
using MediatR;

namespace CQRS_Skeleton.Application.Query
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, ProductDTO>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public GetProductsQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<ProductDTO> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetProductById(request.Id);

            if (product == null)
            {
                throw new Exception("No product with the Id found");
            }

            var result = _mapper.Map<ProductDTO>(product);

            return result;
        }
    }
}
