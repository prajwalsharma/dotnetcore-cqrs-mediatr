using CQRSMediatRDemo.Features.Products.Models;

namespace CQRSMediatRDemo.Features.Products.Abstractions
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProductsAsync();

        Task<Product> GetProductAsync(Guid productId);

        Task<Product> CreateProductAsync(Product product);

        Task<Guid> DeleteProductAsync(Product product);

        Task<Guid> UpdateProductAsync(Product product);
    }
}