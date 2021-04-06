using CoreAuth.Model;
using CoreAuth.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CoreAuth.Repository.Services
{
    public class AccountService : IAccountService
    {
        private IConfiguration _config;
        public AccountService(IConfiguration config)
        {
            _config = config;
        }
        public bool SignIn(UserModel user)
        {
            throw new NotImplementedException();
        }

        public UserInfoModel AuthenticateUser(UserModel userModel)
        {
            UserInfoModel result = null;
            if (userModel.UserName == "fide" && userModel.Password == "123")
            {
                result = new UserInfoModel { UserName = "Fide", Password = "123", Role = "Administrator", MinuteExpirated = 60, EmailAddress = "email@mail.com" };
            }
            return result;
        }

        public string GenerateJSONWebToken(UserInfoModel userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userInfo.UserName),
                new Claim(JwtRegisteredClaimNames.Email, userInfo.EmailAddress),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim("role", userInfo.Role)
            };

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(userInfo.MinuteExpirated),
                signingCredentials: credentials);
            var encodetoken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodetoken;
        }
    }
}
