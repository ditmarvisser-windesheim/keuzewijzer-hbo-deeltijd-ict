using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using keuzewijzer_hbo_deeltijd_ict_API.Models;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;

//TODO: change this to other namespace
namespace keuzewijzer_hbo_deeltijd_ict_API.Utils
{
    public static class JwtUtils
    {
        public static string GenerateToken(User user)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Name),
            };

            var key = new byte[32];
            using (var generator = RandomNumberGenerator.Create())
            {
                generator.GetBytes(key);
            }
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
}
