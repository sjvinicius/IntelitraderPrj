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
        void Adicionar(Vaga vagas);
        void Alterar(Vaga vagas);
        void Deletar(Vaga vagas);
        //queries
        IEnumerable<Vaga> Listar();
        Vaga BuscarPorId(Guid id);
        Vaga BuscarPorNome(string nome);
    }
}
