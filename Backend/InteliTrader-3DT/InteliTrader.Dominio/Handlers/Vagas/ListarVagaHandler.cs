using Flunt.Notifications;
using InteliTrader.Dominio.Interfaces;
using InteliTrader.Dominio.Querie.Vagas;
using InteliTrader.Shared.Handlers.Contracts.Query;
using InteliTrader.Shared.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Handlers.Vagas
{
   public class ListarVagaHandler : Notifiable<Notification>, IHandlerQuery<ListarVagaQuery>
    {
        private readonly IVagasRepository _vagaRepository;

        public ListarVagaHandler(IVagasRepository vagaRepository)
        {
            _vagaRepository = vagaRepository;
        }

        public IQueryResult Handler(ListarVagaQuery query)
        {
            var lista = _vagaRepository.Listar();

            return new GenericQueryResult(true, "Vagas encontrados!", lista);
        }

    }
}
