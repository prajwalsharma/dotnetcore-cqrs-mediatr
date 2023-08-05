using CQRSMediatRDemo.Features.Products.Abstractions;
using CQRSMediatRDemo.Features.Products.Models;
using CQRSMediatRDemo.Features.Products.Queries;
using MediatR;

namespace CQRSMediatRDemo.Features.Products.QueryHandlers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        private readonly IProductRepository _productRepository;

        public GetAllProductsQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetAllProductsAsync();
        }
    }
}