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
            
        }

        public void Alterar(Vagas vagas)
        {
            throw new NotImplementedException();
        }

        public Vagas BuscarPorId(Guid id)
        {
            return new Vagas("Desenvolvimento de sistemas","",InteliTrader.Comum.Enum.EnVagaSituacao.VagaPublicada,"48%");
          
        }

        public Vagas BuscarPorNome(string nome)
        {
            return null;
        }
        public void Deletar(Vagas vagas)
        {
            
        }

        public IEnumerable<Vagas> Listar()
        {
            return null;
        }
    }
}
