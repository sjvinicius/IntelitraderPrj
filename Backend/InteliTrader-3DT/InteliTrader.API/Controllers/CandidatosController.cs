using InteliTrader.Comum.Commands;
using InteliTrader.Dominio.Commands.Autenticação;
using InteliTrader.Dominio.Commands.Candidato;
using InteliTrader.Dominio.Entidades;
using InteliTrader.Dominio.Handlers.Autenticação;
using InteliTrader.Dominio.Handlers.Candidatos;
using InteliTrader.Dominio.Querie.Candidatos;
using InteliTrader.Shared.Queries;
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
    public class CandidatosController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        public CandidatosController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        [Route("CadastroCandidato")]
        [HttpPost]
        public GenericCommandResult SignUp([FromBody] CadastroCandidatoCommand command, [FromServices] CriarContaCandidatoHandler handle)
        {
            return (GenericCommandResult)handle.Handler(command);
        }
        [Route("LoginCandidato")]
        [HttpPost]
        public GenericCommandResult Signin(LogarCandidatoCommand command, [FromServices] LogarCandidatoHandler handler)
        {
            var resultado = (GenericCommandResult)handler.Handler(command);

            if (resultado.Sucesso)
            {
                var token = GenerateJSONWebToken((Candidato)resultado.Data);
                return new GenericCommandResult(resultado.Sucesso, resultado.Mensagem, new { Token = token });
            }
            return new GenericCommandResult(false, resultado.Mensagem, resultado.Data);
        }

        [Route("ListarCandidatos")]
        [HttpGet]
        public GenericQueryResult List([FromServices] ListarCandidatoHandler handle)
        {
            ListarCandidatoQuery query = new ListarCandidatoQuery();

            return (GenericQueryResult)handle.Handler(query);
        }

        private string GenerateJSONWebToken(Candidato userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Intelitrader-chave-autenticacao-Candidatos"));
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
            var token = new JwtSecurityToken
                (
                    "InteliTrader",
                    "InteliTrader",
                    claims,
                    expires: DateTime.Now.AddMinutes(50),
                    signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
