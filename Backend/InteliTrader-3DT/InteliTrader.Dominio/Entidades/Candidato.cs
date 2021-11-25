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
    public class Candidato : Base
    {
        public Candidato(string nome, string sobrenome, string personalidade, string funcao)
        {
            AddNotifications(
                  new Contract<Notification>()
                      .Requires()
                      .IsNotEmpty(nome, "Nome do Candidato", "Informe seu Nome")
                      .IsNotEmpty(sobrenome, "Descricao", "Informe seu sobrenome")
                      .IsNotEmpty(personalidade, "Personalidades", "Informe Seus Traços de Personalidade")
                      .IsNotEmpty(funcao, "Função", "Infome sua Função")
                  );
            if (IsValid)
            {
            Nome = nome;
            Sobrenome = sobrenome;
            Personalidade = personalidade;
            Funcao = funcao;
            }
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Personalidade { get; private set; }
        public string Funcao { get; private set; }
        public EnSituacaoCandidato Situacao { get; private set; }


        //Composições
        public Guid IdVaga { get; set; }
        public Vaga Vaga { get; set; }
    }
}
