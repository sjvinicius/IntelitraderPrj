using InteliTrader.Dominio.Commands.Autenticação;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InteliTrader.Testes.Commands
{
   public class LogarCommandTeste
    {
        [Fact]
        public void DeveRetornarErroSeCasoDadosForemInvalidos()
        {
            var command = new LogarCommand();

            command.Email = "marcos@email.com";
            command.Senha = "roberto2345";

            command.Validar();

            Assert.True(command.IsValid, "Seus Dados estão Incorretos!");
        }
    }
}
