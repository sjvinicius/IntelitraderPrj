using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InteliTrader.Infra.Data.Migrations
{
    public partial class InteliTraderDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TesteTecnicos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TesteTecnicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Sobrenome = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(8)", maxLength: 8, nullable: false),
                    RG = table.Column<string>(type: "VARCHAR(9)", maxLength: 9, nullable: false),
                    CPF = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: false),
                    Telefone = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Cursando = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Instituicao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trabalho = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    OndeTrabalha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoUsuario = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vagas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeVaga = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SituacaoVaga = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vagas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Candidatos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Sobrenome = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Personalidade = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    Funcao = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Situacao = table.Column<int>(type: "int", nullable: false),
                    IdVaga = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidatos_Vagas_IdVaga",
                        column: x => x.IdVaga,
                        principalTable: "Vagas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Vagas",
                columns: new[] { "Id", "DataCriacao", "Descricao", "NomeVaga", "SituacaoVaga" },
                values: new object[] { new Guid("af5a09c9-6551-4125-bc88-428c26a7f418"), new DateTime(2021, 11, 26, 16, 31, 18, 821, DateTimeKind.Local).AddTicks(8280), "Estágio para BackEnd Exigindo conhecimento em : C#, .NET, ASP.NETCORE,Manipulação de API REST", "Vaga Estágio Back-End", 1 });

            migrationBuilder.InsertData(
                table: "Vagas",
                columns: new[] { "Id", "DataCriacao", "Descricao", "NomeVaga", "SituacaoVaga" },
                values: new object[] { new Guid("04e3b42f-3af4-4f62-a8e1-d6039c88728b"), new DateTime(2021, 11, 26, 16, 31, 18, 823, DateTimeKind.Local).AddTicks(2393), "Vaga para FrontEnd Junior Exigindo conhecimento em : HTML, CSS,JavaScript", "Vaga Dev Junior Front End", 1 });

            migrationBuilder.InsertData(
                table: "Vagas",
                columns: new[] { "Id", "DataCriacao", "Descricao", "NomeVaga", "SituacaoVaga" },
                values: new object[] { new Guid("a419b1a1-73b5-4a49-b5b6-f9527a181fd2"), new DateTime(2021, 11, 26, 16, 31, 18, 823, DateTimeKind.Local).AddTicks(2424), "Vaga para BackEnd Sênior Exigindo conhecimento em : PYTHON, Criação e Manipulação de API REST,node.js", "Vaga Dev Sênior Back End", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Candidatos_IdVaga",
                table: "Candidatos",
                column: "IdVaga");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vagas_NomeVaga",
                table: "Vagas",
                column: "NomeVaga",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidatos");

            migrationBuilder.DropTable(
                name: "TesteTecnicos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Vagas");
        }
    }
}
