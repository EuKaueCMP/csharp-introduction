using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using _27_09_2026__API_Banco.Domains;
using Microsoft.IdentityModel.Tokens;

namespace _27_09_2026__API_Banco
{
    public class TokenJWT
    {
        private readonly IConfiguration _config;

        public TokenJWT(IConfiguration config) => _config = config;

        public string GerarToken(usuario usuario)
        {
            var chave = Environment.GetEnvironmentVariable("JWT_KEY");
            if (string.IsNullOrWhiteSpace(chave))
                throw new DomainException("JWT_KEY não configurada");

            var issuer = _config["Jwt:Issuer"]!;
            var audience = _config["Jwt:Audience"]!;
            var ExpirationTime = int.Parse(_config["JWt:ExpirationTime"]!);

            var keyBytes = Encoding.UTF8.GetBytes(chave);
            if (keyBytes.Length < 32)
                throw new DomainException("Jwt: Key precisa ter no minimo 32 caracteres");

            var securityKey = new SymmetricSecurityKey(keyBytes);
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, usuario.usuario_id.ToString()),
                new Claim(ClaimTypes.Name, usuario.nome),
                new Claim(ClaimTypes.Email, usuario.email),
                new Claim(ClaimTypes.Role, usuario.tipo_usuario.tipo)
            };

            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(ExpirationTime),
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}