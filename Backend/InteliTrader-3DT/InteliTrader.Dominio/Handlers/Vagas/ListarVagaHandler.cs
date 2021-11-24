using Flunt.Notifications;
using InteliTrader.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Handlers.Vagas
{
   public class ListarVagaHandler : Notifiable<Notification>, IHandlerQuery<ListarvagaQuery>
    {
        private readonly IVagasRepository _vagaRepository;

        public ListarVagaHandler(IVagasRepository vagaRepository)
        {
            _vagaRepository = vagaRepository;
        }

        public IQueryResult Handler(ListarVagaQuery query)
        {
            var lista = _vagaRepository.Listar();

            return new GenericQueryResult(true, "Cursos encontrados!", lista);
        }

    }
}
