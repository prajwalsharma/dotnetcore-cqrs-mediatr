using CQRSMediatRDemo.Features.Products.Abstractions;
using CQRSMediatRDemo.Features.Products.Commands;
using MediatR;

namespace CQRSMediatRDemo.Features.Products.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Guid>
    {
        private readonly IProductRepository _productRepository;

        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Guid> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetProductAsync(request.Id);
            return await _productRepository.DeleteProductAsync(product);
        }
    }
}