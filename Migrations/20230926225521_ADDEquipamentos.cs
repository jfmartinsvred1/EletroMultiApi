using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EletroMultiAPI.Migrations
{
    public partial class ADDEquipamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipamento_Marcas_MarcaId",
                table: "Equipamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipamento_Servicos_ServicoId",
                table: "Equipamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipamento",
                table: "Equipamento");

            migrationBuilder.RenameTable(
                name: "Equipamento",
                newName: "Equipamentos");

            migrationBuilder.RenameIndex(
                name: "IX_Equipamento_ServicoId",
                table: "Equipamentos",
                newName: "IX_Equipamentos_ServicoId");

            migrationBuilder.RenameIndex(
                name: "IX_Equipamento_MarcaId",
                table: "Equipamentos",
                newName: "IX_Equipamentos_MarcaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipamentos",
                table: "Equipamentos",
                column: "EquipamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamentos_Marcas_MarcaId",
                table: "Equipamentos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "MarcaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamentos_Servicos_ServicoId",
                table: "Equipamentos",
                column: "ServicoId",
                principalTable: "Servicos",
                principalColumn: "ServicoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipamentos_Marcas_MarcaId",
                table: "Equipamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipamentos_Servicos_ServicoId",
                table: "Equipamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipamentos",
                table: "Equipamentos");

            migrationBuilder.RenameTable(
                name: "Equipamentos",
                newName: "Equipamento");

            migrationBuilder.RenameIndex(
                name: "IX_Equipamentos_ServicoId",
                table: "Equipamento",
                newName: "IX_Equipamento_ServicoId");

            migrationBuilder.RenameIndex(
                name: "IX_Equipamentos_MarcaId",
                table: "Equipamento",
                newName: "IX_Equipamento_MarcaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipamento",
                table: "Equipamento",
                column: "EquipamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamento_Marcas_MarcaId",
                table: "Equipamento",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "MarcaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamento_Servicos_ServicoId",
                table: "Equipamento",
                column: "ServicoId",
                principalTable: "Servicos",
                principalColumn: "ServicoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
