using Flunt.Notifications;
using InteliTrader.Comum.Commands;
using InteliTrader.Dominio.Commands.Autenticação;
using InteliTrader.Comum.Handlers.Contracts;
using InteliTrader.Dominio.Commands;
using InteliTrader.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InteliTrader.Dominio.Entidades;
using InteliTrader.Comum.Utils;

namespace InteliTrader.Dominio.Handlers.Autenticação
{
    public class LogarHandle : Notifiable<Notification>, IHandlerCommand<LogarCommand>
    {
        //Injeção de Depêndencia
        private readonly IUsuarioRepository _usuarioRepository;

        public LogarHandle(IUsuarioRepository usuarioRepositorio)
        {
            _usuarioRepository = usuarioRepositorio;
        }
        public ICommandResult Handler(LogarCommand command)
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
            var usuarioBuscado = _usuarioRepository.BuscarPorEmail(command.Email);
            // Usuário existe
            if (usuarioBuscado == null)
                return new GenericCommandResult(false, "Email ou senha inválido!", "");

            // Validar senha
            //if (!Senha.Validar(command.Senha, usuarioBuscado.Senha))
            //    return new GenericCommandResult(false, "Senha inválida!", null);
            return new GenericCommandResult(true, "Login Foi Feito", usuarioBuscado);
        }
    }
}
