using InteliTrader.Dominio.Entidades;
using InteliTrader.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InteliTrader.Dominio.Interfaces;

namespace InteliTrader.Infra.Data.Repositories.Vagas
{
    public class VagasRepository : IVagasRepository

    {
      //Injetando Dependencias
       private readonly InteliTraderContext _InteliContext;

        public VagasRepository(InteliTraderContext ctx)
        {
            _InteliContext = ctx;
        }

        //Commands
        public void Adicionar(Dominio.Entidades.Vagas vagas) 
        {
            _InteliContext.Vagas.Add(vagas);
            _InteliContext.SaveChanges();
        }

        public void Alterar(Dominio.Entidades.Vagas vagas)
        {
            _InteliContext.Entry(vagas).State = EntityState.Modified;
            _InteliContext.SaveChanges();
        }


        public void Deletar(Dominio.Entidades.Vagas vagas)
        {
            _InteliContext.Vagas.Remove(vagas);
            _InteliContext.SaveChanges();
        }


        //Querys
        public IEnumerable<Dominio.Entidades.Vagas> Listar()
        {
            return _InteliContext.Vagas
                .AsNoTracking()
                .ToList();
        }
        public Dominio.Entidades.Vagas BuscarPorId(Guid id)
        {
            return _InteliContext.Vagas.FirstOrDefault(x => x.Id == id);
        }

        public Dominio.Entidades.Vagas BuscarPorNome(string nome)
        {
            return _InteliContext.Vagas.AsNoTracking().FirstOrDefault(x => x.NomeVaga == nome);
        }
    }
}
