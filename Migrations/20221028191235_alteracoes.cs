using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SgbProject.Migrations
{
    public partial class alteracoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Bovinos");

            migrationBuilder.RenameColumn(
                name: "obs",
                table: "Bovinos",
                newName: "Obeservacao");

            migrationBuilder.RenameColumn(
                name: "dataBaixa",
                table: "Baixas",
                newName: "DataBaixa");

            migrationBuilder.RenameColumn(
                name: "Idbovino",
                table: "Baixas",
                newName: "IdBovino");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Baixas",
                newName: "Observacao");

            migrationBuilder.RenameColumn(
                name: "obs",
                table: "Baixas",
                newName: "IdUsuario");

            migrationBuilder.AddColumn<bool>(
                name: "Baixa",
                table: "Bovinos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Baixa",
                table: "Bovinos");

            migrationBuilder.RenameColumn(
                name: "Obeservacao",
                table: "Bovinos",
                newName: "obs");

            migrationBuilder.RenameColumn(
                name: "IdBovino",
                table: "Baixas",
                newName: "Idbovino");

            migrationBuilder.RenameColumn(
                name: "DataBaixa",
                table: "Baixas",
                newName: "dataBaixa");

            migrationBuilder.RenameColumn(
                name: "Observacao",
                table: "Baixas",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Baixas",
                newName: "obs");

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Bovinos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
