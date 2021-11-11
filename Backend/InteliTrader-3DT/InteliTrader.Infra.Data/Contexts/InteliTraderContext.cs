using Flunt.Notifications;
using InteliTrader.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Infra.Data.Contexts
{
    public class InteliTraderContext : DbContext
    {
        public InteliTraderContext(DbContextOptions<InteliTraderContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Vaga> Vagas { get; set; }
        public DbSet<TesteTecnico> TesteTecnicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();

            #region tabela Usuarios
            // Nome da Tabela
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");

            //Id Chave Primaria
            modelBuilder.Entity<Usuario>().Property(x => x.Id);

            //Nome
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).HasMaxLength(200);
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).IsRequired();

            //Sobrenome
            modelBuilder.Entity<Usuario>().Property(x => x.Sobrenome).HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Usuario>().Property(x => x.Sobrenome).HasMaxLength(200);
            modelBuilder.Entity<Usuario>().Property(x => x.Sobrenome).IsRequired();

            //Email
            modelBuilder.Entity<Usuario>().Property(x => x.Email).HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Usuario>().Property(x => x.Email).HasMaxLength(200);
            modelBuilder.Entity<Usuario>().Property(x => x.Email).IsRequired();
            modelBuilder.Entity<Usuario>().HasIndex(x => x.Email).IsUnique();

            //Senha
            modelBuilder.Entity<Usuario>().Property(x => x.Senha).HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Usuario>().Property(x => x.Senha).HasMaxLength(200);
            modelBuilder.Entity<Usuario>().Property(x => x.Senha).IsRequired();

            //RG
            modelBuilder.Entity<Usuario>().Property(x => x.RG).HasColumnType("INT");
            modelBuilder.Entity<Usuario>().Property(x => x.RG).IsRequired();
            //CPF
            modelBuilder.Entity<Usuario>().Property(x => x.CPF).HasColumnType("INT");
            modelBuilder.Entity<Usuario>().Property(x => x.CPF).IsRequired();
            //Telefone
            modelBuilder.Entity<Usuario>().Property(x => x.Telefone).HasMaxLength(15);
            modelBuilder.Entity<Usuario>().Property(x => x.Telefone).HasColumnType("varchar(15)");
            modelBuilder.Entity<Usuario>().Property(x => x.Telefone).IsRequired();
            //Descrição
            modelBuilder.Entity<Usuario>().Property(x => x.Descricao).HasMaxLength(80);
            modelBuilder.Entity<Usuario>().Property(x => x.Descricao).HasColumnType("varchar(80)");
            modelBuilder.Entity<Usuario>().Property(x => x.Descricao).IsRequired();
            //Cursando
            modelBuilder.Entity<Usuario>().Property(x => x.Cursando).HasMaxLength(50);
            modelBuilder.Entity<Usuario>().Property(x => x.Cursando).HasColumnType("varchar(50)");
            modelBuilder.Entity<Usuario>().Property(x => x.Cursando).IsRequired();
            //Instituição
            modelBuilder.Entity<Usuario>().Property(x => x.Cursando).HasMaxLength(50);
            modelBuilder.Entity<Usuario>().Property(x => x.Cursando).HasColumnType("varchar(50)");
            modelBuilder.Entity<Usuario>().Property(x => x.Cursando).IsRequired();
            //TipoUsuario
            modelBuilder.Entity<Usuario>().Property(x => x.TipoUsuario).IsRequired();

            //DataCurso
            modelBuilder.Entity<Usuario>().Property(x => x.DataCriacao).HasDefaultValueSql("GETDATE()");

            //Trabalho
            modelBuilder.Entity<Usuario>().Property(x => x.Trabalho).HasMaxLength(50);
            modelBuilder.Entity<Usuario>().Property(x => x.Trabalho).HasColumnType("varchar(50)");
            //Onde Trabalho 
            modelBuilder.Entity<Usuario>().Property(x => x.DataCriacao).HasDefaultValueSql("GETDATE()");

            //Data Trabalho
            modelBuilder.Entity<Usuario>().Property(x => x.DataCriacao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region Tabela Candidatos
            //Nome da tabela
            modelBuilder.Entity<Candidato>().ToTable("Candidatos");

            //Id Chave Primaria
            modelBuilder.Entity<Candidato>().Property(x => x.Nome);

            //Id Chave estrangeira Vaga
            modelBuilder.Entity<Candidato>()
                .HasOne<Vaga>(x => x.Vagas)
                .WithMany(x => x.Candidatos)
                .HasForeignKey(x => x.IdVaga);

            //Nome
            modelBuilder.Entity<Candidato>().Property(x => x.Nome).HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Candidato>().Property(x => x.Nome).HasMaxLength(200);
            modelBuilder.Entity<Candidato>().Property(x => x.Nome).IsRequired();

            //Sobrenome
            modelBuilder.Entity<Candidato>().Property(x => x.Sobrenome).HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Candidato>().Property(x => x.Sobrenome).HasMaxLength(200);
            modelBuilder.Entity<Candidato>().Property(x => x.Sobrenome).IsRequired();
            //Personalidade
            modelBuilder.Entity<Candidato>().Property(x => x.Personalidade).HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Candidato>().Property(x => x.Personalidade).HasMaxLength(200);
            modelBuilder.Entity<Candidato>().Property(x => x.Personalidade);
            //Função
            modelBuilder.Entity<Candidato>().Property(x => x.Funcao).HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Candidato>().Property(x => x.Funcao).HasMaxLength(200);
            modelBuilder.Entity<Candidato>().Property(x => x.Funcao).IsRequired();
            #endregion
        }
    }
}
