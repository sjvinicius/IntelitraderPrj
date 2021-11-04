using Flunt.Notifications;
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
        public void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
