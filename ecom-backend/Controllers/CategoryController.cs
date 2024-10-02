using ecom_backend.Repository.Categories;
using ecom_backend.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecom_backend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    [Authorize]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public IActionResult AddCategory([FromBody]CategoryResource categoryResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = categoryService.Add(categoryResource);
            if (result.Status==0)
            {
                 return NotFound(result);
            }
            return Ok(result);

        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public IActionResult UpdateCategory([FromBody] CategoryResource categoryResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = categoryService.Update(categoryResource);
            if (result.Status == 0)
            {
                return NotFound(result);
            }
            return Ok(result);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult DeleteCategory(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = categoryService.Delete(id);
            if (result.Status == 0)
            {
                return NotFound(result);
            }
            return Ok(result);

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult GetAllCategories()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = categoryService.getAll();
            if (result.Status == 0)
            {
                return NotFound(result);
            }
            return Ok(result);

        }


    }
}
