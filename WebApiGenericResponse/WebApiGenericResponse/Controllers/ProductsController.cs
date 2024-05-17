using Microsoft.AspNetCore.Mvc;
using WebApiGenericResponse.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiGenericResponse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET api/<ProductsController>/5
        [HttpGet("{productType}")]
        public IActionResult Get(string productType)
        {
            if (productType.Equals("consumable"))
            {
                Consumable consumable = new();
                return Ok(new BaseProduct<Consumable>(consumable));
            }
            return Ok(new BaseProduct<Durable>(new Durable()));
        }
    }
}
