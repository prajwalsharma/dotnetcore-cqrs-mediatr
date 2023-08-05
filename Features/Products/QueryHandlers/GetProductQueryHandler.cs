using CQRSMediatRDemo.Features.Products.Abstractions;
using CQRSMediatRDemo.Features.Products.Models;
using CQRSMediatRDemo.Features.Products.Queries;
using MediatR;

namespace CQRSMediatRDemo.Features.Products.QueryHandlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, Product>
    {
        private readonly IProductRepository _productRepository;

        public GetProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetProductAsync(request.Id);
        }
    }
}