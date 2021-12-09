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
        public void DeveRetornarSeDadosForemValidos()
        {
            var command = new CriarFuncionarioCommand(
                "Ruan",
                "Gustavo",
                "RuanGostoso@gmail.com",
                "caldodecana24",
               InteliTrader.Comum.Enum.EnTipoUsuario.Candidato
                );
            Assert.True(command.IsValid, "O Cadastro Está Completo");
        }

        [Fact]
        public void DeveRetornarSeDadosForemPreenchidos()
        {
            var command = new CriarFuncionarioCommand(
                "Ruan",
                "Gustavo",
                "RuanGostoso@gmail.com",
                "caldodecana24",
               InteliTrader.Comum.Enum.EnTipoUsuario.Candidato
                );
            command.Validar();

            Assert.True(command.IsValid, "Os dados estão preenchidos corretamente");
        }
    }
}
