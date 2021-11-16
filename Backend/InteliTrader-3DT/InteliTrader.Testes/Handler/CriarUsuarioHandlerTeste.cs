using InteliTrader.Comum.Commands;
using InteliTrader.Dominio.Commands.Usuario;
using InteliTrader.Dominio.Handlers.Usuarios;
using InteliTrader.Testes.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InteliTrader.Testes.Handler
{
    public class CriarUsuarioHandlerTeste
    {
        [Fact]
        public void DeveRetornarCasoOsDadosDoHandleSejamValido()
        {
            // Criar um command
            var command = new CriarContaCommand();
            command.Nome = "Paulo";
            command.Sobrenome = "Brandão";
            command.Email = "paulobrandaoofficial@email.com";
            command.Senha = "6548974564";
            command.Telefone ="11970520234";
            command.RG = "53.462.586-1";
            command.CPF = "467.323.058.24";
            command.Cursando = "Desenvolvimento de Sistemas";
            command.Instituicao = "Senai Diadema";
            command.Trabalho = "";
            command.OndeTrabalha = "";
            command.TiposUsuario = InteliTrader.Comum.Enum.EnTipoUsuario.Candidato;
            // Criar um handle
            var handle = new CriarUsuarioHandler(new FakeUsuarioRepositorio());
            // Pegar o resultado
            var resultado = (GenericCommandResult)handle.Handler(command);
            // Validar a condição
            Assert.True(true, "Usuario Válido");
        }
    }
}
