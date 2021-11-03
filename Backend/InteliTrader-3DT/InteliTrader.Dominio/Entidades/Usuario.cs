using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InteliTrader.Comum.Entidades;
using System.Threading.Tasks;
using InteliTrader.Comum.Enum;
using Flunt.Validations;
using Flunt.Notifications;

namespace InteliTrader.Dominio.Entidades
{
    public class Usuario : Base
    {
        public Usuario(string nome, string sobrenome, string email, string senha, string telefone, string rg, string cpf, string cursando, string instituicao, string trabalho, string ondeTrabalha, string dataTrabalho, string descricao, string dataCurso, EnTipoUsuario tipoUsuario)
        {
            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotEmpty(nome, "Nome", "O campo nome não pode ser vazio")
                .IsNotEmpty(sobrenome, "Sobrenome", "O campo nome não pode ser vazio")
                .IsEmail(email, "Email", "formato incorreto de email")
                .IsGreaterThan(senha, 8, "Senha", "A senha deve ter 8 caracteres ou mais")
                .IsGreaterOrEqualsThan(telefone, 11, "Telefone", "O Telefone para contato deve ter 11 caracteres")
                .IsGreaterOrEqualsThan(rg, 10, "RG", "O RG deve ter 10 caracteres")
                .IsGreaterOrEqualsThan(cpf, 11, "CPF", "O CPF deve ter 11 caracteres")
                .IsNotEmpty(cursando, "Cursando", "Não é Obrigatório")
                .IsNotEmpty(instituicao, "Instituição", "Não é Obrigatório")
                .IsNotEmpty(trabalho, "Trabalho", "Não é Obrigatório")
                .IsNotEmpty(ondeTrabalha, "Local de Trabalho", "Não é Obrigatório")
                .IsNotEmpty(dataTrabalho, "Data Trabalho", "Não é Obrigatório")
                .IsNotEmpty(dataCurso, "Data", "Não é Obrigatório")
               

            );
            if (IsValid)
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
                TipoUsuario = tipoUsuario;
                Trabalho = trabalho;
                OndeTrabalha = ondeTrabalha;
                DataTrabalho = dataTrabalho;
                DataCurso = dataCurso;
            }

            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Senha = senha;
            Telefone = telefone;
            RG = rg;
            CPF = cpf;
            Cursando = cursando;
            Instituicao = instituicao;
            TipoUsuario = tipoUsuario;
            Trabalho = trabalho;
            OndeTrabalha = ondeTrabalha;
            DataTrabalho = dataTrabalho;
            DataCurso = dataCurso;
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string Telefone { get; private set; }
        public string RG { get; private set; }
        public string CPF { get; private set; }
        public string Descricao { get; set; }
        public string Cursando { get; set; }
        public string Instituicao { get; set; }
        public string DataCurso { get; set; }
        public string Trabalho { get; set; }
        public string OndeTrabalha { get; set; }
        public string DataTrabalho { get; set; }

        public EnTipoUsuario TipoUsuario { get; private set; }
    }
}
