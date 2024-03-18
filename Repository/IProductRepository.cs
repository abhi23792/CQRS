using CQRS_Skeleton.Domain;

namespace CQRS_Skeleton.Repository
{
    public interface IProductRepository
    {
        /// <summary>
        /// Gets all the products.
        /// </summary>
        /// <param name="id">The Id of product.</param>
        /// <returns></returns>
        Task<Product?> GetProductById(int id);
    }
}
