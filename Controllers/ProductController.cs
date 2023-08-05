using CQRSMediatRDemo.Features.Products.Commands;
using CQRSMediatRDemo.Features.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSMediatRDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediatr;

        public ProductController(IMediator mediator)
        {
            _mediatr = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _mediatr.Send(new GetAllProductsQuery());
            return Ok(products);
        }

        [HttpGet("{productId:guid}")]
        public async Task<IActionResult> GetProduct(Guid productId)
        {
            var product = await _mediatr.Send(new GetProductQuery() { Id = productId });
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductCommand product)
        {
            var createdProduct = await _mediatr.Send(product);
            return Ok(createdProduct);
        }

        [HttpDelete("{productId:guid}")]
        public async Task<IActionResult> DeleteProduct(Guid productId)
        {
            var deletedProduct = await _mediatr.Send(new DeleteProductCommand() { Id = productId });
            return Ok(deletedProduct);
        }

        [HttpPut("{productId:guid}")]
        public async Task<IActionResult> UpdateProduct(Guid productId, [FromBody] UpdateProductCommand product)
        {
            if (productId != product.Id)
            {
                return BadRequest();
            }
            var updatedProduct = await _mediatr.Send(product);
            return Ok(updatedProduct);
        }
    }
}