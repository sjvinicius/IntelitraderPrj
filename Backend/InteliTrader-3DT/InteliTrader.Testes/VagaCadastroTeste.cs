using InteliTrader.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InteliTrader.Testes
{
    public class VagaCadastroTeste
    {
        [Fact]
        public void DeveRetornarSeVagaForCadastrada()
        {
            var vagas = new Vagas(
                "Estágio Front-End",
                "Vaga para estágio em front end com conhecimentos em HTML CSS e JS",
                InteliTrader.Comum.Enum.EnVagaSituacao.VagaPublicada,
                "28%"    
                );
            Assert.True(vagas.IsValid, "Vaga Válida e Cadastrada");
        }


        [Fact]
        public void DeveRetornarErroSeVagaEstiverErrada()
        {
            var vagas = new Vagas(
                "Estágio Back-End",
                "",
                InteliTrader.Comum.Enum.EnVagaSituacao.VagaPublicada,
                "14%"
                );
            Assert.False(vagas.IsValid, "Falta Informações para a Vága");
        }
    }
}
