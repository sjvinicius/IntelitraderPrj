using Flunt.Notifications;
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
        public CriarUsuarioCommand(string nome, string sobrenome, string email, string senha, string telefone, string rg, string cpf, string descricao, string cursando, string instituicao, string trabalho, string ondeTrabalha,EnTipoUsuario tipoUsuario)
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
        }

        
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string Telefone { get; private set; }
        public string RG { get; private set; }
        public string CPF { get; private set; }
        public string Descricao { get; private set; }
        public string Cursando { get; private set; }
        public string Instituicao { get; private set; }
        public string Trabalho { get; private set; }
        public string OndeTrabalha { get; private set; }
        public EnTipoUsuario TiposUsuario { get; private set; }
      

        public void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
