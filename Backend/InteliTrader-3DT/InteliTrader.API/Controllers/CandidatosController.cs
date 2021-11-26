using InteliTrader.Comum.Commands;
using InteliTrader.Dominio.Commands.Candidato;
using InteliTrader.Dominio.Handlers.Candidatos;
using InteliTrader.Dominio.Querie.Candidatos;
using InteliTrader.Shared.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteliTrader.API.Controllers
{
    [Route("v1/account")]
    [Produces("application/json")]
    [ApiController]
    public class CandidatosController : ControllerBase
    {
        [Route("registrar")]
        [HttpPost]
        public GenericCommandResult Register(CriarCandidatoCommand command, [FromServices] CriarCandidatoHandler handle)
        {
            return (GenericCommandResult)handle.Handler(command);
        }

        [Route("Listar")]
        [HttpGet]
        public GenericQueryResult List([FromServices] ListarCandidatoHandler handle)
        {
            ListarCandidatoQuery query = new ListarCandidatoQuery();

            return (GenericQueryResult)handle.Handler(query);
        }
    }
}
