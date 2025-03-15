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



    }

}