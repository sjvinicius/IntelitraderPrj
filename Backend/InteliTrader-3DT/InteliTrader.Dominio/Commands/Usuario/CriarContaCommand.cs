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
    public class CriarContaCommand : Notifiable<Notification>, ICommand
    {
        public CriarContaCommand()
        {
        }
        public CriarContaCommand(string nome, string sobrenome, string email, string senha, int telefone, int rg, int cpf, string descricao, string cursando, string instituicao, string trabalho, string ondeTrabalha, DateTime dataTrabalho, DateTime dataCurso)
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
            DataTrabalho = dataTrabalho;
            DataCurso = dataCurso;
        }

        
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public int Telefone { get; private set; }
        public int RG { get; private set; }
        public int CPF { get; private set; }
        public string Descricao { get; private set; }
        public string Cursando { get; private set; }
        public string Instituicao { get; private set; }
        public string Trabalho { get; private set; }
        public string OndeTrabalha { get; private set; }
        public DateTime DataTrabalho { get; private set; }
        public DateTime DataCurso { get; private set; }
        public EnTipoUsuario TiposUsuario { get; private set; }


        public void Validar()
        {
            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotEmpty(Nome, "Nome", "O campo nome não pode ser vazio")
                .IsNotEmpty(Sobrenome, "Sobrenome", "O campo nome não pode ser vazio")
                .IsEmail(Email, "Email", "formato incorreto de email")
                .IsGreaterThan(Senha, 8, "Senha", "A senha deve ter 8 caracteres ou mais")
                .IsGreaterOrEqualsThan(Telefone, 11, "Telefone", "O Telefone para contato deve ter 11 caracteres")
                .IsGreaterOrEqualsThan(RG, 10, "RG", "O RG deve ter 10 caracteres")
                .IsGreaterOrEqualsThan(CPF, 11, "CPF", "O CPF deve ter 11 caracteres")
                .IsNotEmpty(Cursando, "Cursando", "Não é Obrigatório")
                .IsNotEmpty(Instituicao, "Instituição", "Não é Obrigatório")
                .IsNotEmpty(Trabalho, "Trabalho", "Não é Obrigatório")
                .IsNotEmpty(OndeTrabalha, "Local de Trabalho", "Não é Obrigatório")

            );
        }
    }
}
