using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Infraestructura.Data.MainModule.Migrations
{
    public partial class AgreadaColumnaEnsayosEnDetalle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ensayos",
                table: "DetalleGuia",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ensayos",
                table: "DetalleGuia");
        }
    }
}
