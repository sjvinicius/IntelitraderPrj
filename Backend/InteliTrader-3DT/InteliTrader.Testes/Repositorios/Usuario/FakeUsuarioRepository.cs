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
            return new Dominio.Entidades.Usuario("Paulo","Grandão", "paulobrandaoofficial@gmail.com", "pastel2345","534625861","38475948356","11947586934","Procurando meu Primeiro emprego","Dev Sistemas","Senai Diadema","N/A","N/A",InteliTrader.Comum.Enum.EnTipoUsuario.Candidato);
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
