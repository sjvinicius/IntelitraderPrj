using Flunt.Notifications;
using InteliTrader.Dominio.Interfaces;
using InteliTrader.Dominio.Querie.Candidatos;
using InteliTrader.Shared.Handlers.Contracts.Query;
using InteliTrader.Shared.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Handlers.Candidatos
{
    public class ListarCandidatoHandler : Notifiable<Notification>, IHandlerQuery<ListarCandidatoQuery>
    {
        private readonly ICandidatoRepository _candidatoRepository;

        public ListarCandidatoHandler(ICandidatoRepository candidatoRepository)
        {
            _candidatoRepository = candidatoRepository;
        }
        public IQueryResult Handler(ListarCandidatoQuery query)
        {
            var listaCandidatos = _candidatoRepository.Listar();
            return new GenericQueryResult(true, "Candidatos Encontrados", listaCandidatos);
        }
    }
}
