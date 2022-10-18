using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace CidadeAPI.Controllers
{
    [ApiController]
    [Route("/api/authentication")]
    public class AuthenticationController : ControllerBase
    {
        public class Login
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public class Usuario
        {
            public string Nome { get; set; }
            public string Papel { get; set; }
        }

        private readonly IConfiguration _configuration; 

        public AuthenticationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("authenticate")]
        public ActionResult<string> Authenticate(Login login)
        {
            var usuario = ValidarUsuario(login);

            if (usuario == null)
            {
                return Unauthorized();
            }

            var securityKey = new SymmetricSecurityKey(
                Encoding.ASCII.GetBytes(_configuration["Authentication:SecretForKey"]));
            var signingCredentials = new SigningCredentials(
                securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>();
            claims.Add(new Claim("sub", login.Username));
            claims.Add(new Claim("Nome", usuario.Nome));
            claims.Add(new Claim("Papel", usuario.Papel));

            var jwt = new JwtSecurityToken(
                _configuration["Authentication:Issuer"],
                _configuration["Authentication:Audience"],
                claims,
                DateTime.UtcNow,
                DateTime.UtcNow.AddHours(1),
                signingCredentials);

            var token = new JwtSecurityTokenHandler().WriteToken(jwt);

            return Ok(token);
        }

        private Usuario ValidarUsuario(Login login)
        {
            return new Usuario
            {
                Nome = "Usuario Teste",
                Papel = "Usuario"
            };
        }
    }
}
