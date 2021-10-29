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
                "RuanGostoso@gmail.com",
                "caldodecana24",
                "24.536.578-2",
                "243.524.789-13",
                EnTipoUsuario.Candidato
                );

            Assert.True(usuario.IsValid, "Usuário é válido");

        }
        [Fact]
        public void DeveRetornarSeUsuarioForInvalido()
        {
            var usuario = new Usuario(
                "Ruan",
                "Ruangustavo@gmail.com",
                "",
                "24.536.578-2",
                "243.542.789-13",
                EnTipoUsuario.Candidato
                );
            Assert.False(usuario.IsValid, "Usuário é Inválido");
        }
    }
}
