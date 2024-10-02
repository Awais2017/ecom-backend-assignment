using ecom_backend.Data;
using ecom_backend.Resources;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ecom_backend.Repository.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration configuration;

        public AuthService( IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public LoginResponse GenerateToken(AuthResource authResource)
        {
            
            var user = UsersStore.UsersList.Find(u => u.Email.ToLower() == authResource.Email.ToLower() && u.RoleId==authResource.Role);
            if (user == null)
            {
                return null;
            }
            var role = RolesStore.RolesList.Find(x => x.Id == user.RoleId);
            if(BCrypt.Net.BCrypt.Verify(authResource.Password, user.Password))
            {
                var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, configuration["Jwt:Subject"]),
                new Claim("Id", user.Id.ToString()),
                new Claim("UserName", user.Name),
                new Claim("Email", user.Email),
                new Claim("Role",role.Name)
            };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    configuration["Jwt:Issuer"],
                    configuration["Jwt:Audience"],
                    claims,
                    expires: DateTime.UtcNow.AddMinutes(30),
                    signingCredentials: signIn);

                var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
                LoginResponse response= new LoginResponse();
                response.Name=user.Name;
                response.Email=user.Email;
                response.Role = role.Name;
                response.Token= jwtToken;
                return response;
            }
            return null;
        }
    }
}
