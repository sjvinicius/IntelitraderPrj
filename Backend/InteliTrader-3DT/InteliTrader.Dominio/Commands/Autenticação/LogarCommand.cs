using Flunt.Notifications;
using Flunt.Validations;
using InteliTrader.Comum.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Commands.Autenticação
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
               .IsEmail(Email, "Email", "formato incorreto de email")
               .IsGreaterThan(Senha, 8, "Senha", "A senha deve ter 8 caracteres ou mais")
           );
        }
    }
}
