using InteliTrader.Comum.Commands;
using InteliTrader.Dominio.Commands.Usuario;
using InteliTrader.Dominio.Handlers.Candidatos;
using InteliTrader.Dominio.Handlers.Usuarios;
using InteliTrader.Testes.Repositorios;
using InteliTrader.Testes.Repositorios.Candidatos;
using InteliTrader.Testes.Repositorios.Usuario;
using InteliTrader.Testes.Repositorios.Vaga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InteliTrader.Testes.Handler
{
    public class CriarContaHandlerTeste
    {
        [Fact]
        public void DeveRetornarCasoOsDadosDoHandleSejamValido()
        {
            // Criar um command
            var command = new CriarFuncionarioCommand();
            command.Nome = "Paulo";
            command.Sobrenome = "Brandão";
            command.Email = "paulobrandaoofficial@gmail.com";
            command.Senha = "pastel2345";
            command.TiposUsuario = InteliTrader.Comum.Enum.EnTipoUsuario.Candidato;
            // Criar um handle
            var handle = new CriarContaHandler(new FakeUsuarioRepository());
            // Pegar o resultado
            var resultado = (GenericCommandResult)handle.Handler(command);
            // Validar a condição
            Assert.True(resultado.Sucesso, "Usuario Válido");
        }
    }
}
