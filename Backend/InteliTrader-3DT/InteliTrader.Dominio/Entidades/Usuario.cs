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
        public Usuario()
        {

        }

        public Usuario(string nome, string sobrenome, string email, string senha, string rg, string cpf, string telefone, string descricao, string cursando, string instituicao, string trabalho, string ondeTrabalha, EnTipoUsuario tipoUsuario)
        {
            AddNotifications(
                  new Contract<Notification>()
                      .Requires()
                      .IsNotEmpty(nome, "Nome", "O campo nome não pode ser vazio")
                      .IsNotEmpty(sobrenome, "Sobrenome", "O campo nome não pode ser vazio")
                      .IsEmail(email, "Email", "formato incorreto de email")
                      .IsGreaterThan(senha, 12, "Senha", "A senha deve ter 8 caracteres ou mais")
                      .IsGreaterThan(telefone, 16, "Telefone", "O Telefone deve ter 11 caracteres")
                      .IsGreaterThan(rg, 16, "RG", "O RG deve ter 10 caracteres")
                      .IsGreaterThan(cpf, 16, "CPF", "O CPF deve ter 11 caracteres")
                      .IsNotEmpty(descricao, "Descricao", "O campo Descricao não pode ser vazio")
                      .IsNotEmpty(cursando, "Cursando", "O campo Cursando não pode ser vazio")
                      .IsNotEmpty(instituicao, "Instituicao", "O campo Instituicao não pode ser vazio")
                      .IsNotEmpty(trabalho, "Trabalho", "O campo trabalho não pode ser vazio")
                      .IsNotEmpty(ondeTrabalha, "OndeTrabalha", "O campo onde Trabalha não pode ser vazio")
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
                Trabalho = trabalho;
                OndeTrabalha = ondeTrabalha;
                TipoUsuario = tipoUsuario;
            }           
        }

        public string Nome { get;  set; }
        public string Sobrenome { get;   set; }
        public string Email { get;  set; }
        public string Senha { get;  set; }
        public string RG { get;  set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Descricao { get;  set; }
        public string Cursando { get;  set; }
        public string Instituicao { get;  set; }
        public string Trabalho { get;  set; }
        public string OndeTrabalha { get;  set; }
        public EnTipoUsuario TipoUsuario { get; private set; }
    }
}
