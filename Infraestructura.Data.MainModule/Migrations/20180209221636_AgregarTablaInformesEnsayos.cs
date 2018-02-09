using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestructura.Data.MainModule.Migrations
{
    public partial class AgregarTablaInformesEnsayos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InformesEnsayos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoRecepcion = table.Column<string>(nullable: true),
                    DetalleGuiaId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    ButadienoMol = table.Column<string>(nullable: true),
                    ButenoMol = table.Column<string>(nullable: true),
                    Cis2butenoMol = table.Column<float>(nullable: true),
                    CorrosionLaminaCobre = table.Column<string>(nullable: true),
                    DensidadRelativa = table.Column<float>(nullable: true),
                    DeterminacionEtilMercaptano = table.Column<float>(nullable: true),
                    EtanoMol = table.Column<string>(nullable: true),
                    EtilenoMol = table.Column<string>(nullable: true),
                    Hexano = table.Column<string>(nullable: true),
                    IsobutanoMol = table.Column<float>(nullable: true),
                    IsobutilenoMol = table.Column<string>(nullable: true),
                    IsopentanoMol = table.Column<float>(nullable: true),
                    MetanoMol = table.Column<string>(nullable: true),
                    NbutanoMol = table.Column<float>(nullable: true),
                    NpentanoMol = table.Column<string>(nullable: true),
                    NumeroInformeLaboratorio = table.Column<string>(nullable: true),
                    NumeroOctanoMotor = table.Column<string>(nullable: true),
                    Observaciones = table.Column<string>(nullable: true),
                    PresionVapor = table.Column<float>(nullable: true),
                    PropanoMol = table.Column<float>(nullable: true),
                    PropilenoMol = table.Column<string>(nullable: true),
                    Trans2butenoMol = table.Column<string>(nullable: true),
                    Aastmd86_perdidas = table.Column<float>(nullable: true),
                    Aastmd86_residuo = table.Column<float>(nullable: true),
                    AguaPorDestilacion = table.Column<string>(nullable: true),
                    AguaSedimentos = table.Column<string>(nullable: true),
                    Astmd86_10p = table.Column<float>(nullable: true),
                    Astmd86_20p = table.Column<float>(nullable: true),
                    Astmd86_50p = table.Column<float>(nullable: true),
                    Astmd86_5p = table.Column<float>(nullable: true),
                    Astmd86_90p = table.Column<float>(nullable: true),
                    Astmd86_95p = table.Column<float>(nullable: true),
                    Astmd86_pfe = table.Column<float>(nullable: true),
                    Astmd86_pie = table.Column<float>(nullable: true),
                    Astmd86_recup = table.Column<float>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    ContaminacionParticulas = table.Column<string>(nullable: true),
                    ContenidoAzufre4294 = table.Column<string>(nullable: true),
                    ContenidoAzufre5453 = table.Column<string>(nullable: true),
                    ContenidoDipeMasa = table.Column<string>(nullable: true),
                    ContenidoDipeVolumen = table.Column<string>(nullable: true),
                    ContenidoEtanolMasa = table.Column<string>(nullable: true),
                    ContenidoEtanolVolumen = table.Column<string>(nullable: true),
                    ContenidoEtbeMasa = table.Column<string>(nullable: true),
                    ContenidoEtbeVolumen = table.Column<string>(nullable: true),
                    ContenidoFameVolumen = table.Column<float>(nullable: true),
                    ContenidoGomas = table.Column<string>(nullable: true),
                    ContenidoManganeso = table.Column<float>(nullable: true),
                    ContenidoMetanolMasa = table.Column<string>(nullable: true),
                    ContenidoMetanolVolumen = table.Column<string>(nullable: true),
                    ContenidoMtbeMasa = table.Column<string>(nullable: true),
                    ContenidoMtbeVolumen = table.Column<string>(nullable: true),
                    ContenidoPlomo = table.Column<string>(nullable: true),
                    ContenidoPlomoAstmd3237 = table.Column<string>(nullable: true),
                    ContenidoPlomoAstmd3341 = table.Column<string>(nullable: true),
                    ContenidoSolidos = table.Column<string>(nullable: true),
                    ContenidoTameMasa = table.Column<string>(nullable: true),
                    ContenidoTameVolumen = table.Column<string>(nullable: true),
                    ContenidoTertbutanoMasa = table.Column<string>(nullable: true),
                    ContenidoTertbutanoVolumen = table.Column<string>(nullable: true),
                    InformeEnsayoLiquidoEntity_DensidadRelativa = table.Column<float>(nullable: true),
                    DeterminacionBenceno = table.Column<float>(nullable: true),
                    GravidadApi = table.Column<float>(nullable: true),
                    IndiceCetano = table.Column<float>(nullable: true),
                    IndiceCetanoBajoAzufre = table.Column<float>(nullable: true),
                    IndiceCetanoFme = table.Column<string>(nullable: true),
                    IndiceCetanoProcedenciaA = table.Column<float>(nullable: true),
                    IndiceCetanoProcedenciaB = table.Column<float>(nullable: true),
                    InformeEnsayoLiquidoEntity_NumeroInformeLaboratorio = table.Column<string>(nullable: true),
                    InformeEnsayoLiquidoEntity_Observaciones = table.Column<string>(nullable: true),
                    Octanaje = table.Column<string>(nullable: true),
                    PresionVaporReid = table.Column<float>(nullable: true),
                    PuntoCongelamiento = table.Column<string>(nullable: true),
                    PuntoEscurrimiento = table.Column<string>(nullable: true),
                    PuntoInflamacion = table.Column<string>(nullable: true),
                    ReaccionAlAgua = table.Column<float>(nullable: true),
                    RemanenteRetirado = table.Column<string>(nullable: true),
                    ResultadoFinal = table.Column<string>(nullable: true),
                    TotalOxigenadosMasa = table.Column<string>(nullable: true),
                    TotalOxigenadosVolumen = table.Column<string>(nullable: true),
                    TotalOxigeno = table.Column<string>(nullable: true),
                    ViscosidadCinematica = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformesEnsayos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InformesEnsayos_DetalleGuia_DetalleGuiaId",
                        column: x => x.DetalleGuiaId,
                        principalTable: "DetalleGuia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InformesEnsayos_DetalleGuiaId",
                table: "InformesEnsayos",
                column: "DetalleGuiaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InformesEnsayos");
        }
    }
}
