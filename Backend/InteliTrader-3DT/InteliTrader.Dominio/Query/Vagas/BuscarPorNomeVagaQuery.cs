using Flunt.Notifications;
using Flunt.Validations;
using InteliTrader.Shared.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Query.Vagas
{
    public class BuscarPorNomeVagaQuery : Notifiable<Notification>, IQuery
    {
        public string NomeVaga { get; set; }

        public void Validar()
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsNotEmpty(NomeVaga, "Nome Vaga", "O nome da Vaga buscada não pode ser vazio!")
                );
        }

        public class BuscarPorNomeResult
        {
            public Guid Id { get; set; }
            public string NomeVaga { get; set; }
            public DateTime DataCriacao { get; set; }
        }
    }
}
