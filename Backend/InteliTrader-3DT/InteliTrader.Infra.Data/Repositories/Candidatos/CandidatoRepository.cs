﻿using InteliTrader.Dominio.Entidades;
using InteliTrader.Dominio.Interfaces;
using InteliTrader.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Infra.Data.Repositories.Candidatos
{
    public class CandidatoRepository : ICandidatoRepository
    {
        private readonly InteliTraderContext _InteliContext;

        public CandidatoRepository(InteliTraderContext InteliContext)
        {
            _InteliContext = InteliContext;
        }
        public void Adicionar(Candidato candidato)
        {
            _InteliContext.Candidatos.Add(candidato);
            _InteliContext.SaveChanges();
        }

        public Candidato BuscarPorEmail(string email)
        {
            return _InteliContext.Candidatos.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
        }

        public Candidato BuscarPorId(Guid id)
        {
            return null;
        }

        public Candidato BuscarPorRg(int rg)
        {
            return null;
        }

        public void Deletar(Candidato candidato)
        {
            _InteliContext.Entry(candidato).State = EntityState.Modified;
            _InteliContext.SaveChanges();
        }

        public IEnumerable<Candidato> Listar(bool? ativo = null)
        {
            return _InteliContext.Candidatos
                .AsNoTracking()
                .ToList();
        }
    }
}
