using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using keuzewijzer_hbo_deeltijd_ict_API.Models;
using keuzewijzer_hbo_deeltijd_ict_API.Request;
using keuzewijzer_hbo_deeltijd_ict_API.ViewModels;
using keuzewijzer_hbo_deeltijd_ict_API.Controllers.ActionFilters;
using Microsoft.Extensions.Caching.Memory;

namespace keuzewijzer_hbo_deeltijd_ict_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        [HttpPost("login")]
        // Limit login tries to 5 times per minute
        [RateLimitFilter(5, 60)]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.UserName);
            
            if (user == null)
            {
                return Unauthorized();
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
            if (!result.Succeeded)
            {
                return Unauthorized();
            }

            var userRoles = await _userManager.GetRolesAsync(user);

            var accessToken = GenerateAccessToken(user, userRoles);

            return Ok(new AuthenticationResponse(
                user.UserName,
                user.Email,
                accessToken,
                accessToken,
                DateTime.Now
            ));
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }

        private string GenerateAccessToken(User user, IList<string> roles)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Secret"]);

            var roleClaims = new List<Claim>();

            foreach (var role in roles)
            {
                roleClaims.Add(new Claim(ClaimTypes.Role, role));
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id),
                    new Claim(ClaimTypes.Email, user.Email)
                }.Concat(roleClaims)),

                Expires = DateTime.UtcNow.AddHours(Convert.ToDouble(_configuration["Jwt:ExpireHours"])),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}