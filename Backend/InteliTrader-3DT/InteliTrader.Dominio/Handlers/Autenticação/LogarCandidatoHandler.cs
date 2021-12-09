using Flunt.Notifications;
using InteliTrader.Comum.Commands;
using InteliTrader.Comum.Handlers.Contracts;
using InteliTrader.Comum.Utils;
using InteliTrader.Dominio.Commands.Autenticação;
using InteliTrader.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Handlers.Autenticação
{
  public class LogarCandidatoHandler : Notifiable<Notification>, IHandlerCommand<LogarCandidatoCommand>
    {
        //Injeção de Depêndencia
        private readonly ICandidatoRepository _candidatoRepository;

        public LogarCandidatoHandler(ICandidatoRepository candidatoRepositorio)
        {
            _candidatoRepository = candidatoRepositorio;
        }
        public ICommandResult Handler(LogarCandidatoCommand command)
        {
            // Comando é válido
            command.Validar();
            if (!command.IsValid)
                return new GenericCommandResult
                (
                    false,
                    "Dados Incorretos",
                    command.Notifications
                 );
            // Buscar usuário por email
            var candidatoBuscado = _candidatoRepository.BuscarPorEmail(command.Email);
            // Usuário existe
            if (candidatoBuscado == null)
                return new GenericCommandResult(false, "Email ou senha inválido!", "");

             //Validar senha
            if (!Senha.Validar(command.Senha, candidatoBuscado.Senha))
                return new GenericCommandResult(false, "Senha inválida!", null);
            return new GenericCommandResult(true, "Login Foi Feito", candidatoBuscado);
        }
    }
}
