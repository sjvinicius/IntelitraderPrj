using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InteliTrader.Dominio.Entidades;
using InteliTrader.Dominio.Interfaces;

namespace InteliTrader.Testes.Repositorios
{
    public class FakeUsuarioRepositorio : IUsuarioRepository
    {
        public void Adicionar(Usuario usuario)
        {
            
        }

        public void Alterar(Usuario usuario)
        {
           
        }

        public Usuario BuscarPorEmail(string email)
        {
            if (email == "email@email.com")
                return new Usuario("Marcos",
                "Roberto",
                "email@email.com",
                "pastel23456",
                "22362428915",
                "374372681",
                "1194728356",
                "Tenho 25 anos e sou recém formado na aréa de tecnologia, estou em busca de uma oportunidade onde eu possa compartilhar meus conhecimentos aplicando no ambiente de trabalho e aprendendo mais com profissionais capacitados.",
                "Técnico de Desenvolvimento de Sistemas",
                "Escola SENAI são caetano",
                "01/2019 - 01/2020",
                "",
                InteliTrader.Comum.Enum.EnTipoUsuario.Candidato);
            else
                return null;
        }

        public Usuario BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            
        }

        public ICollection<Usuario> Listar()
        {
            return new List<Usuario>()
            {
                new Usuario("Ruan","Gustavo","RuanGostoso@gmail.com","caldodecana24","24352478913","11940759338","Tenho 20 anos e sou recém formado na aréa de tecnologia, estou em busca de uma oportunidade onde eu possa compartilhar meus conhecimentos aplicando no ambiente de trabalho e aprendendo mais com profissionais capacitados.",
                "24.536.578-2",
                "Técnico de Desenvolvimento de Sistemas",
                "Escola SENAI de Informática",
                "01/2019 - 01/2020",
                "Lorenzetti S/A Indústrias Metralúrgicas-Jovem Aprendiz", 
                InteliTrader.Comum.Enum.EnTipoUsuario.Candidato),

                new Usuario("Marcos",
                "Roberto",
                "RobertoMarcos@gmail.com",
                "pastel23456",
                "22362428915",
                "374372681",
                "1194728356",
                "Tenho 25 anos e sou recém formado na aréa de tecnologia, estou em busca de uma oportunidade onde eu possa compartilhar meus conhecimentos aplicando no ambiente de trabalho e aprendendo mais com profissionais capacitados.",
                "Técnico de Desenvolvimento de Sistemas",
                "Escola SENAI são caetano",
                "01/2019 - 01/2020",
                "", 
                InteliTrader.Comum.Enum.EnTipoUsuario.Candidato)
            };
        }

        public ICollection<Usuario> Listar(bool? ativo = null)
        {
            throw new NotImplementedException();
        }
    }
}
