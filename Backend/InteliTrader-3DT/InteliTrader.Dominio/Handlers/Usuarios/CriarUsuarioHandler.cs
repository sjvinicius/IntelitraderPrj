﻿using Flunt.Notifications;
using InteliTrader.Comum.Commands;
using InteliTrader.Comum.Handlers.Contracts;
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
    public class CriarUsuarioHandler : Notifiable<Notification>, IHandler<CriarContaCommand>
    {
        //Injeção de Dependêcia
        private readonly IUsuarioRepository _usuarioRepository;

        public CriarUsuarioHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public ICommandResult Handler(CriarContaCommand command)
        {
            //verificando se o command é valido
            command.Validar();

            if (!command.IsValid)
                return new GenericCommandResult
                    (
                        false,
                        "Informe corretamente os seus dados"
                    );

            // PODEMOS FAZER
            // Verificar se email existe
            var usuarioExiste = _usuarioRepository.BuscarPorEmail(command.Email);
            if (usuarioExiste != null)
                return new GenericCommandResult(false, "Email já cadastrado Informe outro email");
            // Criptografar senha
            // Salvar no banco - repositorio.Adicionar(usuario)
            Usuario usuario = new Usuario(command.Nome,command.Sobrenome, command.Email, command.Senha,command.Telefone,command.RG,command.CPF,command.Descricao,command.Cursando,command.Instituicao,command.Trabalho,command.OndeTrabalha,command.TiposUsuario);

            if (!usuario.IsValid)
                return new GenericCommandResult(false, "Dados de usuário inválidos");

            _usuarioRepository.Adicionar(usuario);
            // Enviar email de boas vindas
            return new GenericCommandResult(true, "Usuario criado");
        }
    }
}
