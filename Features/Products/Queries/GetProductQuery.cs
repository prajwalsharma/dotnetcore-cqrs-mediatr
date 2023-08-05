using CQRSMediatRDemo.Features.Products.Models;
using MediatR;

namespace CQRSMediatRDemo.Features.Products.Queries
{
    public class GetProductQuery : IRequest<Product>
    {
        public Guid Id { get; set; }
    }
}