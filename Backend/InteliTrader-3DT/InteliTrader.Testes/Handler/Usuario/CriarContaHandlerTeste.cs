using InteliTrader.Comum.Commands;
using InteliTrader.Dominio.Commands.Usuario;
using InteliTrader.Dominio.Handlers.Usuarios;
using InteliTrader.Testes.Repositorios;
using InteliTrader.Testes.Repositorios.Usuario;
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
            var command = new CriarContaCommand();
            command.Nome = "Paulo";
            command.Sobrenome = "Brandão";
            command.Email = "paulobrandaoofficial@gmail.com";
            command.Senha = "pastel2345";
            command.RG =  "534625861";
            command.CPF = "38475694328";
            command.Telefone = "11948573645";
            command.Descricao = "Tenho 20 anos e sou recém formado na aréa de tecnologia, estou em busca de uma oportunidade onde eu possa compartilhar meus conhecimentos aplicando no ambiente de trabalho e aprendendo mais com profissionais capacitados.";
            command.Cursando = "Desenvolvimento de Sistemas";
            command.Instituicao = "Senai Diadema";
            command.Trabalho = "N/F";
            command.OndeTrabalha = "N/F";
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
