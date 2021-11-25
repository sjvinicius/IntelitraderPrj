using Flunt.Notifications;
using Flunt.Validations;
using InteliTrader.Shared.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Querie.Vagas
{
   public class BuscarPorIdVagaQuery : Notifiable<Notification>, IQuery
    {
        public Guid Id { get; set; }

        public void Validar()
        {
            AddNotifications(
                 new Contract<Notification>()
                     .Requires()
                     .IsNotEmpty(Id, "id", "O id do curso buscado não pode ser vazio!")
                 );
        }

        public class BuscarPorIdResult
        {
            public Guid Id { get; set; }
            public string NomeVaga { get; set; }
            public DateTime DataCriacao { get; set; }
        }
    }
}
