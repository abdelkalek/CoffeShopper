using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeShopController : ControllerBase
    {

        public readonly ICofeeShopService _coffeeShopService;
        public CoffeeShopController(ICofeeShopService coffeeShopService)
        {
            _coffeeShopService = coffeeShopService; 

        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var cofeeList = await _coffeeShopService.List();
            return Ok(cofeeList);
        }
    }
}
