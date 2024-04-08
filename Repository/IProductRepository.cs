using CQRS_Skeleton.Domain;

namespace CQRS_Skeleton.Repository
{
    public interface IProductRepository
    {
        /// <summary>
        /// Gets the Product by Id.
        /// </summary>
        /// <param name="id">The Id of product.</param>
        /// <returns></returns>
        Task<Product?> GetProductById(int id);

        /// <summary>
        /// Get all Products.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Product>> GetAllProducts();
    }
}
