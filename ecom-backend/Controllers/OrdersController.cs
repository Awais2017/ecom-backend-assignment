using ecom_backend.Repository.Cart;
using ecom_backend.Repository.Products;
using ecom_backend.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecom_backend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class OrdersController : ControllerBase
    {
        private readonly ICartService cartService;

        public OrdersController(ICartService cartService)
        {
            this.cartService = cartService;
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult AddOrders([FromBody] List<AddOrderResouces> addOrders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = cartService.addOrders(addOrders);
            if (result.Status == 0)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
    }

}
