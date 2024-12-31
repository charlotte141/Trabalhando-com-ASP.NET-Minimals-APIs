using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Minimal.Migrations
{
    /// <inheritdoc />
    public partial class Administrador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Marca",
                table: "Veiculos",
                newName: "Mark");

            migrationBuilder.RenameColumn(
                name: "Ano",
                table: "Veiculos",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Administradores",
                newName: "PassWord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Veiculos",
                newName: "Ano");

            migrationBuilder.RenameColumn(
                name: "Mark",
                table: "Veiculos",
                newName: "Marca");

            migrationBuilder.RenameColumn(
                name: "PassWord",
                table: "Administradores",
                newName: "Senha");
        }
    }
}
