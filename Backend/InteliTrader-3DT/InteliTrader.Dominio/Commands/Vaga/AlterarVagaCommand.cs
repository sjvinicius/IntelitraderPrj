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
    public class AlterarVagaCommand : Notifiable<Notification>, ICommand
    {
        public AlterarVagaCommand()
        {

        }

        public AlterarVagaCommand(Guid id, string nomeVaga)
        {
            Id = id;
            NomeVaga = nomeVaga;
        }

        public Guid Id { get; set; }
        public string NomeVaga { get; set; }
        public void Validar()
        {
            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotEmpty(Id, "Id", "O id da Vaga não pode ser vazio!")
                .IsNotEmpty(NomeVaga, "NomeCurso", "O campo 'NomeVaga' não pode ser vazio!")
            );
        }
    }
}
