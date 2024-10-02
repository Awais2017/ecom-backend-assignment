using ecom_backend.Repository.Auth;
using ecom_backend.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecom_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SignIn([FromBody] AuthResource authResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            LoginResponse result = authService.GenerateToken(authResource);
            if (result == null) { return NotFound(); }
            return Ok(result);
        }

    }
}
