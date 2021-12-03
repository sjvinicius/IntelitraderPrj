using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InteliTrader.Infra.Data.Migrations
{
    public partial class BancoIntelitraderTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("04e3b42f-3af4-4f62-a8e1-d6039c88728b"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("a419b1a1-73b5-4a49-b5b6-f9527a181fd2"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("af5a09c9-6551-4125-bc88-428c26a7f418"));

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Usuarios",
                type: "VARCHAR(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuarios",
                type: "VARCHAR(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "RG",
                table: "Usuarios",
                type: "VARCHAR(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "Instituicao",
                table: "Usuarios",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Usuarios",
                type: "VARCHAR(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(11)",
                oldMaxLength: 11);

            migrationBuilder.InsertData(
                table: "Vagas",
                columns: new[] { "Id", "DataCriacao", "Descricao", "NomeVaga", "SituacaoVaga" },
                values: new object[] { new Guid("df93ade3-6d8a-4187-b61c-66a0a461c6ba"), new DateTime(2021, 12, 2, 14, 37, 8, 101, DateTimeKind.Local).AddTicks(4049), "Estágio para BackEnd Exigindo conhecimento em : C#, .NET, ASP.NETCORE,Manipulação de API REST", "Vaga Estágio Back-End", 1 });

            migrationBuilder.InsertData(
                table: "Vagas",
                columns: new[] { "Id", "DataCriacao", "Descricao", "NomeVaga", "SituacaoVaga" },
                values: new object[] { new Guid("4d40421a-a379-425f-b68d-a10f6d6766fb"), new DateTime(2021, 12, 2, 14, 37, 8, 119, DateTimeKind.Local).AddTicks(4030), "Vaga para FrontEnd Junior Exigindo conhecimento em : HTML, CSS,JavaScript", "Vaga Dev Junior Front End", 1 });

            migrationBuilder.InsertData(
                table: "Vagas",
                columns: new[] { "Id", "DataCriacao", "Descricao", "NomeVaga", "SituacaoVaga" },
                values: new object[] { new Guid("cb5e0bfd-c1a3-4e04-93fc-954dc5bac788"), new DateTime(2021, 12, 2, 14, 37, 8, 119, DateTimeKind.Local).AddTicks(4100), "Vaga para BackEnd Sênior Exigindo conhecimento em : PYTHON, Criação e Manipulação de API REST,node.js", "Vaga Dev Sênior Back End", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("4d40421a-a379-425f-b68d-a10f6d6766fb"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("cb5e0bfd-c1a3-4e04-93fc-954dc5bac788"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("df93ade3-6d8a-4187-b61c-66a0a461c6ba"));

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Usuarios",
                type: "VARCHAR(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuarios",
                type: "VARCHAR(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "RG",
                table: "Usuarios",
                type: "VARCHAR(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(13)",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "Instituicao",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Usuarios",
                type: "VARCHAR(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(16)",
                oldMaxLength: 16);

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
        }
    }
}
