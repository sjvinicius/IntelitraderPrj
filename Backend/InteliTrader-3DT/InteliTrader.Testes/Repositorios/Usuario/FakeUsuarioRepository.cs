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
        public void Adicionar(Dominio.Entidades.UsuarioLogin usuario)
        {
            
        }

        public void Alterar(Dominio.Entidades.UsuarioLogin usuario)
        {
            
        }

        public Dominio.Entidades.UsuarioLogin BuscarPorEmail(string email)
        {
            return null;
        }

        public Dominio.Entidades.UsuarioLogin BuscarPorId(Guid id)
        {
            return new Dominio.Entidades.UsuarioLogin("Paulo","Grandão", "paulobrandaoofficial@gmail.com","pastel231",InteliTrader.Comum.Enum.EnTipoUsuario.Candidato);
        }

        public void Deletar(Guid id)
        {
            
        }

        public IEnumerable<Dominio.Entidades.UsuarioLogin> Listar(bool? ativo = null)
        {
            return null;
        }
    }
}
