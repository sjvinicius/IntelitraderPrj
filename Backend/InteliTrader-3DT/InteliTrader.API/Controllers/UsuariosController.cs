using InteliTrader.Comum.Commands;
using InteliTrader.Dominio.Commands.Autenticação;
using InteliTrader.Dominio.Commands.Usuario;
using InteliTrader.Dominio.Entidades;
using InteliTrader.Dominio.Handlers.Autenticação;
using InteliTrader.Dominio.Handlers.Usuarios;
using InteliTrader.Shared.Utils;
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
        [Route("Cadastro")]
        [HttpPost]
        public GenericCommandResult SignUp([FromBody] CriarContaCommand command, [FromServices] CriarContaHandler handle)
        {
            return (GenericCommandResult)handle.Handler(command);
        }
        
        [Route("Login")]
        [HttpPost]
        public GenericCommandResult SignIn([FromBody]LogarCommand command, [FromServices] LogarHandle handle)
        {
            var resultado = (GenericCommandResult)handle.Handler(command);

            if (resultado.Sucesso)
            {
                Usuario usuario = (Usuario)resultado.Data;
                var token = new Token(
                                        Configuration["Token:issuer"],
                                        Configuration["Token:audience"],
                                        Configuration["Token:secretKey"]
                                     )
                                    .GerarJsonWebToken(
                                        usuario.Id,
                                        usuario.Nome,
                                        usuario.Email,
                                        usuario.TipoUsuario.ToString()                    
                                     );
                return new GenericCommandResult(true, "Usuario Logado", new { token = token });
            }
            return resultado;
        }

    }
}
