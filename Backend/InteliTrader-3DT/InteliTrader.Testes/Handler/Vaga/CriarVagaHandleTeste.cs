using InteliTrader.Comum.Commands;
using InteliTrader.Dominio.Commands.Vaga;
using InteliTrader.Dominio.Handlers.Vagas;
using InteliTrader.Testes.Repositorios.Vaga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InteliTrader.Testes.Handler.Vaga
{
    public class CriarVagaHandleTeste
    {
        [Fact]
        public void DeveRetornarCasoDadosSejamValido()
        {
            var command = new CriarVagaCommand();

            command.NomeVaga = "Desenvolvedor Back End";
            command.Descricao = "";

            var handle = new CriarVagasHandler(new FakeVagaRepository());
            
            var resultado = (GenericCommandResult)handle.Handler(command);

            Assert.True(resultado.Sucesso, "A Vaga Foi Validada!");
        }
    }
}
