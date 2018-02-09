using Domain.MainModule.Entities;
using Domain.MainModule.Osinergmin;
using Infraestructura.Data.MainModule.Interfaces;
using Osinergmin;
using System.Linq;
using System.Threading.Tasks;

namespace Infraestructura.Data.MainModule
{
    public class OsinergminRepository : IOsinergminRepository
    {
        private readonly LabCalidadPortTypeClient _osinergminClient;
        private readonly OsinergminConfig _osinergminConfig;
        private readonly IProductoRepository _productoRepository;

        public OsinergminRepository(IProductoRepository productoRepository, OsinergminConfig osinergminConfig)
        {
            _osinergminConfig = osinergminConfig;
            _productoRepository = productoRepository;
            _osinergminClient = new LabCalidadPortTypeClient();
        }

        public async Task<OsinergminResponse> RegistrarGuiaOsinergmin(GuiaEntity guiaEntity)
        {
            var responseClienteOsinergmin = await _osinergminClient.registrarGuiaMuestrasAsync(
                new cabeceraMuestra
                {
                    loginUsuario = _osinergminConfig.Usuario,
                    claveUsuario = _osinergminConfig.Password,
                    codigoGuiaMuestras = guiaEntity.Codigo,
                    comentario = guiaEntity.Comentario,
                    fechaRecepcionLaboratorio = guiaEntity.FechaRecepcion.ToString("dd/MM/yyyy"),
                    representanteLaboratorio = guiaEntity.RepresentanteIntertek,
                    representanteLaboratorioDni = guiaEntity.DniRepresentanteIntertek,
                    representanteOsinergmin = guiaEntity.RepresentanteOsinergmin,
                    representanteOsinergminDni = guiaEntity.DniRepresentanteOsinergmin,
                    supervisor = guiaEntity.SupervisorExtraccionMuestra,
                    nombreAdjunto = guiaEntity.NombreArchivo,
                    guiaAdjunta = guiaEntity.GuiaAdjunta
                });

            var respuestaOsinergmin = responseClienteOsinergmin.registrarGuiaMuestrasResponse1;

            if (respuestaOsinergmin.codigoResultado == TipoResultadoOsinergmin.Error)
            {
                return new OsinergminResponse
                {
                    Exito = false,
                    Mensaje = Codigos.MENSAJES_ERROR[respuestaOsinergmin.codigoError]
                };
            }

            guiaEntity.NumeroGuia = respuestaOsinergmin.numeroGuia;

            return await RegistrarActualizarDetalle(guiaEntity);
        }

        public async Task<OsinergminResponse> RegistrarActualizarDetalle(GuiaEntity guiaEntity)
        {
            foreach (var detalleGuia in guiaEntity.Detalles)
            {
                var productoActual = detalleGuia.Producto ?? await _productoRepository.Get(detalleGuia.ProductoId);

                var responseClienteDetalleOsinergmin = await _osinergminClient.registrarGuiaMuestrasDetalleAsync(
                    new detalleMuestra
                    {
                        loginUsuario = _osinergminConfig.Usuario,
                        claveUsuario = _osinergminConfig.Password,
                        cantidadMuestras = detalleGuia.CantidadMuestras,
                        codigoEstablecimiento = detalleGuia.CodigoEstablecimiento,
                        codigoProducto = productoActual.Codigo,
                        fechaMuestreo = detalleGuia.FechaMuestreo.ToString("dd/MM/yyyy"),
                        numeroActa = detalleGuia.NumeroActa,
                        numeroGuia = guiaEntity.NumeroGuia,
                        numeroMuestra = detalleGuia.NumeroMuestra,
                        numeroPrecintoDirimencia = detalleGuia.NumeroPrescintoDirimencia,
                        numeroPrecintoLaboratorio = detalleGuia.NumeroPrescintoLaboratorio,
                        origenProducto = detalleGuia.OrigenProducto,
                        tipoEnvase = detalleGuia.TipoEnvase,
                        observaciones = detalleGuia.Observaciones,
                        nombreFoto = detalleGuia.NombreArchivo,
                        fotoMuestra = detalleGuia.FotoMuestra,
                        cantidadMuestrasSpecified = true,
                        numeroGuiaSpecified = true,
                        numeroMuestraSpecified = true
                    });

                var respuestaDetalleOsinergmin = responseClienteDetalleOsinergmin.registrarGuiaMuestrasDetalleResponse1;

                if (respuestaDetalleOsinergmin.codigoResultado == TipoResultadoOsinergmin.Error)
                {
                    return new OsinergminResponse
                    {
                        Exito = false,
                        Mensaje = Codigos.MENSAJES_ERROR[respuestaDetalleOsinergmin.codigoError]
                    };
                }

                detalleGuia.Version = respuestaDetalleOsinergmin.version;
            }

            return new OsinergminResponse { Exito = true };
        }

        public async Task<OsinergminResponse> PresentarOsinergmin(GuiaEntity guiaEntity)
        {
            var responseClienteOsinergmin = await _osinergminClient.presentarGuiaMuestrasAsync(
                new guiaMuestra
                {
                    loginUsuario = _osinergminConfig.Usuario,
                    claveUsuario = _osinergminConfig.Password,
                    numeroGuia = guiaEntity.NumeroGuia,
                    seEstaVersionando = "N",
                    numeroGuiaSpecified = true
                });
            var responsePresentarOsinergmin = responseClienteOsinergmin.presentarGuiaMuestrasResponse1;

            if (responsePresentarOsinergmin.codigoResultado == TipoResultadoOsinergmin.Error)
            {
                return new OsinergminResponse
                {
                    Exito = false,
                    Mensaje = Codigos.MENSAJES_ERROR[responsePresentarOsinergmin.codigoError]
                };
            }

            return new OsinergminResponse { Exito = true };
        }

        public async Task<OsinergminResponse> ValidarMuestra(GuiaEntity guiaEntity, long codigoVerificacion)
        {
            var responseClienteOsinergmin = await _osinergminClient.obtenerValidacionPorMuestraAsync(
                new getEnsayosPorMuestras
                {
                    loginUsuario = _osinergminConfig.Usuario,
                    claveUsuario = _osinergminConfig.Password,
                    numeroGuia = guiaEntity.NumeroGuia,
                    codigoVerificacion = codigoVerificacion,
                    codigoVerificacionSpecified = true,
                    numeroGuiaSpecified = true
                });

            var responseValidarMuestra = responseClienteOsinergmin.obtenerValidacionPorMuestraResponse1;

            foreach (var ensayoMuestra in responseValidarMuestra)
            {
                var detalleGuia = guiaEntity.Detalles.FirstOrDefault(p => p.NumeroMuestra == ensayoMuestra.numeroMuestra);
                detalleGuia.Ensayos = string.Join(",", ensayoMuestra.ensayos);
            }

            return new OsinergminResponse { Exito = true };
        }

        public async Task<OsinergminResponse> RegistrarInformeEnsayoCombustibleLiquido(InformeEnsayoLiquidoEntity informeEnsayoLiquido)
        {
            var responseClienteOsinergmin = await _osinergminClient.registrarInformeLabLiquidoCalidadAsync(
                new informeLiquido
                {
        observaciones = informeEnsayoLiquido.observaciones,
        numeroInformeLaboratorio = informeEnsayoLiquido.numeroInformeLaboratorio,
        octanaje = informeEnsayoLiquido.octanaje,
        puntoInflamacion = informeEnsayoLiquido.puntoInflamacion,
        presionVaporReid = informeEnsayoLiquido.presionVaporReid,
        contenidoAzufre4294 = informeEnsayoLiquido.contenidoAzufre4294,
        contenidoAzufre5453 = informeEnsayoLiquido.contenidoAzufre5453,
        viscosidadCinematica = informeEnsayoLiquido.viscosidadCinematica,
        contenidoManganeso = informeEnsayoLiquido.contenidoManganeso,
        puntoEscurrimiento = informeEnsayoLiquido.puntoEscurrimiento,
        contenidoPlomo = informeEnsayoLiquido.contenidoPlomo,
        contenidoPlomoAstmd3341 = informeEnsayoLiquido.contenidoPlomoAstmd3341,
        contenidoPlomoAstmd3237 = informeEnsayoLiquido.contenidoPlomoAstmd3237,
        astmd86_pie = informeEnsayoLiquido.astmd86_pie,
        astmd86_5p = informeEnsayoLiquido.astmd86_5p,
        astmd86_10p = informeEnsayoLiquido.astmd86_10p,
        astmd86_20p = informeEnsayoLiquido.astmd86_20p,
        astmd86_50p = informeEnsayoLiquido.astmd86_50p,
        astmd86_90p = informeEnsayoLiquido.astmd86_90p,
        astmd86_95p = informeEnsayoLiquido.astmd86_95p,
        astmd86_pfe = informeEnsayoLiquido.astmd86_pfe,
        astmd86_recup = informeEnsayoLiquido.astmd86_recup,
        astmd86_residuo = informeEnsayoLiquido.aastmd86_residuo,
        astmd86_perdidas = informeEnsayoLiquido.aastmd86_perdidas,
        gravidadApi = informeEnsayoLiquido.gravidadApi,
        densidadRelativa = informeEnsayoLiquido.densidadRelativa,
        indiceCetano = informeEnsayoLiquido.indiceCetano,
        indiceCetanoProcedenciaA = informeEnsayoLiquido.indiceCetanoProcedenciaA,
        indiceCetanoProcedenciaB = informeEnsayoLiquido.indiceCetanoProcedenciaB,
        indiceCetanoBajoAzufre = informeEnsayoLiquido.indiceCetanoBajoAzufre,
        contenidoFameVolumen = informeEnsayoLiquido.contenidoFameVolumen,
        contenidoEtanolVolumen = informeEnsayoLiquido.contenidoEtanolVolumen,
        totalOxigenadosVolumen = informeEnsayoLiquido.totalOxigenadosVolumen,
        totalOxigeno = informeEnsayoLiquido.totalOxigeno,
        contenidoMtbeVolumen = informeEnsayoLiquido.contenidoMtbeVolumen,
        contenidoTameVolumen = informeEnsayoLiquido.contenidoTameVolumen,
        contenidoEtbeVolumen = informeEnsayoLiquido.contenidoEtbeVolumen,
        contenidoMetanolVolumen = informeEnsayoLiquido.contenidoMetanolVolumen,
        contenidoTertbutanoVolumen = informeEnsayoLiquido.contenidoTertbutanoVolumen,
        contenidoDipeVolumen = informeEnsayoLiquido.contenidoDipeVolumen,
        contenidoMtbeMasa = informeEnsayoLiquido.contenidoMtbeMasa,
        contenidoTameMasa = informeEnsayoLiquido.contenidoTameMasa,
        contenidoEtbeMasa = informeEnsayoLiquido.contenidoEtbeMasa,
        contenidoEtanolMasa = informeEnsayoLiquido.contenidoEtanolMasa,
        contenidoMetanolMasa = informeEnsayoLiquido.contenidoMetanolMasa,
        contenidoTertbutanoMasa = informeEnsayoLiquido.contenidoTertbutanoMasa,
        contenidoDipeMasa = informeEnsayoLiquido.contenidoDipeMasa,
        totalOxigenadosMasa = informeEnsayoLiquido.totalOxigenadosMasa,
        reaccionAlAgua = informeEnsayoLiquido.reaccionAlAgua,
        contenidoSolidos = informeEnsayoLiquido.contenidoSolidos,
        contenidoGomas = informeEnsayoLiquido.contenidoGomas,
        puntoCongelamiento = informeEnsayoLiquido.puntoCongelamiento,
        determinacionBenceno = informeEnsayoLiquido.determinacionBenceno,
        aguaPorDestilacion = informeEnsayoLiquido.aguaPorDestilacion,
        contaminacionParticulas = informeEnsayoLiquido.contaminacionParticulas,
        indiceCetanoFme = informeEnsayoLiquido.indiceCetanoFme,
        color = informeEnsayoLiquido.color,
        resultadoFinal = informeEnsayoLiquido.resultadoFinal,
        remanenteRetirado = informeEnsayoLiquido.remanenteRetirado
        });

            var responseRegistroInformeEnsayoLiquido = responseClienteOsinergmin.registrarInformeLabLiquidoCalidadResponse1;

            if (responseRegistroInformeEnsayoLiquido.codigoResultado == TipoResultadoOsinergmin.Error)
            {
                return new OsinergminResponse
                {
                    Exito = false,
                    Mensaje = Codigos.MENSAJES_ERROR[responseRegistroInformeEnsayoLiquido.codigoError]
                };
            }

            informeEnsayoLiquido.Version = responseRegistroInformeEnsayoLiquido.version;
            informeEnsayoLiquido.CodigoRecepcion = responseRegistroInformeEnsayoLiquido.codigoRecepcion;

            return new OsinergminResponse { Exito = true };
        }

        public async Task<OsinergminResponse> RegistrarInformeEnsayoGlp(InformeEnsayoGlpEntity informeEnsayoGlp)
        {
            var responseClienteOsinergmin = await _osinergminClient.registrarInformeLabGlpCalidadAsync(
                new informeGlp
                {
        observaciones = informeEnsayoGlp.Observaciones,
        numeroInformeLaboratorio = informeEnsayoGlp.NumeroInformeLaboratorio,
        densidadRelativa = informeEnsayoGlp.DensidadRelativa,
        presionVapor = informeEnsayoGlp.PresionVapor,
        numeroOctanoMotor = informeEnsayoGlp.NumeroOctanoMotor,
        metanoMol = informeEnsayoGlp.MetanoMol,
        etanoMol = informeEnsayoGlp.EtanoMol,
        etilenoMol = informeEnsayoGlp.EtilenoMol,
        propanoMol = informeEnsayoGlp.PropanoMol,
        propilenoMol = informeEnsayoGlp.PropilenoMol,
        isobutanoMol = informeEnsayoGlp.IsobutanoMol,
        nbutanoMol = informeEnsayoGlp.NbutanoMol,
        trans2butenoMol = informeEnsayoGlp.Trans2butenoMol,
        butenoMol = informeEnsayoGlp.ButenoMol,
        isobutilenoMol = informeEnsayoGlp.IsobutilenoMol,
        cis2butenoMol = informeEnsayoGlp.Cis2butenoMol,
        isopentanoMol = informeEnsayoGlp.IsopentanoMol,
        npentanoMol = informeEnsayoGlp.NpentanoMol,
        butadienoMol = informeEnsayoGlp.ButadienoMol,
        hexano = informeEnsayoGlp.Hexano,
        corrosionLaminaCobre = informeEnsayoGlp.CorrosionLaminaCobre,
        determinacionEtilMercaptano = informeEnsayoGlp.DeterminacionEtilMercaptano
                });

            var responseRegistroInformeEnsayoGlp = responseClienteOsinergmin.registrarInformeLabGlpCalidadResponse1;

            if (responseRegistroInformeEnsayoGlp.codigoResultado == TipoResultadoOsinergmin.Error)
            {
                return new OsinergminResponse
                {
                    Exito = false,
                    Mensaje = Codigos.MENSAJES_ERROR[responseRegistroInformeEnsayoGlp.codigoError]
                };
            }

            informeEnsayoGlp.Version = responseRegistroInformeEnsayoGlp.version;
            informeEnsayoGlp.CodigoRecepcion = responseRegistroInformeEnsayoGlp.codigoRecepcion;

            return new OsinergminResponse { Exito = true };
        }
    }
}
