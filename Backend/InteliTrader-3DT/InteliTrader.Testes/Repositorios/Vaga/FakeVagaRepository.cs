using InteliTrader.Dominio.Entidades;
using InteliTrader.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Testes.Repositorios.Vaga
{
    public class FakeVagaRepository : IVagasRepository
    {
        public void Adicionar(Vagas vagas)
        {
            throw new NotImplementedException();
        }

        public void Alterar(Vagas vagas)
        {
            throw new NotImplementedException();
        }

        public Vagas BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Vagas vagas)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vagas> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
