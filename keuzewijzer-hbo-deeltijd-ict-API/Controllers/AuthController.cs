using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using keuzewijzer_hbo_deeltijd_ict_API.Dal;
using keuzewijzer_hbo_deeltijd_ict_API.Models;

namespace keuzewijzer_hbo_deeltijd_ict_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] // voeg autorisatie toe aan de controller
    public class AuthController : ControllerBase
    {
        private readonly UserContext _context;

        public AuthController(UserContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        [AllowAnonymous] // voeg uitzondering toe voor aanmeldingsverzoeken
        public async Task<ActionResult<User>> Login(LoginRequest loginRequest)
        {
            // Zoek de gebruiker op in de database op basis van de gegeven gebruikersnaam
            var user = await _userManager.FindByNameAsync(loginRequest.Username);

            // Controleer of het wachtwoord niet overeenkomt met de opgeslagen hash
            if (user == null || !await _userManager.CheckPasswordAsync(user, loginRequest.Password))
            {
                // Als de gebruiker niet is gevonden of het wachtwoord onjuist is, retourneer dan een foutmelding
                return BadRequest(new { message = "Ongeldige gebruikersnaam of wachtwoord" });
            }

            // Aanmelden met SignInManager
            await _signInManager.SignInAsync(user, isPersistent: false);

            // Maak een JWT-token aan voor de gebruiker
            var token = JwtUtils.GenerateToken(user);

            // Retourneer de gebruikersgegevens en de token
            return Ok(new { user = user, token = token });
        }
    }
}
