using InteliTrader.Dominio.Commands.Candidato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InteliTrader.Testes.Commands.Candidato
{
   public class CriarCandidatoCommandTeste
    {
        [Fact]

        public void DeveRetornarSeDadosDoCandidatoForemValidos()
        {
            var command = new CriarCandidatoCommand(
               "Ruan Gustavo",
               "Cavalcante Ferreira",
               "Gato, Aguia",
               "Desenvolvedor BackEnd"
               );
            Assert.True(command.IsValid, "O Candidato foi criado");
        }
   }
}
