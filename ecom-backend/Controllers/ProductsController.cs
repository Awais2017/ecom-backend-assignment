using ecom_backend.Repository.Categories;
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
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult AddProduct([FromBody] AddUpdateProductResource addUpdateProductResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = productService.AddProduct(addUpdateProductResource);
            if (result.Status == 0)
            {
                return NotFound(result);
            }
            return Ok(result);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAllProducts()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = productService.GetAll();
            if (result.Status == 0)
            {
                return NotFound(result);
            }
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UplaodFile([FromForm] IFormFile file, [FromForm] string fileName)
        {
            if (file==null && file.Length==0)
            {
                return BadRequest(ModelState);
            }
            var result = productService.uploadFile(file,fileName);
            if (result.Status == 0)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
    }
}
