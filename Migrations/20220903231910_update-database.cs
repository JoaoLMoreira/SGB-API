using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SgbProject.Migrations
{
    public partial class updatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Bovinos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "obs",
                table: "Bovinos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Vacinas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdBonivo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Doenca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nLote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mesVencimento = table.Column<int>(type: "int", nullable: false),
                    anoVenciomento = table.Column<int>(type: "int", nullable: false),
                    mesFabricacao = table.Column<int>(type: "int", nullable: false),
                    anoFabrcacao = table.Column<int>(type: "int", nullable: false),
                    dataVacinacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacinas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vacinas");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Bovinos");

            migrationBuilder.DropColumn(
                name: "obs",
                table: "Bovinos");
        }
    }
}
