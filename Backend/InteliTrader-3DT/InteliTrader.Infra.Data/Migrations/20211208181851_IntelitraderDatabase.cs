using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InteliTrader.Infra.Data.Migrations
{
    public partial class IntelitraderDatabase : Migration
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
                    TipoUsuario = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vaga",
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
                    table.PrimaryKey("PK_Vaga", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Candidatos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Sobrenome = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    CPF = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Curso = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Instituicao = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Periodo = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    InformacoesComplementares = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: false),
                    Cargo = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Empresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnoInicio = table.Column<string>(type: "VARCHAR(16)", maxLength: 16, nullable: true),
                    AnoFim = table.Column<string>(type: "VARCHAR(16)", maxLength: 16, nullable: true),
                    TipoUsuario = table.Column<int>(type: "int", nullable: false),
                    Situacao = table.Column<int>(type: "int", nullable: false),
                    IdVaga = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidatos_Vaga_IdVaga",
                        column: x => x.IdVaga,
                        principalTable: "Vaga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Vaga",
                columns: new[] { "Id", "DataCriacao", "Descricao", "NomeVaga", "SituacaoVaga" },
                values: new object[] { new Guid("e0099b32-d96f-49c0-81ba-e3d61ac4719b"), new DateTime(2021, 12, 8, 15, 18, 51, 39, DateTimeKind.Local).AddTicks(3238), "Estágio para BackEnd Exigindo conhecimento em : C#, .NET, ASP.NETCORE,Manipulação de API REST", "Vaga Estágio Back-End", 1 });

            migrationBuilder.InsertData(
                table: "Vaga",
                columns: new[] { "Id", "DataCriacao", "Descricao", "NomeVaga", "SituacaoVaga" },
                values: new object[] { new Guid("67e0f3f8-be3f-4ebc-bb5b-888577476dc8"), new DateTime(2021, 12, 8, 15, 18, 51, 42, DateTimeKind.Local).AddTicks(4181), "Vaga para FrontEnd Junior Exigindo conhecimento em : HTML, CSS,JavaScript", "Vaga Dev Junior Front End", 1 });

            migrationBuilder.InsertData(
                table: "Vaga",
                columns: new[] { "Id", "DataCriacao", "Descricao", "NomeVaga", "SituacaoVaga" },
                values: new object[] { new Guid("813f3e79-0d86-47ba-b1b7-ffccab32e137"), new DateTime(2021, 12, 8, 15, 18, 51, 42, DateTimeKind.Local).AddTicks(4241), "Vaga para BackEnd Sênior Exigindo conhecimento em : PYTHON, Criação e Manipulação de API REST,node.js", "Vaga Dev Sênior Back End", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Candidatos_CPF",
                table: "Candidatos",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Candidatos_Email",
                table: "Candidatos",
                column: "Email",
                unique: true);

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
                name: "IX_Vaga_NomeVaga",
                table: "Vaga",
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
                name: "Vaga");
        }
    }
}
