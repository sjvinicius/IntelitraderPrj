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

        //Nome = nome;
        //    Sobrenome = sobrenome;
        //    Personalidade = personalidade;
        //    Funcao = funcao;
        //    Situacao = situacao;

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
                .IsNotNull(Sobrenome, "Rosto", "Campo 'Rosto' não pode ser vazio!")
                .IsNotNull(Personalidade, "DataNascimento", "Campo 'DataNascimento' não pode ser vazio!")
                .IsNotNull(Funcao, "RA", "Campo 'RA' não pode ser nulo!")
                .IsNotEmpty(IdVaga, "IdPeriodo", "Campo 'IdPeriodo' não pode ser vazio!")
                .IsNotEmpty(IdUsuarios, "IdCurso", "Campo 'IdCurso' não pode ser vazio!")
            );
        }
    }
}
