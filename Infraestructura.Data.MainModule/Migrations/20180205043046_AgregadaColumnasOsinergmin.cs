using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestructura.Data.MainModule.Migrations
{
    public partial class AgregadaColumnasOsinergmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "NumeroGuia",
                table: "Guias",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "DetalleGuia",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroGuia",
                table: "Guias");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "DetalleGuia");
        }
    }
}
