using CQRSMediatRDemo.Features.Products.Models;
using MediatR;

namespace CQRSMediatRDemo.Features.Products.Commands
{
    public class CreateProductCommand : IRequest<Product>
    {
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public int Quantity { get; set; }
    }
}