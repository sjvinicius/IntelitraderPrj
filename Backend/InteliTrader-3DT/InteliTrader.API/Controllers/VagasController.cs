using InteliTrader.Comum.Commands;
using InteliTrader.Dominio.Commands.Vaga;
using InteliTrader.Dominio.Handlers.Vagas;
using InteliTrader.Dominio.Querie.Vagas;
using InteliTrader.Dominio.Query.Vagas;
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
    public class VagasController : ControllerBase
    {
        [Route("CadastroVagas")]
        [HttpPost]
        public GenericCommandResult SignUp([FromBody] CriarVagaCommand command, [FromServices] CriarVagasHandler handle)
        {
            return (GenericCommandResult)handle.Handler(command);
        }

        [Route("AlterarVaga")]
        [HttpPatch]
        public GenericCommandResult Update(AlterarVagaCommand command, [FromServices] AlterarVagaHandler handle)
        {
            return (GenericCommandResult)handle.Handler(command);
        }

        [Route("DeletarVaga")]
        [HttpDelete]
        public GenericCommandResult Delete(DeletarVagaCommand command, [FromServices] DeletarVagaHandler handle)
        {
            return (GenericCommandResult)handle.Handler(command);
        }

        [Route("ListarVagas")]
        [HttpGet]
        public GenericQueryResult List([FromServices] ListarVagaHandler handle)
        {
            ListarVagaQuery query = new ListarVagaQuery();

            return (GenericQueryResult)handle.Handler(query);
        }
    }
}
