using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Infraestructura.Data.MainModule.Migrations
{
    public partial class ActualizacionDetalleGuia_EliminadoTipoMuestra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoMuestra",
                table: "DetalleGuia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoMuestra",
                table: "DetalleGuia",
                nullable: false,
                defaultValue: 0);
        }
    }
}
