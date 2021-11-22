﻿using InteliTrader.Comum.Commands;
using InteliTrader.Comum.Utils;
using InteliTrader.Dominio.Commands.Usuario;
using InteliTrader.Dominio.Entidades;
using InteliTrader.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Handlers.Usuarios
{
    public class CriarContaHandler
    {
        //Injeção de Dependêcia
        private readonly IUsuarioRepository _usuarioRepository;

        public CriarContaHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public ICommandResult Handler(CriarContaCommand command)
        {
            //verificando se o command é valido
            command.Validar();

            if (!command.IsValid)
            {
                return new GenericCommandResult(false, "Informe corretamente os seus dados", command.Notifications);
            }

            // PODEMOS FAZER

            // Verificar se email existe
            var usuarioExiste = _usuarioRepository.BuscarPorEmail(command.Email);
            if (usuarioExiste != null)
                return new GenericCommandResult(false, "Email já cadastrado Informe outro email!", "Informe Outro Email.");

            // Criptografar senha
            command.Senha = Senha.Criptografar(command.Senha);

            // Salvar no banco - repositorio.Adicionar(usuario)
            Usuario novoUsuario = new Usuario(command.Nome, command.Sobrenome, command.Email, command.Senha, command.Telefone, command.RG, command.CPF, command.Descricao, command.Cursando, command.Instituicao, command.Trabalho, command.OndeTrabalha, command.TiposUsuario);
            if (!novoUsuario.IsValid)
                return new GenericCommandResult(false, "Dados de usuário inválidos", novoUsuario.Notifications);

            _usuarioRepository.Adicionar(novoUsuario);
            // Enviar email de boas vindas
            return new GenericCommandResult(true, "Usuario criado", "user-token");
        }
    }    
}