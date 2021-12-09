using Flunt.Notifications;
using Flunt.Validations;
using InteliTrader.Comum.Entidades;
using InteliTrader.Comum.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Entidades
{
    public class Candidato : Base
    {
        public Candidato()
        {

        }
        public Candidato(string nome, string sobrenome, string cpf, string email,string senha, string curso, string instituicao, string periodo, string informacoesComplementares, string cargo, string empresa, string anoinicio, string anofim, EnTipoUsuario tipoUsuario, Guid idVaga)
        {
            AddNotifications(
                  new Contract<Notification>()
                      .Requires()
                      .IsNotEmpty(nome, "Nome", "O campo nome não pode ser vazio")
                      .IsNotEmpty(sobrenome, "Sobrenome", "O campo nome não pode ser vazio")
                      .IsGreaterThan(cpf, 10, "CPF", "O CPF deve ter 10 caracteres")
                      .IsEmail(email, "Email", "formato incorreto de email")
                      .IsGreaterOrEqualsThan(senha, 8, "Senha", "A senha deve ter 8 caracteres ou mais")
                      .IsNotEmpty(curso, "curso", "O campo curso não pode ser vazio")
                      .IsNotEmpty(instituicao, "instituicao", "O campo instituicao não pode ser vazio")
                      .IsNotEmpty(periodo, "periodo", "O campo periodo não pode ser vazio")
                      .IsNotEmpty(informacoesComplementares, "informacoesComplementares", "O campo informacoesComplementares não pode ser vazio")
                      .IsNotEmpty(cargo, "cargo", "O campo cargo não pode ser vazio")
                      .IsNotEmpty(empresa, "empresa", "O campo empresa não pode ser vazio")
                      .IsNotEmpty(anoinicio, "Data Inicio", "Coloque a Data em que você começou")
                      .IsNotEmpty(anofim, "Data Fim","Coloque a Data em que você termiinou")
                      .IsNotEmpty(idVaga,"IdVaga", "O ID da Vaga não pode ser NULO!")
                  );
            if (IsValid)
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
                AnoInicio = anoinicio;
                AnoFim = anofim;
                TipoUsuario = tipoUsuario;
                IdVaga = idVaga;
            }
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Curso { get; set; }
        public string Instituicao { get; set; }
        public string Periodo { get; set; }
        public string InformacoesComplementares { get; set; }
        public string Cargo { get; set; }
        public string Empresa { get; set; }
        public string AnoInicio { get; set; }
        public string AnoFim { get; set; }
        public EnTipoUsuario TipoUsuario { get; private set; }
        public EnSituacaoCandidato Situacao { get; private set; }



        //Composições
        public Guid IdVaga { get; set; } = Guid.Empty;
        public Vaga Vaga { get; set; }
    }
}
