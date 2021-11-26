using Microsoft.EntityFrameworkCore.Migrations;

namespace Aluguel.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Clientes_ClienteID",
                table: "Alugueis");

            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Colaboradores_ColaboradorID",
                table: "Alugueis");

            migrationBuilder.AlterColumn<int>(
                name: "ColaboradorID",
                table: "Alugueis",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteID",
                table: "Alugueis",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Alugueis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Observacao",
                table: "Alugueis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tamanho",
                table: "Alugueis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_Clientes_ClienteID",
                table: "Alugueis",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_Colaboradores_ColaboradorID",
                table: "Alugueis",
                column: "ColaboradorID",
                principalTable: "Colaboradores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Clientes_ClienteID",
                table: "Alugueis");

            migrationBuilder.DropForeignKey(
                name: "FK_Alugueis_Colaboradores_ColaboradorID",
                table: "Alugueis");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Alugueis");

            migrationBuilder.DropColumn(
                name: "Observacao",
                table: "Alugueis");

            migrationBuilder.DropColumn(
                name: "Tamanho",
                table: "Alugueis");

            migrationBuilder.AlterColumn<int>(
                name: "ColaboradorID",
                table: "Alugueis",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteID",
                table: "Alugueis",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_Clientes_ClienteID",
                table: "Alugueis",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alugueis_Colaboradores_ColaboradorID",
                table: "Alugueis",
                column: "ColaboradorID",
                principalTable: "Colaboradores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
