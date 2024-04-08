using CQRS_Skeleton.Domain;

namespace CQRS_Skeleton.Repository
{
    public class ProductRepository : IProductRepository
    {
        /// <inheritdoc />
        public async Task<Product?> GetProductById(int id)
        {
            var products = await Task.Run(GetProducts);
            return products.FirstOrDefault(x => x.Id == id);
        }

        /// <inheritdoc />
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var products = await Task.Run(GetProducts);
            return products;
        }

        private List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new() { Id = 1, Description = "Product 1 Description", Name = "Product 1", Price = 100.28m },
                new() { Id = 2, Description = "Product 2 Description", Name = "Product 2", Price = 1208.99m }
            };

            return products;
        }
    }
}
