using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EletroMultiAPI.Migrations
{
    public partial class numeroOs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroOs",
                table: "Servicos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumeroOs",
                table: "Servicos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
