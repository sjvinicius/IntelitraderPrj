using Flunt.Notifications;
using InteliTrader.Comum.Commands;
using InteliTrader.Comum.Handlers.Contracts;
using InteliTrader.Dominio.Commands.Candidato;
using InteliTrader.Dominio.Entidades;
using InteliTrader.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Handlers.Candidatos
{
    public class CriarCandidatoHandler : Notifiable<Notification>, IHandlerCommand<CriarCandidatoCommand>
    {
        private readonly ICandidatoRepository _candidatoRepository;
        private readonly IVagasRepository _vagaRepository;

        public CriarCandidatoHandler(ICandidatoRepository candidatoRepository, IVagasRepository vagasRepository)
        {
            _vagaRepository = vagasRepository;
            _candidatoRepository = candidatoRepository;
        }
        public ICommandResult Handler(CriarCandidatoCommand command)
        {
            command.Validar();

            if (!command.IsValid)
            {
                return new GenericCommandResult(false, "Informe Corretamente os Dados do Candidato!", command.Notifications);
            }

            var IdExiste = _candidatoRepository.BuscarPorId(command.IdUsuarios);
            if (IdExiste != null)
            {
                return new GenericCommandResult(false, "Id de usuario já Existente!", "Informe outro");

            }

            Candidato novoCandidato = new Candidato(command.Nome, command.Sobrenome, command.Personalidade, command.Funcao);
            if (!novoCandidato.IsValid)
            {
                return new GenericCommandResult(false, "Dados do Candidato Inválidos!", novoCandidato.Notifications);


            }
                _candidatoRepository.Adicionar(novoCandidato);
            return new GenericCommandResult(true, "Candidato cadastrado com Sucesso", "");
        }
    }
}
