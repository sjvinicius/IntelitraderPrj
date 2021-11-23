using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InteliTrader.Dominio.Interfaces;

namespace InteliTrader.Testes.Repositorios.Usuario
{
    public class FakeUsuarioRepository : IUsuarioRepository
    {
        public void Adicionar(Dominio.Entidades.Usuario usuario)
        {
            
        }

        public void Alterar(Dominio.Entidades.Usuario usuario)
        {
            
        }

        public Dominio.Entidades.Usuario BuscarPorEmail(string email)
        {
            return null;
        }

        public Dominio.Entidades.Usuario BuscarPorId(Guid id)
        {
            return new Dominio.Entidades.Usuario("Lucas","Nogueira","nogueirapaz@email.com","pastel234","534625861","46732305824","11970520234","Procurando meu Primeiro emprego","Dev Sistemas","Senai Diadema","N/A","N/A",InteliTrader.Comum.Enum.EnTipoUsuario.Candidato);
        }

        public void Deletar(Guid id)
        {
            
        }

        public IEnumerable<Dominio.Entidades.Usuario> Listar(bool? ativo = null)
        {
            return null;
        }
    }
}
