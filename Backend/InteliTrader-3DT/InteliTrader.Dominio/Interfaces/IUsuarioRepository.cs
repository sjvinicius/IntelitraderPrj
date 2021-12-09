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
        void Adicionar(UsuarioLogin usuario);
        void Deletar(Guid id);
        void Alterar(UsuarioLogin usuario);
        //Queries
        IEnumerable<UsuarioLogin> Listar(bool? ativo = null);

        UsuarioLogin BuscarPorId(Guid id);
        UsuarioLogin BuscarPorEmail(string email);
    }
}
