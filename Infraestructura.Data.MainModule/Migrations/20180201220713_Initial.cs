using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Infraestructura.Data.MainModule.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(nullable: true),
                    Comentario = table.Column<string>(nullable: true),
                    DniRepresentanteIntertek = table.Column<string>(nullable: true),
                    DniRepresentanteOsinergmin = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    FechaRecepcion = table.Column<DateTime>(nullable: false),
                    GuiaAdjunta = table.Column<string>(nullable: true),
                    NombreArchivo = table.Column<string>(nullable: true),
                    RepresentanteIntertek = table.Column<string>(nullable: true),
                    RepresentanteOsinergmin = table.Column<string>(nullable: true),
                    SupervisorExtraccionMuestra = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetalleGuiaEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CantidadMuestras = table.Column<int>(nullable: false),
                    CodigoEstablecimiento = table.Column<string>(nullable: true),
                    CodigoProducto = table.Column<string>(nullable: true),
                    FechaMuestreo = table.Column<DateTime>(nullable: false),
                    FotoMuestra = table.Column<string>(nullable: true),
                    GuiaId = table.Column<int>(nullable: false),
                    NombreArchivo = table.Column<string>(nullable: true),
                    NumeroActa = table.Column<string>(nullable: true),
                    NumeroMuestra = table.Column<int>(nullable: false),
                    NumeroPrescintoDirimencia = table.Column<string>(nullable: true),
                    NumeroPrescintoLaboratorio = table.Column<string>(nullable: true),
                    OrigenProducto = table.Column<string>(nullable: true),
                    TipoEnvase = table.Column<string>(nullable: true),
                    TipoMuestra = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleGuiaEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleGuiaEntity_Guias_GuiaId",
                        column: x => x.GuiaId,
                        principalTable: "Guias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleGuiaEntity_GuiaId",
                table: "DetalleGuiaEntity",
                column: "GuiaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleGuiaEntity");

            migrationBuilder.DropTable(
                name: "Guias");
        }
    }
}
