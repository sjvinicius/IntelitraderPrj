using InteliTrader.Comum.Enum;
using InteliTrader.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InteliTrader.Testes
{
    public class UsuarioCadastroTeste
    {
        [Fact]
        public void DeveRetornarSeUsuarioForValido()
        {
            var usuario = new Usuario(
               "Ruan",
                "Gustavo",
                "RuanGostoso@gmail.com",
                "caldodecana24",
                "243.524.789-13",
                "24.536.578-2",
                "11940759338",
                "Tenho 20 anos e sou recém formado na aréa de tecnologia, estou em busca de uma oportunidade onde eu possa compartilhar meus conhecimentos aplicando no ambiente de trabalho e aprendendo mais com profissionais capacitados.",
                "Técnico de Desenvolvimento de Sistemas",
                "Escola SENAI de Informática",
                "01/2019 - 01/2020",
                "Lorenzetti S/A Indústrias Metralúrgicas-Jovem Aprendiz",
                EnTipoUsuario.Candidato
                );

            Assert.True(usuario.IsValid, "Usuário é válido");

        }
        [Fact]
        public void DeveRetornarSeUsuarioForInvalido()
        {
            var usuario = new Usuario(
                "Ruan",
                "",
                "RuanGostoso@gmail.com",
                "caldodecana24",
                "243.524.789-13",
                "24.536.578-2",
                "11940759338",
                "Tenho 20 anos e sou recém formado na aréa de tecnologia, estou em busca de uma oportunidade onde eu possa compartilhar meus conhecimentos aplicando no ambiente de trabalho e aprendendo mais com profissionais capacitados.",
                "Técnico de Desenvolvimento de Sistemas",
                "Escola SENAI de Informática",
                "01/2019 - 01/2020",
                "Lorenzetti S/A Indústrias Metralúrgicas-Jovem Aprendiz",
                EnTipoUsuario.Candidato
                );
            Assert.False(usuario.IsValid, "Usuário é Inválido");
        }
    }
}
