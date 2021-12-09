using InteliTrader.Comum.Commands;
using InteliTrader.Dominio.Commands.Autenticação;
using InteliTrader.Dominio.Commands.Usuario;
using InteliTrader.Dominio.Entidades;
using InteliTrader.Dominio.Handlers.Autenticação;
using InteliTrader.Dominio.Handlers.Usuarios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.API.Controllers
{
    [Route("v1/account")]
    [Produces("application/json")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        public UsuariosController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        [Route("CadastroFuncionario")]
        [HttpPost]
        public GenericCommandResult SignUp([FromBody] CriarFuncionarioCommand command, [FromServices] CriarContaHandler handle)
        {
            return (GenericCommandResult)handle.Handler(command);
        }
        
        [Route("LoginFuncionario")]
        [HttpPost]
        public GenericCommandResult Signin(LogarCommand command, [FromServices] LogarHandle handler)
        {
            var resultado = (GenericCommandResult)handler.Handler(command);

            if (resultado.Sucesso)
            {
                var token = GenerateJSONWebToken((UsuarioLogin)resultado.Data);
                return new GenericCommandResult(resultado.Sucesso, resultado.Mensagem, new { Token = token });
            }
            return new GenericCommandResult(false, resultado.Mensagem, resultado.Data);
        }

        private string GenerateJSONWebToken(UsuarioLogin userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Intelitrader-chave-autenticacao-Funcionarios"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Definimos nossas Claims (dados da sessão) para poderem ser capturadas
            // a qualquer momento enquanto o Token for ativo
            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.FamilyName, userInfo.Nome),
                new Claim(JwtRegisteredClaimNames.Email, userInfo.Email),
                new Claim(ClaimTypes.Role, userInfo.TipoUsuario.ToString()),
                new Claim("role", userInfo.TipoUsuario.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, userInfo.Id.ToString())
            };

            // Configuramos nosso Token e seu tempo de vida
            var tokenUsuario = new JwtSecurityToken
                (
                    "InteliTrader",
                    "InteliTrader",
                    claims,
                    expires: DateTime.Now.AddMinutes(50),
                    signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(tokenUsuario);
        }

    }
}
