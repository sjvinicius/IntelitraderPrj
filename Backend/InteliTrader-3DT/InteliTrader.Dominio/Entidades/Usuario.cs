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
        public Usuario(string nome, string email, string senha, string rg, string cpf, EnTipoUsuario tipoUsuario)
        {
            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotEmpty(nome, "Nome", "O campo nome não pode ser vazio")
                .IsEmail(email, "Email", "formato incorreto de email")
                .IsGreaterThan(senha, 8, "Senha", "A senha deve ter 8 caracteres ou mais")
                .IsGreaterOrEqualsThan(rg, 10, "RG", "O RG deve ter 10 caracteres")
                .IsGreaterOrEqualsThan(cpf, 11, "CPF", "O CPF deve ter 11 caracteres")   
            );
            if (IsValid)
            {
                Nome = nome;
                Email = email;
                Senha = senha;
                RG = rg;
                CPF = cpf;
                TipoUsuario = tipoUsuario;
            }

            Nome = nome;
            Email = email;
            Senha = senha;
            RG = rg;
            CPF = cpf;
            TipoUsuario = tipoUsuario;
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string RG { get; private set; }
        public string CPF { get; private set; }
        public EnTipoUsuario TipoUsuario { get; private set; }
    }
}
