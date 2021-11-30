using Flunt.Notifications;
using Flunt.Validations;
using InteliTrader.Comum.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Commands.Candidato
{
    public class CriarCandidatoCommand : Notifiable<Notification>, ICommand
    {
        public CriarCandidatoCommand(string nome, string sobrenome, string personalidade, string funcao)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Personalidade = personalidade;
            Funcao = funcao;
        }

        

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Personalidade { get; set; }
        public string Funcao { get; set; }

        //Composições
        public Guid IdVaga { get; set; }
        public Guid IdUsuarios { get; set; }
        public void Validar()
        {
            AddNotifications(
                new Contract<Notification>()
                .Requires()
                .IsNotNull(Nome, "Nome", "Campo 'Nome' não pode ser nulo!")
                .IsNotNull(Sobrenome, "Sobrenome", "Campo 'Sobrenome' não pode ser vazio!")
                .IsNotNull(Personalidade, "Personalidade", "Campo 'DataNascimento' não pode ser vazio!")
                .IsNotNull(Funcao, "Função", "O Campo 'Função' não pode ser nulo!")
                .IsNotEmpty(IdVaga, "IdVaga", "Campo 'IdVaga' não pode ser vazio!")
                .IsNotEmpty(IdUsuarios, "IdUsuario", "Campo 'IdUsuario' não pode ser vazio!")
            );
        }
    }
}
