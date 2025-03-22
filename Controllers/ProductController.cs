using CqrsMediatR.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsMediatR.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ISender _sender;

        public ProductController(ISender sender) => _sender = sender;


        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            var products = await _sender.Send(new GetProductsQuery());
            return Ok(products);
        }

        [HttpGet("{id:int}", Name = "GetProductById")]
        public async Task<ActionResult> GetProductById(int id)
        {
            var product = await _sender.Send(new GetProductByIdQuery(id));
            return Ok(product);

        }


    }

}
