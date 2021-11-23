using Flunt.Notifications;
using Flunt.Validations;
using InteliTrader.Comum.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Commands.Vaga
{
    public class DeletarVagaCommand : Notifiable<Notification>, ICommand
    {
        public DeletarVagaCommand()
        {

        }

        public DeletarVagaCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
        public void Validar()
        {
            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotEmpty(Id, "Id", "O id da Vaga não pode ser vazio!")
            );
        }
    }
}
