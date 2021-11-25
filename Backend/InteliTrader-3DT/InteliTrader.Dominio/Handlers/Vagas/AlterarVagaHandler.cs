using Flunt.Notifications;
using InteliTrader.Comum.Commands;
using InteliTrader.Comum.Handlers.Contracts;
using InteliTrader.Dominio.Commands.Vaga;
using InteliTrader.Dominio.Entidades;
using InteliTrader.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Handlers.Vagas
{
    public class AlterarVagaHandler : Notifiable<Notification>, IHandlerCommand<AlterarVagaCommand>
    {
        private readonly IVagasRepository _vagaRepository;

        public AlterarVagaHandler(IVagasRepository vagaRepository)
        {
            _vagaRepository = vagaRepository;
        }
        public ICommandResult Handler(AlterarVagaCommand command)
        {
            command.Validar();
            if (!command.IsValid)
            {
                return new GenericCommandResult(false, "Informe Corretamente os dados da Vaga!", command.Notifications);
            }
            Vaga vagaAntiga = _vagaRepository.BuscarPorId(command.Id);
            if (vagaAntiga == null)
            {
                return new GenericCommandResult(false, "Não existe nenhuma vaga com esse ID!", command.Notifications);
            }
            vagaAntiga.AlterarVaga(command.NomeVaga);

            _vagaRepository.Alterar(vagaAntiga);

            return new GenericCommandResult(true, "Nome da vaga Alterada com sucesso!", vagaAntiga);
        }
    }
}
