using CQRSMediatRDemo.Features.Products.Abstractions;
using CQRSMediatRDemo.Features.Products.Commands;
using CQRSMediatRDemo.Features.Products.Models;
using Mapster;
using MediatR;

namespace CQRSMediatRDemo.Features.Products.CommandHandlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Guid>
    {
        private readonly IProductRepository _productRepository;

        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Guid> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = request.Adapt<Product>();
            return await _productRepository.UpdateProductAsync(product);
        }
    }
}