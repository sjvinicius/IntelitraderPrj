using Flunt.Notifications;
using InteliTrader.Dominio.Interfaces;
using InteliTrader.Dominio.Query.Vagas;
using InteliTrader.Shared.Handlers.Contracts.Query;
using InteliTrader.Shared.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Handlers.Vagas
{
    public class BuscarPorNomeVagaHandler : Notifiable<Notification>, IHandlerQuery<BuscarPorNomeVagaQuery>
    {
        private readonly IVagasRepository _vagaRepository;

        public BuscarPorNomeVagaHandler(IVagasRepository vagaRepository)
        {
            _vagaRepository = vagaRepository;
        }
        public IQueryResult Handler(BuscarPorNomeVagaQuery query)
        {
            query.Validar();
            if (!query.IsValid)
            {
                return new GenericQueryResult(false, "Informe Corretamente os dados da vaga", query.Notifications);
            }

            var vagaBuscada = _vagaRepository.BuscarPorNome(query.NomeVaga);
            if (vagaBuscada == null)
            {
                return new GenericQueryResult(false, "Não existe nenhuma vaga com esse nome!", query.Notifications);
            }


            return new GenericQueryResult(true, "Vagas Encontradas!", vagaBuscada);
        }
    }
}
