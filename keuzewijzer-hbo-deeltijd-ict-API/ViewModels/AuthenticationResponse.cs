﻿namespace keuzewijzer_hbo_deeltijd_ict_API.ViewModels
{
    public class AuthenticationResponse
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiration { get; set; }

        public AuthenticationResponse(string userName, string email, string token, string refreshToken, DateTime? refreshTokenExpiration)
        {
            UserName = userName;
            Email = email;
            Token = token;
            RefreshToken = refreshToken;
            RefreshTokenExpiration = (DateTime)refreshTokenExpiration;
        }
    }
}