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
            var command = new CriarUsuarioCommand(
                "Ruan",
                "Gustavo",
                "RuanGostoso@gmail.com",
                "caldodecana24",
                "11940759338",
                "245365782",
                "24352478913",
                "Tenho 20 anos e sou recém formado na aréa de tecnologia, estou em busca de uma oportunidade onde eu possa compartilhar meus conhecimentos aplicando no ambiente de trabalho e aprendendo mais com profissionais capacitados.",
                "Técnico de Desenvolvimento de Sistemas",
                "Escola SENAI de Informática",
                "01/2019 - 01/2020",
                "Lorenzetti -Jovem Aprendiz",
               InteliTrader.Comum.Enum.EnTipoUsuario.Candidato
                );
            Assert.True(command.IsValid, "O Cadastro Está Completo");
        }

        [Fact]
        public void DeveRetornarErroSeDadosForemPreenchidos()
        {
            var command = new CriarUsuarioCommand(
                "Ruan",
                "Gustavo",
                "RuanGostoso@gmail.com",
                "caldodecana24",
                "11940759338",
                "245365782",
                "24352478913",
                "Tenho 20 anos e sou recém formado na aréa de tecnologia, estou em busca de uma oportunidade onde eu possa compartilhar meus conhecimentos aplicando no ambiente de trabalho e aprendendo mais com profissionais capacitados.",
                "Técnico de Desenvolvimento de Sistemas",
                "Escola SENAI de Informática",
                "01/2019 - 01/2020",
                "Lorenzetti S/A Indústrias Metralúrgicas - Jovem Aprendiz",
               InteliTrader.Comum.Enum.EnTipoUsuario.Candidato
                );
            command.Validar();

            Assert.True(command.IsValid, "Os dados esttão preenchidos corretamente");
        }
    }
}
