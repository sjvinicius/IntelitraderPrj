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
        public void Adicionar(Dominio.Entidades.Vaga vagas)
        {
            
        }

        public void Alterar(Dominio.Entidades.Vaga vagas)
        {
            throw new NotImplementedException();
        }

        public Dominio.Entidades.Vaga BuscarPorId(Guid id)
        {
            return new Dominio.Entidades.Vaga("Desenvolvimento de sistemas","", InteliTrader.Comum.Enum.EnVagaSituacao.VagaPublicada,"48%");
          
        }

        public Dominio.Entidades.Vaga BuscarPorNome(string nome)
        {
            return null;
        }
        public void Deletar(Dominio.Entidades.Vaga vagas)
        {
            
        }

        public IEnumerable<Dominio.Entidades.Vaga> Listar()
        {
            return null;
        }
    }
}
