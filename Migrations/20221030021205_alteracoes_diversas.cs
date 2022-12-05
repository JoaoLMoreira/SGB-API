using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SgbProject.Migrations
{
    public partial class alteracoes_diversas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Baixa",
                table: "Bovinos");

            migrationBuilder.RenameColumn(
                name: "Observacao",
                table: "Baixas",
                newName: "Sexo");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUsuario",
                table: "Baixas",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdBovino",
                table: "Baixas",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "AnoNascimento",
                table: "Baixas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Apelido",
                table: "Baixas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Genitora",
                table: "Baixas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "IdMaterno",
                table: "Baixas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdPaterno",
                table: "Baixas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MesNascimento",
                table: "Baixas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QtdCria",
                table: "Baixas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Raca",
                table: "Baixas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnoNascimento",
                table: "Baixas");

            migrationBuilder.DropColumn(
                name: "Apelido",
                table: "Baixas");

            migrationBuilder.DropColumn(
                name: "Genitora",
                table: "Baixas");

            migrationBuilder.DropColumn(
                name: "IdMaterno",
                table: "Baixas");

            migrationBuilder.DropColumn(
                name: "IdPaterno",
                table: "Baixas");

            migrationBuilder.DropColumn(
                name: "MesNascimento",
                table: "Baixas");

            migrationBuilder.DropColumn(
                name: "QtdCria",
                table: "Baixas");

            migrationBuilder.DropColumn(
                name: "Raca",
                table: "Baixas");

            migrationBuilder.RenameColumn(
                name: "Sexo",
                table: "Baixas",
                newName: "Observacao");

            migrationBuilder.AddColumn<bool>(
                name: "Baixa",
                table: "Bovinos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "IdUsuario",
                table: "Baixas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "IdBovino",
                table: "Baixas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }
    }
}
