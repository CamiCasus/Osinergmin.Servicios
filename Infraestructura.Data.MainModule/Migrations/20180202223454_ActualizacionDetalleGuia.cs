using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestructura.Data.MainModule.Migrations
{
    public partial class ActualizacionDetalleGuia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoProducto",
                table: "DetalleGuia");

            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "DetalleGuia",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DetalleGuia_ProductoId",
                table: "DetalleGuia",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleGuia_Productos_ProductoId",
                table: "DetalleGuia",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleGuia_Productos_ProductoId",
                table: "DetalleGuia");

            migrationBuilder.DropIndex(
                name: "IX_DetalleGuia_ProductoId",
                table: "DetalleGuia");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "DetalleGuia");

            migrationBuilder.AddColumn<string>(
                name: "CodigoProducto",
                table: "DetalleGuia",
                nullable: true);
        }
    }
}
