using InteliTrader.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Interfaces
{
    public interface IUsuarioRepository
    {
        //commands
        void Adicionar(Usuario usuario);
        void Deletar(Guid id);
        void Alterar(Usuario usuario);
        //Queries
        IEnumerable<Usuario> Listar();

        Usuario BuscarPorId(Guid id);
        Usuario BuscarPorEmail(string email);
    }
}
