using InteliTrader.Dominio.Commands.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InteliTrader.Testes.Commands
{
   public class CriarUsuarioCommandTeste
    {
        [Fact]
        public void DeveRetornarErroSeDadosForemValido()
        {
            var command = new CriarContaCommand(
                "Lucas",
                "Nogueira",
                "LucasLindão@gmail.com",
                "pastel231",
                "11934764897",
                "534625861",
                "46732305824",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                InteliTrader.Comum.Enum.EnTipoUsuario.Candidato
                );
            command.Validar();
                Assert.True(command.IsValid, "O Cadastro Está Completo");
        }
    }
}
