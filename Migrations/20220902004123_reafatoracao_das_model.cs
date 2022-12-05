using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SgbProject.Migrations
{
    public partial class reafatoracao_das_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bois");

            migrationBuilder.DropTable(
                name: "Vacas");

            migrationBuilder.CreateTable(
                name: "Bovinos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Apelido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Raça = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdMaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesNascimento = table.Column<int>(type: "int", nullable: false),
                    AnoNascimento = table.Column<int>(type: "int", nullable: false),
                    Genitora = table.Column<bool>(type: "bit", nullable: false),
                    QtdCria = table.Column<int>(type: "int", nullable: false),
                    UltimaCria = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bovinos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bovinos");

            migrationBuilder.CreateTable(
                name: "Bois",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnoNascimento = table.Column<int>(type: "int", nullable: false),
                    Apelido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genitor = table.Column<bool>(type: "bit", nullable: false),
                    IdMaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesNascimento = table.Column<int>(type: "int", nullable: false),
                    QtdCria = table.Column<int>(type: "int", nullable: false),
                    Raça = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UltimaCria = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bois", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnoNascimento = table.Column<int>(type: "int", nullable: false),
                    Apelido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genitora = table.Column<bool>(type: "bit", nullable: false),
                    IdMaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesNascimento = table.Column<int>(type: "int", nullable: false),
                    QtdCria = table.Column<int>(type: "int", nullable: false),
                    Raça = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UltimaCria = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacas", x => x.Id);
                });
        }
    }
}
