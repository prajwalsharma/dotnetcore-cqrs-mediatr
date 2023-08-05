using CQRSMediatRDemo.Features.Products.Abstractions;
using CQRSMediatRDemo.Features.Products.Commands;
using CQRSMediatRDemo.Features.Products.Models;
using Mapster;
using MediatR;

namespace CQRSMediatRDemo.Features.Products.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
    {
        private readonly IProductRepository _productRepository;

        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = request.Adapt<Product>();
            product.Id = Guid.NewGuid();
            return await _productRepository.CreateProductAsync(product);
        }
    }
}