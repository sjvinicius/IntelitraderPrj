using Flunt.Notifications;
using InteliTrader.Comum.Commands;
using InteliTrader.Comum.Handlers.Contracts;
using InteliTrader.Comum.Utils;
using InteliTrader.Dominio.Commands.Candidato;
using InteliTrader.Dominio.Entidades;
using InteliTrader.Dominio.Interfaces;
using InteliTrader.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Handlers.Candidatos
{
    public class CriarContaCandidatoHandler : Notifiable<Notification>, IHandlerCommand<CadastroCandidatoCommand>
    {
        private readonly ICandidatoRepository _candidatoRepository;

        public CriarContaCandidatoHandler(ICandidatoRepository candidatoRepository)
        {

            _candidatoRepository = candidatoRepository;
        }
        public ICommandResult Handler(CadastroCandidatoCommand command)
        {
            command.Validar();

            if (!command.IsValid)
            {
                return new GenericCommandResult(false, "Informe Corretamente os Dados do Candidato!", command.Notifications);
            }

            //Verificar se email existe 
            var candidatoEmailExiste  = _candidatoRepository.BuscarPorEmail(command.Email);
            if (candidatoEmailExiste != null)
            {
                return new GenericCommandResult(false, "Email de Candidato já Existente!", "Informe outro");
            }
            //Criptografia Senha
            command.Senha = Senha.Criptografar(command.Senha);

            //Criptografia CPF
            command.CPF = CPF.Criptografar(command.CPF);
            Candidato novoCandidato = new Candidato(command.Nome, command.Sobrenome,command.CPF,command.Email,command.Senha,command.Curso,command.Instituicao,command.Periodo,command.InformacoesComplementares,command.Cargo,command.Empresa,command.DataInicio,command.DataFim,InteliTrader.Comum.Enum.EnTipoUsuario.Candidato,command.IdVaga);
            if (!novoCandidato.IsValid)
            {
                return new GenericCommandResult(false, "Dados do Candidato Inválidos!", novoCandidato.Notifications);


            }
                _candidatoRepository.Adicionar(novoCandidato);
            return new GenericCommandResult(true, "Candidato cadastrado com Sucesso", "");
        }
    }
}
