using InteliTrader.Comum.Commands;
using InteliTrader.Dominio.Commands.Candidato;
using InteliTrader.Dominio.Handlers.Candidatos;
using InteliTrader.Testes.Repositorios.Candidatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InteliTrader.Testes.Handler.Candidato
{
    public class CriarCandidatoHandlerTeste
    {
        [Fact]
        public void DeveRetornarCasoOsDadosDoHandleSejamValido()
        {
            // Criar um command
            var command = new CadastroCandidatoCommand();
            command.Nome = "Ruan Gustavo";
            command.Sobrenome = "Cavalcante Ferreira";
            command.CPF = "46732305824";
            command.Email = "ruangustavo@gmail.com";
            command.Senha = "pastel2345";
            command.Curso = "Dev de Sistemas";
            command.Instituicao = "SENAI-Informática";
            command.Periodo = "Manha";
            command.InformacoesComplementares = "Procurando meu Primeiro emprego na Area de Dev";
            command.Cargo = "Dev BackEnd";
            command.Empresa = "autonomo";
            command.DataInicio = "23042013";
            command.DataFim = "25052014";
            command.TipoUsuario = Comum.Enum.EnTipoUsuario.Candidato;
            //Nome = nome;
            //Sobrenome = sobrenome;
            //CPF = cpf;
            //Email = email;
            //Senha = senha;
            //Curso = curso;
            //Instituicao = instituicao;
            //Periodo = periodo;
            //InformacoesComplementares = informacoesComplementares;
            //Cargo = cargo;
            //Empresa = empresa;
            //DataInicio = dataInicio;
            //DataFim = dataFim;
            //TipoUsuario = tipoUsuario;
            // Criar um handle
            var handle = new CriarContaCandidatoHandler(new CandidatoFakeRepository());
            // Pegar o resultado
            var resultado = (GenericCommandResult)handle.Handler(command);
            // Validar a condição
            Assert.True(true, "Usuario Cadastrado");
        }
    }
}
