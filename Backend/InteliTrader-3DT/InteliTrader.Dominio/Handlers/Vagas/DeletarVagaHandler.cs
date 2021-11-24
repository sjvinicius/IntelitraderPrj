using Flunt.Notifications;
using InteliTrader.Comum.Commands;
using InteliTrader.Comum.Handlers.Contracts;
using InteliTrader.Dominio.Commands.Vaga;
using InteliTrader.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Handlers.Vagas
{
   public class DeletarVagaHandler : Notifiable<Notification>, IHandlerCommand<DeletarVagaCommand>
    {
        private readonly IVagasRepository _vagaRepository;

        public DeletarVagaHandler(IVagasRepository vagaRepository)
        {
            _vagaRepository = vagaRepository;
        }

        public ICommandResult Handler(DeletarVagaCommand command)
        {
            command.Validar();

            if (!command.IsValid)
            {
                return new GenericCommandResult(false, "Informe corretamente a vaga que deseja deletar!", command.Notifications);
            }

            var vagaBuscada = _vagaRepository.BuscarPorId(command.Id);

            if (vagaBuscada == null)
            {
                return new GenericCommandResult(false, "Vaga não encontrada!", command.Notifications);
            }

            _vagaRepository.Deletar(vagaBuscada);

            return new GenericCommandResult(false, "Vaga deletada com sucesso!", "");
        }
    }
}
