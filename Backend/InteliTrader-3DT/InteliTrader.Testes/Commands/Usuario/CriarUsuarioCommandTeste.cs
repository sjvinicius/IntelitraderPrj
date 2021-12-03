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
            var command = new CriarContaCommand(
                "Ruan",
                "Gustavo",
                "RuanGostoso@gmail.com",
                "caldodecana24",
                "245365782",
                "38475968437",
                "11958475632",
                "Tenho 20 anos e sou recém formado na aréa de tecnologia, estou em busca de uma oportunidade onde eu possa compartilhar meus conhecimentos aplicando no ambiente de trabalho e aprendendo mais com profissionais capacitados.",
                "Técnico de Desenvolvimento de Sistemas",
                "Escola SENAI de Informática",
                "N/F",
                "N/F",
               InteliTrader.Comum.Enum.EnTipoUsuario.Candidato
                );
            Assert.True(command.IsValid, "O Cadastro Está Completo");
        }

        [Fact]
        public void DeveRetornarSeDadosForemPreenchidos()
        {
            var command = new CriarContaCommand(
                "Ruan",
                "Gustavo",
                "RuanGostoso@gmail.com",
                "caldodecana24",
                "245365782",
                "38475968437",
                "11958475632",
                "Tenho 20 anos e sou recém formado na aréa de tecnologia, estou em busca de uma oportunidade onde eu possa compartilhar meus conhecimentos aplicando no ambiente de trabalho e aprendendo mais com profissionais capacitados.",
                "Técnico de Desenvolvimento de Sistemas",
                "Escola SENAI de Informática",
                "N/F",
                "N/F",
               InteliTrader.Comum.Enum.EnTipoUsuario.Candidato
                );
            command.Validar();

            Assert.True(command.IsValid, "Os dados estão preenchidos corretamente");
        }
    }
}
