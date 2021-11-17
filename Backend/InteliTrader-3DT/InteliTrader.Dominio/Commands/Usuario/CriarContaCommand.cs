using Flunt.Notifications;
using Flunt.Validations;
using InteliTrader.Comum.Commands;
using InteliTrader.Comum.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Commands.Usuario
{
    public class CriarUsuarioCommand : Notifiable<Notification>, ICommand
    {
        public CriarUsuarioCommand()
        {
        }

        public CriarUsuarioCommand(string nome, string sobrenome, string email, string senha, string telefone, string rg, string cpf, string descricao, string cursando, string instituicao, string trabalho, string ondeTrabalha, EnTipoUsuario tiposUsuario)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Senha = senha;
            Telefone = telefone;
            RG = rg;
            CPF = cpf;
            Descricao = descricao;
            Cursando = cursando;
            Instituicao = instituicao;
            Trabalho = trabalho;
            OndeTrabalha = ondeTrabalha;
            TiposUsuario = tiposUsuario;
        }

        public string Nome { get; set; }
        public string Sobrenome { get;  set; }
        public string Email { get;  set; }
        public string Senha { get;  set; }
        public string Telefone { get;  set; }
        public string RG { get;  set; }
        public string CPF { get;  set; }
        public string Descricao { get;  set; }
        public string Cursando { get;  set; }
        public string Instituicao { get; set; }
        public string Trabalho { get;  set; }
        public string OndeTrabalha { get;  set; }
        public EnTipoUsuario TiposUsuario { get;  set; }


        public void Validar()
        {
            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotEmpty(Nome, "Nome", "O campo nome não pode ser vazio")
                .IsNotEmpty(Sobrenome, "Sobrenome", "O campo nome não pode ser vazio")
                .IsEmail(Email, "Email", "formato incorreto de email")
                .IsGreaterThan(Senha, 8, "Senha", "A senha deve ter 8 caracteres ou mais")
                .IsGreaterOrEqualsThan(Telefone, 16, "Telefone", "O Telefone para contato deve ter 11 caracteres")
                .IsGreaterOrEqualsThan(RG, 16, "RG", "O RG deve ter 10 caracteres")
                .IsGreaterOrEqualsThan(CPF, 16, "CPF", "O CPF deve ter 11 caracteres")
                .IsNotEmpty(Cursando, "Cursando", "Não é Obrigatório")
                .IsNotEmpty(Instituicao, "Instituição", "Não é Obrigatório")
                .IsNotEmpty(Trabalho, "Trabalho", "Não é Obrigatório")
                .IsNotEmpty(OndeTrabalha, "Local de Trabalho", "Não é Obrigatório")

            );
        }
    }
}
