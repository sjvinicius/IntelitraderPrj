using InteliTrader.Comum.Entidades;
using InteliTrader.Comum.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Entidades
{
   public class Vagas : Base
   {
        public Vagas(string nomeVaga, string descricao, EnVagaSituacao situacaoVaga, int porcentagemSucesso)
        {





            if (IsValid)
            {
            NomeVaga = nomeVaga;
            Descricao = descricao;
            SituacaoVaga = situacaoVaga;
            PorcentagemSucesso = porcentagemSucesso;
            }
        }

        public string NomeVaga { get; private set; }
        public string Descricao { get; private set; }
        public EnVagaSituacao SituacaoVaga { get; private set; }
        public int PorcentagemSucesso { get; private set; }
    }
}
