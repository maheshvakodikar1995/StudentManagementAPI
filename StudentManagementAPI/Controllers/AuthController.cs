using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Helpers;

namespace StudentManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        #region Fields
        private readonly IConfiguration _configuration;
        #endregion

        #region Ctor
        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        #region Methods
        [HttpPost("login")]
        public IActionResult Login()
        {
            var token = JwtHelper.GenerateToken(
                _configuration["Jwt:Key"],
                _configuration["Jwt:Issuer"]);

            return Ok(new { token });
        }
        #endregion
    }
}
