using CQRSMediatRDemo.Data;
using CQRSMediatRDemo.Features.Products.Abstractions;
using CQRSMediatRDemo.Features.Products.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSMediatRDemo.Features.Products.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbContextClass _dbContext;

        public ProductRepository(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }

        public async Task<Guid> DeleteProductAsync(Product product)
        {
            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();
            return product.Id;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            var products = await _dbContext.Products.ToListAsync<Product>();
            return products;
        }

        public async Task<Product> GetProductAsync(Guid productId)
        {
            return await _dbContext.Products
                .Where(product => product.Id == productId)
                .FirstAsync();
        }

        public async Task<Guid> UpdateProductAsync(Product product)
        {
            _dbContext.Products.Update(product);
            await _dbContext.SaveChangesAsync();
            return product.Id;
        }
    }
}