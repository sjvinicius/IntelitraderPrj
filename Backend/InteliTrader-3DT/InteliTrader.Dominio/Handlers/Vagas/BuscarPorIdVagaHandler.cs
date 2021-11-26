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
    public class BuscarPorIdVagaHandler : Notifiable<Notification>, IHandlerQuery<BuscarPorIdVagaQuery>
    {
        private readonly IVagasRepository _vagaRepository;

        public BuscarPorIdVagaHandler(IVagasRepository vagaRepository)
        {
            _vagaRepository = vagaRepository;
        }
        public IQueryResult Handler(BuscarPorIdVagaQuery query)
        {
            query.Validar();

            if (!query.IsValid)
            {
                return new GenericQueryResult(false, "Informe corretamente os dados da vaga!", query.Notifications);
            }

            // listar todos os cursos
            var vagaBuscada = _vagaRepository.BuscarPorId(query.Id);

            if (vagaBuscada == null)
            {
                return new GenericQueryResult(false, "Não existe nenhuma vaga com este id!", query.Notifications);
            }

            return new GenericQueryResult(true, "Vagas Encontradas!", vagaBuscada);
        }
    }
}
