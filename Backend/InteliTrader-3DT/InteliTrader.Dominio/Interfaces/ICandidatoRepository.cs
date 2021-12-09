using InteliTrader.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Dominio.Interfaces
{
    public interface ICandidatoRepository
    {
        //Commands
        void Adicionar(Candidato candidato);
        void Deletar(Candidato candidato);
        //Queries
        IEnumerable<Candidato> Listar(bool? ativo = null);
        Candidato BuscarPorId(Guid id);
        Candidato BuscarPorEmail(string email);
    }
}
