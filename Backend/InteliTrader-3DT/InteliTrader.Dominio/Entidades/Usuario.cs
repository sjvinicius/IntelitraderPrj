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
        public Usuario(string nome, string sobrenome, string email, string senha, int rg, int cpf,int telefone, string descricao, string cursando, string instituicao, string dataCurso, string trabalho, string ondeTrabalha, string dataTrabalho, EnTipoUsuario tipoUsuario)
        {
            AddNotifications(
               new Contract<Notification>()
                   .Requires()
                   .IsNotEmpty(nome, "Nome", "O campo nome não pode ser vazio")
                   .IsNotEmpty(sobrenome, "Sobrenome", "O campo nome não pode ser vazio")
                   .IsEmail(email, "Email", "formato incorreto de email")
                   .IsGreaterThan(senha, 8, "Senha", "A senha deve ter 8 caracteres ou mais")
                   .IsGreaterOrEqualsThan(rg, 10, "RG", "O RG deve ter 10 caracteres")
                   .IsGreaterOrEqualsThan(cpf, 11, "CPF", "O CPF deve ter 11 caracteres")
                   .IsGreaterOrEqualsThan(telefone, 11, "Telefone", "O Telefone deve ter 11 caracteres")
                   .IsNotEmpty(descricao, "Descricao", "O campo Descricao não pode ser vazio")
                   .IsNotEmpty(cursando, "Cursando", "O campo Cursando não pode ser vazio")
                   .IsNotEmpty(instituicao, "Instituicao", "O campo Instituicao não pode ser vazio")
                   .IsNotEmpty(dataCurso, "DataCurso", "O campo Data Curso não pode ser vazio")
                   .IsNotEmpty(trabalho, "Trabalho", "O campo trabalho não pode ser vazio")
                   .IsNotEmpty(ondeTrabalha, "OndeTrabalha", "O campo onde Trabalha não pode ser vazio")
                   .IsNotEmpty(dataTrabalho, "DataTrabalho", "O campo Data Trabalho não pode ser vazio")
               );
            if (IsValid)
            {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Senha = senha;
            RG = rg;
            CPF = cpf;
            Descricao = descricao;
            Cursando = cursando;
            Instituicao = instituicao;
            DataCurso = dataCurso;
            Trabalho = trabalho;
            OndeTrabalha = ondeTrabalha;
            DataTrabalho = dataTrabalho;
            TipoUsuario = tipoUsuario;
            }
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private  set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public int RG { get; private set; }
        public int CPF { get; private set; }
        public int Telefone { get; set; }
        public string Descricao { get; private set; }
        public string Cursando { get; private set; }
        public string Instituicao { get; private set; }
        public string DataCurso { get; private set; }
        public string Trabalho { get; private set; }
        public string OndeTrabalha { get; private set; }
        public string DataTrabalho { get; private set; }
        public EnTipoUsuario TipoUsuario { get; private set; }
    }
}
