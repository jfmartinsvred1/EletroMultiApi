using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EletroMultiAPI.Migrations
{
    public partial class servicosADD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipamento_Servico_ServicoId",
                table: "Equipamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Servico_Clientes_ClienteId",
                table: "Servico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Servico",
                table: "Servico");

            migrationBuilder.RenameTable(
                name: "Servico",
                newName: "Servicos");

            migrationBuilder.RenameIndex(
                name: "IX_Servico_ClienteId",
                table: "Servicos",
                newName: "IX_Servicos_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servicos",
                table: "Servicos",
                column: "ServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamento_Servicos_ServicoId",
                table: "Equipamento",
                column: "ServicoId",
                principalTable: "Servicos",
                principalColumn: "ServicoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Clientes_ClienteId",
                table: "Servicos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipamento_Servicos_ServicoId",
                table: "Equipamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Clientes_ClienteId",
                table: "Servicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Servicos",
                table: "Servicos");

            migrationBuilder.RenameTable(
                name: "Servicos",
                newName: "Servico");

            migrationBuilder.RenameIndex(
                name: "IX_Servicos_ClienteId",
                table: "Servico",
                newName: "IX_Servico_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servico",
                table: "Servico",
                column: "ServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamento_Servico_ServicoId",
                table: "Equipamento",
                column: "ServicoId",
                principalTable: "Servico",
                principalColumn: "ServicoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servico_Clientes_ClienteId",
                table: "Servico",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
