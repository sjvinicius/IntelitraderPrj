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
            var command = new CadastroCandidatoCommand(
               "Ruan Gustavo",
               "Cavalcante Ferreira",
               "",
               "",
               "",
               "",
               "",
               "",
               "",
               "",
               "",
               "",
               "",
               Comum.Enum.EnTipoUsuario.Candidato,
               Guid.Empty
               );
            Assert.True(command.IsValid, "O Candidato foi criado");
        }
   }
}
