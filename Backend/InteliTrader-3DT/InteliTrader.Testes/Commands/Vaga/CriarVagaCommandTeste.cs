using InteliTrader.Dominio.Commands.Vaga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InteliTrader.Testes.Commands.Vaga
{
   public class CriarVagaCommandTeste
    {
        [Fact]

        public void DeveRetornarSucessoSeDadosForemValidos()
        {
            var command = new CriarVagaCommand();

            command.NomeVaga = "Desenvolvedor Back End";
            command.Descricao = "Vaga com conhecimento em C#";

            command.Validar();

            Assert.True(command.IsValid, "Os Dados foram Preenchido corretamente!");
        }
    }
}
