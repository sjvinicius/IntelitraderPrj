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
    public class CriarFuncionarioCommand : Notifiable<Notification>, ICommand
    {
        public CriarFuncionarioCommand()
        {

        }

        public CriarFuncionarioCommand(string nome, string sobrenome, string email, string senha, EnTipoUsuario tiposUsuario)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Senha = senha;
            TiposUsuario = tiposUsuario;
        }

        public string Nome { get; set; }
        public string Sobrenome { get;  set; }
        public string Email { get;  set; }
        public string Senha { get;  set; }
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
            );
        }
    }
}
