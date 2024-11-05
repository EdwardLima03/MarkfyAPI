using IdentityModel.Client;
using Microsoft.AspNetCore.Mvc;


namespace Markfy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public AuthController(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var client = _httpClientFactory.CreateClient();

            var tokenResponse = await client.RequestPasswordTokenAsync(new PasswordTokenRequest
            {
                Address = $"https://{_configuration["Auth0:Domain"]}/oauth/token",
                ClientId = _configuration["Auth0:ClientId"],
                ClientSecret = _configuration["Auth0:ClientSecret"],
                Scope = "openid profile",
                UserName = request.Username,
                Password = request.Password,
            });

            if (tokenResponse.IsError)
            {
                return BadRequest(new { error = tokenResponse.Error, error_description = tokenResponse.ErrorDescription });
            }

            return Ok(tokenResponse.Json);
        }

    }
}

public class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}
