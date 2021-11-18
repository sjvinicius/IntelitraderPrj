using Flunt.Notifications;
using Flunt.Validations;
using InteliTrader.Comum.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Commands
{
    public class LogarCommand : Notifiable<Notification>, ICommand
    {

        public LogarCommand()
        {

        }

        public LogarCommand(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

        public string Email { get; set; }
        public string Senha { get; set; }
        public void Validar()
        {
            AddNotifications(
           new Contract<Notification>()
               .Requires()
               .IsEmail(Email, "Email", "Formato do campo 'Email' está incorreto!")
               .IsGreaterThan(Senha, 8, "Campo 'Senha' deve ter ao menos 7 caracteres!")
           );
        }
    }
}
