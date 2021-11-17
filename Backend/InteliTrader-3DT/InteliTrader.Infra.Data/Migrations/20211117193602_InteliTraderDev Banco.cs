using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InteliTrader.Infra.Data.Migrations
{
    public partial class InteliTraderDevBanco : Migration
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
                    Senha = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    RG = table.Column<string>(type: "VARCHAR(16)", maxLength: 16, nullable: false),
                    CPF = table.Column<string>(type: "VARCHAR(16)", maxLength: 16, nullable: false),
                    Telefone = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false),
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
                    PorcentagemSucesso = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                columns: new[] { "Id", "DataCriacao", "Descricao", "NomeVaga", "PorcentagemSucesso", "SituacaoVaga" },
                values: new object[] { new Guid("0bf9dd6e-26c0-4301-a5aa-b0ff2e8e608c"), new DateTime(2021, 11, 17, 16, 36, 2, 410, DateTimeKind.Local).AddTicks(782), "Estágio para BackEnd Exigindo conhecimento em : C#, .NET, ASP.NETCORE,Manipulação de API REST", "Vaga Estágio Back-End", "35%", 1 });

            migrationBuilder.InsertData(
                table: "Vagas",
                columns: new[] { "Id", "DataCriacao", "Descricao", "NomeVaga", "PorcentagemSucesso", "SituacaoVaga" },
                values: new object[] { new Guid("fac88a9b-d11b-4221-87fa-c281c1ac8d12"), new DateTime(2021, 11, 17, 16, 36, 2, 411, DateTimeKind.Local).AddTicks(4890), "Vaga para FrontEnd Junior Exigindo conhecimento em : HTML, CSS,JavaScript", "Vaga Dev Junior Front End", "28%", 1 });

            migrationBuilder.InsertData(
                table: "Vagas",
                columns: new[] { "Id", "DataCriacao", "Descricao", "NomeVaga", "PorcentagemSucesso", "SituacaoVaga" },
                values: new object[] { new Guid("36a07eef-1826-4952-845b-afe36a8d2f17"), new DateTime(2021, 11, 17, 16, 36, 2, 411, DateTimeKind.Local).AddTicks(4915), "Vaga para BackEnd Sênior Exigindo conhecimento em : PYTHON, Criação e Manipulação de API REST,node.js", "Vaga Dev Sênior Back End", "42%", 1 });

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
