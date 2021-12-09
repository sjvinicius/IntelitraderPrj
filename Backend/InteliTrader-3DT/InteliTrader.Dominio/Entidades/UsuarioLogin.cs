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
    public class UsuarioLogin : Base
    {
        public UsuarioLogin()
        {

        }

        public UsuarioLogin(string nome, string sobrenome, string email, string senha, EnTipoUsuario tipoUsuario)
        {
            AddNotifications(
                  new Contract<Notification>()
                      .Requires()
                      .IsNotEmpty(nome, "Nome", "O campo nome não pode ser vazio")
                      .IsNotEmpty(sobrenome, "Sobrenome", "O campo nome não pode ser vazio")
                      .IsEmail(email, "Email", "formato incorreto de email")
                      .IsGreaterThan(senha, 8, "Senha", "A senha deve ter 8 caracteres ou mais")
   
                  ); 
            if (IsValid)
            {
                Nome = nome;
                Sobrenome = sobrenome;
                Email = email;
                Senha = senha;
                TipoUsuario = tipoUsuario;
            }           
        }

        public string Nome { get;  set; }
        public string Sobrenome { get;   set; }
        public string Email { get;  set; }
        public string Senha { get;  set; }
        public EnTipoUsuario TipoUsuario { get; private set; }
    }
}
