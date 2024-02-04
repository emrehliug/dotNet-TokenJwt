using APIJwtGenerator.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace APIJwtGenerator.Controllers
{
    [ApiController]
    [Route("api/")]
    public class TokenController : Controller
    {
        private IConfiguration configuration;
        public TokenController(IConfiguration config)
        {
            configuration = config;     
        }

        [HttpPost]
        [Route("login/")]
        public IActionResult Login([FromBody] Usuario user)
        {
            if(user.NomeUsuario == "Guilherme" && user.Senha == 1234)
            {
                return Ok(GetTokenJWT());
            }
            else
            {
                return Unauthorized();
            }
        }

        [NonAction]
        public string GetTokenJWT()
        {
            var issuer = configuration["Jwt:Issuer"];
            var audience = configuration["Jwt:Audience"];
            var expirationDate = DateTime.Now.AddDays(1);
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(issuer: issuer, audience: audience, expires: expirationDate, signingCredentials: cred);

            var tokenHandler = new JwtSecurityTokenHandler();
            var stringToken = tokenHandler.WriteToken(token);
            return string.Format("token: {0}\ndata-expiracao: {1}",stringToken, expirationDate);

        }
    }
}
