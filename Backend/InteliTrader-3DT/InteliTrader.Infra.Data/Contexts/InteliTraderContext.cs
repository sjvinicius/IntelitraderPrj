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

        public DbSet<UsuarioLogin> Usuarios { get; set; }
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Vaga> Vagas { get; set; }
        public DbSet<TesteTecnico> TesteTecnicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();

            #region tabela Usuarios
            // Nome da Tabela
            modelBuilder.Entity<UsuarioLogin>().ToTable("Usuarios");

            //Id Chave Primaria
            modelBuilder.Entity<UsuarioLogin>().Property(x => x.Id);

            //Nome
            modelBuilder.Entity<UsuarioLogin>().Property(x => x.Nome).HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<UsuarioLogin>().Property(x => x.Nome).HasMaxLength(200);
            modelBuilder.Entity<UsuarioLogin>().Property(x => x.Nome).IsRequired();

            //Sobrenome
            modelBuilder.Entity<UsuarioLogin>().Property(x => x.Sobrenome).HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<UsuarioLogin>().Property(x => x.Sobrenome).HasMaxLength(200);
            modelBuilder.Entity<UsuarioLogin>().Property(x => x.Sobrenome).IsRequired();

            //Email
            modelBuilder.Entity<UsuarioLogin>().Property(x => x.Email).HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<UsuarioLogin>().Property(x => x.Email).HasMaxLength(200);
            modelBuilder.Entity<UsuarioLogin>().Property(x => x.Email).IsRequired();
            modelBuilder.Entity<UsuarioLogin>().HasIndex(x => x.Email).IsUnique();

            //Senha
            modelBuilder.Entity<UsuarioLogin>().Property(x => x.Senha).HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<UsuarioLogin>().Property(x => x.Senha).HasMaxLength(200);
            modelBuilder.Entity<UsuarioLogin>().Property(x => x.Senha).IsRequired();

            //TipoUsuario
            modelBuilder.Entity<UsuarioLogin>().Property(x => x.TipoUsuario).IsRequired();

            //DataCurso
            modelBuilder.Entity<UsuarioLogin>().Property(x => x.DataCriacao).HasDefaultValueSql("GETDATE()");
            #endregion

            #region Tabela Candidatos
            //Nome da tabela
            modelBuilder.Entity<Candidato>().ToTable("Candidatos");

            //Id Chave Primaria
            modelBuilder.Entity<Candidato>().Property(x => x.Nome);

            //Id Chave estrangeira Vaga
            modelBuilder.Entity<Candidato>()
                .HasOne<Vaga>(x => x.Vaga)
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
            //CPF
            modelBuilder.Entity<Candidato>().Property(x => x.CPF).HasMaxLength(200);
            modelBuilder.Entity<Candidato>().Property(x => x.CPF).HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Candidato>().Property(x => x.CPF).IsRequired();
            modelBuilder.Entity<Candidato>().HasIndex(x => x.CPF).IsUnique();
            //Email
            modelBuilder.Entity<Candidato>().Property(x => x.Email).HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Candidato>().Property(x => x.Email).HasMaxLength(200);
            modelBuilder.Entity<Candidato>().Property(x => x.Email).IsRequired();
            modelBuilder.Entity<Candidato>().HasIndex(x => x.Email).IsUnique();
            //Senha
            modelBuilder.Entity<Candidato>().Property(x => x.Senha).HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Candidato>().Property(x => x.Senha).HasMaxLength(200);
            modelBuilder.Entity<Candidato>().Property(x => x.Senha).IsRequired();
            //Curso
            modelBuilder.Entity<Candidato>().Property(x => x.Curso).HasMaxLength(50);
            modelBuilder.Entity<Candidato>().Property(x => x.Curso).HasColumnType("VARCHAR(50)");
            modelBuilder.Entity<Candidato>().Property(x => x.Curso).IsRequired();
            //Insitituição
            modelBuilder.Entity<Candidato>().Property(x => x.Instituicao).HasMaxLength(50);
            modelBuilder.Entity<Candidato>().Property(x => x.Instituicao).HasColumnType("VARCHAR(50)");
            modelBuilder.Entity<Candidato>().Property(x => x.Instituicao).IsRequired();
            //Periodo
            modelBuilder.Entity<Candidato>().Property(x => x.Periodo).HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Candidato>().Property(x => x.Periodo).HasMaxLength(200);
            modelBuilder.Entity<Candidato>().Property(x => x.Periodo).IsRequired();
            //InformaçõesComplementares
            modelBuilder.Entity<Candidato>().Property(x => x.InformacoesComplementares).HasMaxLength(80);
            modelBuilder.Entity<Candidato>().Property(x => x.InformacoesComplementares).HasColumnType("VARCHAR(80)");
            modelBuilder.Entity<Candidato>().Property(x => x.InformacoesComplementares).IsRequired();
            //Cargo
            modelBuilder.Entity<Candidato>().Property(x => x.Cargo).HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Candidato>().Property(x => x.Cargo).HasMaxLength(200);
            modelBuilder.Entity<Candidato>().Property(x => x.Cargo).IsRequired();
            //DataInicio
            modelBuilder.Entity<Candidato>().Property(x => x.AnoInicio).HasMaxLength(16);
            modelBuilder.Entity<Candidato>().Property(x => x.AnoInicio).HasColumnType("VARCHAR(16)");
            //DataFim
            modelBuilder.Entity<Candidato>().Property(x => x.AnoFim).HasMaxLength(16);
            modelBuilder.Entity<Candidato>().Property(x => x.AnoFim).HasColumnType("VARCHAR(16)");
            //TipoUsuario
            modelBuilder.Entity<Candidato>().Property(x => x.TipoUsuario).IsRequired();
            #endregion

            #region Tabela Vagas
            //Nome Tabela
            modelBuilder.Entity<Vaga>().ToTable("Vaga");

            //ID Chave Primária
            modelBuilder.Entity<Vaga>().Property(x => x.Id);

            //Nome Vaga
            modelBuilder.Entity<Vaga>().Property(x => x.NomeVaga).HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Vaga>().Property(x => x.NomeVaga).HasMaxLength(200);
            modelBuilder.Entity<Vaga>().Property(x => x.NomeVaga).IsRequired();
            modelBuilder.Entity<Vaga>().HasIndex(x => x.NomeVaga).IsUnique();

            //Data Criação
            modelBuilder.Entity<Vaga>().Property(x => x.DataCriacao).HasDefaultValueSql("GETDATE()");

            // DML - dados padrões
            modelBuilder.Entity<Vaga>().HasData(
                new Vaga("Vaga Estágio Back-End","Estágio para BackEnd Exigindo conhecimento em : C#, .NET, ASP.NETCORE,Manipulação de API REST",InteliTrader.Comum.Enum.EnVagaSituacao.VagaPublicada),
                new Vaga("Vaga Dev Junior Front End", "Vaga para FrontEnd Junior Exigindo conhecimento em : HTML, CSS,JavaScript", InteliTrader.Comum.Enum.EnVagaSituacao.VagaPublicada),
                new Vaga("Vaga Dev Sênior Back End", "Vaga para BackEnd Sênior Exigindo conhecimento em : PYTHON, Criação e Manipulação de API REST,node.js", InteliTrader.Comum.Enum.EnVagaSituacao.VagaPublicada)
                );
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
