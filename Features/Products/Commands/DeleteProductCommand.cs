using MediatR;

namespace CQRSMediatRDemo.Features.Products.Commands
{
    public class DeleteProductCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }
}