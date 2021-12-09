using Flunt.Notifications;
using Flunt.Validations;
using InteliTrader.Comum.Commands;
using InteliTrader.Comum.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Commands.Candidato
{
    public class CadastroCandidatoCommand : Notifiable<Notification>, ICommand
    {
        public CadastroCandidatoCommand()
        {

        }

        public CadastroCandidatoCommand(string nome, string sobrenome, string cpf, string email, string senha, string curso, string instituicao, string periodo, string informacoesComplementares, string cargo, string empresa, string dataInicio, string dataFim, EnTipoUsuario tipoUsuario, Guid idVaga)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
            Email = email;
            Senha = senha;
            Curso = curso;
            Instituicao = instituicao;
            Periodo = periodo;
            InformacoesComplementares = informacoesComplementares;
            Cargo = cargo;
            Empresa = empresa;
            DataInicio = dataInicio;
            DataFim = dataFim;
            TipoUsuario = tipoUsuario;
            IdVaga = idVaga;
        }


        //Nome = nome;
        //    Sobrenome = sobrenome;
        //    Personalidade = personalidade;
        //    Funcao = funcao;
        //    Situacao = situacao;

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Curso { get; set; }
        public string Instituicao { get; set; }
        public string Periodo { get; set; }
        public string InformacoesComplementares { get; set; }
        public string Cargo { get; set; }
        public string Empresa { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public EnTipoUsuario TipoUsuario { get; set; }

        //Composições
        public Guid IdVaga { get; set; } = Guid.Empty;//se receber nulo vira guid 0
        public Guid IdUsuarios { get; set; }
        public void Validar()
        {
            AddNotifications(
                new Contract<Notification>()
                .Requires()
                .IsNotEmpty(Nome, "Nome", "O campo nome não pode ser vazio")
                      .IsNotEmpty(Sobrenome, "Sobrenome", "O campo nome não pode ser vazio")
                      .IsGreaterThan(CPF, 10, "CPF", "O CPF deve ter 10 caracteres")
                      .IsEmail(Email, "Email", "formato incorreto de email")
                      .IsGreaterOrEqualsThan(Senha, 8, "Senha", "A senha deve ter 8 caracteres ou mais")
                      .IsNotEmpty(Curso, "curso", "O campo curso não pode ser vazio")
                      .IsNotEmpty(Instituicao, "instituicao", "O campo instituicao não pode ser vazio")
                      .IsNotEmpty(Periodo, "periodo", "O campo periodo não pode ser vazio")
                      .IsNotEmpty(InformacoesComplementares, "informacoesComplementares", "O campo informacoesComplementares não pode ser vazio")
                      .IsNotEmpty(Cargo, "cargo", "O campo cargo não pode ser vazio")
                      .IsNotEmpty(Empresa, "empresa", "O campo empresa não pode ser vazio")
                      .IsNotEmpty(DataInicio, "DataInicio", "O campo DataInicio não pode ser vazio")
                      .IsNotEmpty(DataFim, "DataFim", "O campo DataFim não pode ser vazio")
                      .IsNotEmpty(IdVaga, "IdVaga", "O ID da Vaga não pode ser NULO!")

            );
        }
    }
}
