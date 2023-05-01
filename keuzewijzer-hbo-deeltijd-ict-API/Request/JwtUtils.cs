using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using keuzewijzer_hbo_deeltijd_ict_API.Models;
using Microsoft.IdentityModel.Tokens;

//TODO: change this to other namespace
namespace keuzewijzer_hbo_deeltijd_ict_API.Request;


    public static class JwtUtils
    {
        public static string GenerateToken(User user)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Name),
                // Voeg extra claims toe indien nodig
            };

            var key = Encoding.UTF8.GetBytes("YourSecretKey"); // Vervang door je eigen geheime sleutel

            var securityKey = new SymmetricSecurityKey(key);
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var tokenOptions = new JwtSecurityToken(
                issuer: "Issuer",
                audience: "Audience",
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(30),
                signingCredentials: credentials
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return tokenString;
        }
    }
