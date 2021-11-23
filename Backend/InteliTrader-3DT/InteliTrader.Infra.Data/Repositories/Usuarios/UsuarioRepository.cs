using InteliTrader.Dominio.Entidades;
using InteliTrader.Dominio.Interfaces;
using InteliTrader.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Infra.Data.Repositorio
{
   public class UsuarioRepository : IUsuarioRepository
    {
        //Injeção de Dependência
        private readonly InteliTraderContext _context;

        public UsuarioRepository(InteliTraderContext context)
        {
            _context = context;
        }

        //Commands 
        public void Adicionar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Alterar(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Usuario BuscarPorEmail(string email)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
        }

        public Usuario BuscarPorId(Guid id)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public void Deletar(Guid id)
        {
            _context.Usuarios.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }

        public ICollection<Usuario> Listar(bool? ativo = null)
        {
            return _context.Usuarios
                .AsNoTracking() // Somente Leitura sem salvar cache do context
                .Include(x => x.TipoUsuario)
                .OrderBy(x => x.DataCriacao)
                .ToList();
        }

        IEnumerable<Usuario> IUsuarioRepository.Listar(bool? ativo)
        {
            throw new NotImplementedException();
        }
    }
}
