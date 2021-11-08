using Flunt.Notifications;
using InteliTrader.Comum.Commands;
using InteliTrader.Comum.Handlers.Contracts;
using InteliTrader.Dominio.Commands.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Handlers.Usuarios
{
    public class CriarUsuarioHandler : Notifiable<Notification>, IHandler<CriarContaCommand>
    {
        public ICommandResult Handler(CriarContaCommand command)
        {
            // PODEMOS FAZER
            // Verificar se email existe
            // Criptografar senha
            // Salvar no banco - repositorio.Adicionar(usuario)
            // Enviar email de boas vindas
            return new GenericCommandResult(true, "Usuario criado", "Token");
        }
    }
}
