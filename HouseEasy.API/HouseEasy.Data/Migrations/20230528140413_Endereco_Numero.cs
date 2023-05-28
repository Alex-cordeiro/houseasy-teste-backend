using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseEasy.Data.Migrations
{
    public partial class Endereco_Numero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "Enderecos",
                type: "int",
                maxLength: 5,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Enderecos");
        }
    }
}
