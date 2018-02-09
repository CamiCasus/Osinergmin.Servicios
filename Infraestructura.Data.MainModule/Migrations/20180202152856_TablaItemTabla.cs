using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestructura.Data.MainModule.Migrations
{
    public partial class TablaItemTabla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleGuiaEntity_Guias_GuiaId",
                table: "DetalleGuiaEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetalleGuiaEntity",
                table: "DetalleGuiaEntity");

            migrationBuilder.RenameTable(
                name: "DetalleGuiaEntity",
                newName: "DetalleGuia");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleGuiaEntity_GuiaId",
                table: "DetalleGuia",
                newName: "IX_DetalleGuia_GuiaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetalleGuia",
                table: "DetalleGuia",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Tablas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tablas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemsTabla",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    TablaId = table.Column<int>(nullable: false),
                    Valor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsTabla", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsTabla_Tablas_TablaId",
                        column: x => x.TablaId,
                        principalTable: "Tablas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemsTabla_TablaId",
                table: "ItemsTabla",
                column: "TablaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleGuia_Guias_GuiaId",
                table: "DetalleGuia",
                column: "GuiaId",
                principalTable: "Guias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleGuia_Guias_GuiaId",
                table: "DetalleGuia");

            migrationBuilder.DropTable(
                name: "ItemsTabla");

            migrationBuilder.DropTable(
                name: "Tablas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetalleGuia",
                table: "DetalleGuia");

            migrationBuilder.RenameTable(
                name: "DetalleGuia",
                newName: "DetalleGuiaEntity");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleGuia_GuiaId",
                table: "DetalleGuiaEntity",
                newName: "IX_DetalleGuiaEntity_GuiaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetalleGuiaEntity",
                table: "DetalleGuiaEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleGuiaEntity_Guias_GuiaId",
                table: "DetalleGuiaEntity",
                column: "GuiaId",
                principalTable: "Guias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
