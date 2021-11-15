using LMS.Core.Repository;
using LMS.Core.Services;
using LMS.Data;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infra.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public string Authentiaction(Login login)
        {
            var result = userRepository.Authentiaction(login);
            if (result == null)
            {
                return null;
            }
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]");
                var tokenDescriptorData = new SecurityTokenDescriptor()
                {
                    Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Name, login.Username),
                    //new Claim(ClaimTypes., result.),
                }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptorData);
                return tokenHandler.WriteToken(token);
            }

        }

        public bool DeleteLogin(int loginId)
        {
            return userRepository.DeleteLogin(loginId);
        }

        public bool Register(Login login)
        {
            return userRepository.Register(login);
        }

        public List<Login> ReturnLogin()
        {
            return userRepository.ReturnLogin();
        }
    }

}
