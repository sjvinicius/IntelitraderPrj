using Flunt.Notifications;
using Flunt.Validations;
using InteliTrader.Comum.Entidades;
using InteliTrader.Comum.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Entidades
{
   public class Vaga : Base
   {
        public Vaga()
        {

        }
        public Vaga(string nomeVaga, string descricao, EnVagaSituacao situacaoVaga)
        {
            AddNotifications(
                  new Contract<Notification>()
                      .Requires()
                      .IsNotEmpty(nomeVaga, "Nome da Vaga", "O nome da vaga não pode ser vazio")
                      .IsNotEmpty(descricao, "Descricao", "A Descricao não pode ser vazia")                                       
                  );
            if (IsValid)
            {
            NomeVaga = nomeVaga;
            Descricao = descricao;
            SituacaoVaga = situacaoVaga;

            }
        }

        public string NomeVaga { get; private set; }
        public string Descricao { get; private set; }
        public EnVagaSituacao SituacaoVaga { get; private set; }


        //Composições
        public IReadOnlyCollection<Candidato> Candidatos { get; private set; }

        //metodos
        public void AlterarVaga(string nomeVaga)
        {
            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotEmpty(NomeVaga, "NomeVaga", "Campo 'NomeVaga' não pode ser vazio!")
            );

            if (IsValid)
            {
                NomeVaga = nomeVaga;
            }

        }
    }
}
