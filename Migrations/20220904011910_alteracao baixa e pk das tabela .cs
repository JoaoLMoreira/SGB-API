using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SgbProject.Migrations
{
    public partial class alteracaobaixaepkdastabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Idbovino",
                table: "Baixas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Idbovino",
                table: "Baixas");
        }
    }
}
