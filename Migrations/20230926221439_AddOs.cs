using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EletroMultiAPI.Migrations
{
    public partial class AddOs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumeroOs",
                table: "Servico",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroOs",
                table: "Servico");
        }
    }
}
