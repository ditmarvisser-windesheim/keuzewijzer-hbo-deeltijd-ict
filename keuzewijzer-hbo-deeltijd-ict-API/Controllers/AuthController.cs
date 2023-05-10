using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using keuzewijzer_hbo_deeltijd_ict_API.Dal;
using keuzewijzer_hbo_deeltijd_ict_API.Models;
using Microsoft.AspNetCore.Identity;
using keuzewijzer_hbo_deeltijd_ict_API.Request;
using keuzewijzer_hbo_deeltijd_ict_API.Utils;
using Microsoft.EntityFrameworkCore;

namespace keuzewijzer_hbo_deeltijd_ict_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] // voeg autorisatie toe aan de controller
    public class AuthController : ControllerBase
    {
        private readonly KeuzewijzerContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AuthController(KeuzewijzerContext context, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("login")]
        [AllowAnonymous] // voeg uitzondering toe voor aanmeldingsverzoeken
        public async Task<ActionResult<User>> Login(LoginRequest loginRequest)
        {
            // Zoek de gebruiker op in de database op basis van de gegeven gebruikersnaam
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.UserName == loginRequest.UserName);

            // Controleer of het wachtwoord niet overeenkomt met de opgeslagen hash
            if (user == null || !await _userManager.CheckPasswordAsync(user, loginRequest.Password))
            {
                // Als de gebruiker niet is gevonden of het wachtwoord onjuist is, retourneer dan een foutmelding
                return BadRequest(new { message = "Ongeldige gebruikersnaam of wachtwoord" });
            }

            // Maak een JWT-token aan voor de gebruiker
            var token = JwtUtils.GenerateToken(user);

            // Retourneer de gebruikersgegevens en de token
            return Ok(new { user = user, token = token });
        }
    }
}
