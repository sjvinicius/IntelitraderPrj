using InteliTrader.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Interfaces
{
    public interface IVagasRepository
    {
        //commands
        void Adicionar(Vagas vagas);
        void Alterar(Vagas vagas);
        void Deletar(Vagas vagas);
        //queries
        IEnumerable<Vagas> Listar();
        Vagas BuscarPorId(Guid id);
    }
}
