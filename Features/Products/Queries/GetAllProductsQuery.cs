using CQRSMediatRDemo.Features.Products.Models;
using MediatR;

namespace CQRSMediatRDemo.Features.Products.Queries
{
    public class GetAllProductsQuery : IRequest<List<Product>>
    {
    }
}