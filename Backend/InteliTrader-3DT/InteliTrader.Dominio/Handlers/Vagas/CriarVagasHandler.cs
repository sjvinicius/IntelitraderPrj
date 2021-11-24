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
    public class CriarVagasHandler : Notifiable<Notification>, IHandlerCommand<CriarVagaCommand>
    {
        private readonly IVagasRepository _vagaRepository;

        public CriarVagasHandler(IVagasRepository vagaRepository)
        {
            _vagaRepository = vagaRepository;
        }
        public ICommandResult Handler(CriarVagaCommand command)
        {
            command.Validar();

            if (!command.IsValid)
            {
                return new GenericCommandResult(false, "Informe o Nome da vaga", command.Notifications);
            }

            //salvando no banco
            Vaga novaVaga = new Vaga(command.NomeVaga);

            if (!novaVaga.IsValid)
            {
                return new GenericCommandResult(false, "Dados Inválidos tente de novo", novaVaga.Notifications);
            }

            _vagaRepository.Adicionar(novaVaga);

            return new GenericCommandResult(true, "Vaga Criada com Sucesso!", "");
        }
    }
}
