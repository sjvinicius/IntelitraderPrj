using InteliTrader.Comum.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Entidades
{
    public class Candidato
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Personalidade { get; private set; }
        public string Funcao { get; private set; }
        public EnSituacaoCandidato Situacao { get; private set; }


        //Composições
        public Guid IdVaga { get; set; }
        public Vagas Vaga { get; set; }
    }
}
