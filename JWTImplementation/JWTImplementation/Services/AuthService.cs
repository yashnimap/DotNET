using JWTImplementation.Context;
using JWTImplementation.Interfaces;
using JWTImplementation.Models;
using JWTImplementation.RequestModels;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace JWTImplementation.Services
{
    public class AuthService : IAuthService
    {
        private readonly JwtContext _jwtContext;
        private readonly IConfiguration _configuration;

        public AuthService(JwtContext jwtContext, IConfiguration configuration)
        {
            _jwtContext = jwtContext;
            _configuration = configuration;
        }

        public User AddUser(User user)
        {
            var addUser = _jwtContext.Add(user);
            _jwtContext.SaveChanges();
            return addUser.Entity;
        }

        public string Login(LoginRequest loginRequest)
        {
            if (loginRequest.UserName != null && loginRequest.Password != null)
            {
                var user = _jwtContext.Users.FirstOrDefault(s => s.Email == loginRequest.UserName && s.Password == loginRequest.Password);
                if (user != null)
                {
                    var claims = new[]{
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim("Id", user.Id.ToString()),
                        new Claim("UserName", user.Name),
                        new Claim("Email", user.Email)
                    };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        _configuration["Jwt:Issuer"],
                        _configuration["Jwt:Audience"],
                        claims,
                        expires: DateTime.UtcNow.AddMinutes(10),
                        signingCredentials: signIn);

                    var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
                    return jwtToken;
                }
                else
                {
                    throw new Exception("User is not valid");
                }
            }
            else
            {
                throw new Exception("Credentials are not valid");
            }
        }

        public string login(LoginRequest loginRequest)
        {
            throw new NotImplementedException();
        }
    }
}
