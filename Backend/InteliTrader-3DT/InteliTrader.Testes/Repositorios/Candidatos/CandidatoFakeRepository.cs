using InteliTrader.Dominio.Entidades;
using InteliTrader.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Testes.Repositorios.Candidatos
{
    public class CandidatoFakeRepository : ICandidatoRepository
    {
        public void Adicionar(Candidato candidato)
        {
            
        }

        public Candidato BuscarPorEmail(string email)
        {
            return null;
        }

        public Candidato BuscarPorId(Guid id)
        {
            return new Dominio.Entidades.Candidato("João Gustavo", "Cavalcante Da Silva", "34276587689", "joãogustavo@gmail.com", "caldodecana231", "DEV SISTEMAS", "SENAI-INFORMÁTICA", "MANHA", "procurando meu primeiro emprego na area de Dev", "Dev Back-End", "N/F","2013","2014",Comum.Enum.EnTipoUsuario.Candidato,Guid.Empty);
        }

        public void Deletar(Candidato candidato)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Candidato> Listar(bool? ativo = null)
        {
            return null;
        }
    }
}
