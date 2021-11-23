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
    public class CriarVagaCommand : Notifiable<Notification>, ICommand
    {
        public CriarVagaCommand()
        {

        }
        public CriarVagaCommand(string nomeVaga, string descricao)
        {
            NomeVaga = nomeVaga;
            Descricao = descricao;
        }

        public string NomeVaga { get; set; }

        public string Descricao { get; set; }

        public void Validar()
        {
            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotEmpty(NomeVaga, "NomeCurso", "O campo 'NomeVaga' não pode ser vazio!")
                .IsNotEmpty(Descricao,"Descrição","O campo 'Descrição' não pode ser vazio!")
            );
        }
    }
}
