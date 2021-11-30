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
        [Route("registraVaga")]
        [HttpPost]
        public GenericCommandResult Register(CriarVagaCommand command, [FromServices] CriarVagasHandler handle)
        {
            return (GenericCommandResult)handle.Handler(command);
        }

        [Route("update")]
        [HttpPatch]
        public GenericCommandResult Update(AlterarVagaCommand command, [FromServices] AlterarVagaHandler handle)
        {
            return (GenericCommandResult)handle.Handler(command);
        }

        [Route("delete")]
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

        [Route("ProcurarPorNome")]
        [HttpGet]
        public GenericQueryResult SearchByName(string jobName, [FromServices] BuscarPorNomeVagaHandler handle)
        {

            var query = new BuscarPorNomeVagaQuery
            {
                NomeVaga = jobName
            };

            return (GenericQueryResult)handle.Handler(query);
        }

        [Route("ProcuraPorId")]
        [HttpGet]
         public GenericQueryResult SearchById(Guid id, [FromServices] BuscarPorIdVagaHandler handle)
        {
            var query = new BuscarPorIdVagaQuery
            {
                Id = id
            };


            return (GenericQueryResult)handle.Handler(query);
        }
    }
}
