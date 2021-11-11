using InteliTrader.Comum.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Entidades
{
   public class Vaga
   {
        public string NomeVaga { get; private set; }
        public string Descricao { get; private set; }
        public EnVagaSituacao SituacaoVaga { get; private set; }
        public int PorcentagemSucesso { get; private set; }

        //Composições

        public IReadOnlyCollection<Candidato> Candidatos { get; private set; }
    }
}
