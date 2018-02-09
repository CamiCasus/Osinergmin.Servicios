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
                    observaciones = informeEnsayoLiquido.Observaciones,
                    numeroInformeLaboratorio = informeEnsayoLiquido.NumeroInformeLaboratorio,
                    octanaje = informeEnsayoLiquido.Octanaje,
                    puntoInflamacion = informeEnsayoLiquido.PuntoInflamacion,
                    presionVaporReid = informeEnsayoLiquido.PresionVaporReid,
                    contenidoAzufre4294 = informeEnsayoLiquido.ContenidoAzufre4294,
                    contenidoAzufre5453 = informeEnsayoLiquido.ContenidoAzufre5453,
                    viscosidadCinematica = informeEnsayoLiquido.ViscosidadCinematica,
                    contenidoManganeso = informeEnsayoLiquido.ContenidoManganeso,
                    puntoEscurrimiento = informeEnsayoLiquido.PuntoEscurrimiento,
                    contenidoPlomo = informeEnsayoLiquido.ContenidoPlomo,
                    contenidoPlomoAstmd3341 = informeEnsayoLiquido.ContenidoPlomoAstmd3341,
                    contenidoPlomoAstmd3237 = informeEnsayoLiquido.ContenidoPlomoAstmd3237,
                    astmd86_pie = informeEnsayoLiquido.Astmd86_pie,
                    astmd86_5p = informeEnsayoLiquido.Astmd86_5p,
                    astmd86_10p = informeEnsayoLiquido.Astmd86_10p,
                    astmd86_20p = informeEnsayoLiquido.Astmd86_20p,
                    astmd86_50p = informeEnsayoLiquido.Astmd86_50p,
                    astmd86_90p = informeEnsayoLiquido.Astmd86_90p,
                    astmd86_95p = informeEnsayoLiquido.Astmd86_95p,
                    astmd86_pfe = informeEnsayoLiquido.Astmd86_pfe,
                    astmd86_recup = informeEnsayoLiquido.Astmd86_recup,
                    astmd86_residuo = informeEnsayoLiquido.Aastmd86_residuo,
                    astmd86_perdidas = informeEnsayoLiquido.Aastmd86_perdidas,
                    gravidadApi = informeEnsayoLiquido.GravidadApi,
                    densidadRelativa = informeEnsayoLiquido.DensidadRelativa,
                    indiceCetano = informeEnsayoLiquido.IndiceCetano,
                    indiceCetanoProcedenciaA = informeEnsayoLiquido.IndiceCetanoProcedenciaA,
                    indiceCetanoProcedenciaB = informeEnsayoLiquido.IndiceCetanoProcedenciaB,
                    indiceCetanoBajoAzufre = informeEnsayoLiquido.IndiceCetanoBajoAzufre,
                    contenidoFameVolumen = informeEnsayoLiquido.ContenidoFameVolumen,
                    contenidoEtanolVolumen = informeEnsayoLiquido.ContenidoEtanolVolumen,
                    totalOxigenadosVolumen = informeEnsayoLiquido.TotalOxigenadosVolumen,
                    totalOxigeno = informeEnsayoLiquido.TotalOxigeno,
                    contenidoMtbeVolumen = informeEnsayoLiquido.ContenidoMtbeVolumen,
                    contenidoTameVolumen = informeEnsayoLiquido.ContenidoTameVolumen,
                    contenidoEtbeVolumen = informeEnsayoLiquido.ContenidoEtbeVolumen,
                    contenidoMetanolVolumen = informeEnsayoLiquido.ContenidoMetanolVolumen,
                    contenidoTertbutanoVolumen = informeEnsayoLiquido.ContenidoTertbutanoVolumen,
                    contenidoDipeVolumen = informeEnsayoLiquido.ContenidoDipeVolumen,
                    contenidoMtbeMasa = informeEnsayoLiquido.ContenidoMtbeMasa,
                    contenidoTameMasa = informeEnsayoLiquido.ContenidoTameMasa,
                    contenidoEtbeMasa = informeEnsayoLiquido.ContenidoEtbeMasa,
                    contenidoEtanolMasa = informeEnsayoLiquido.ContenidoEtanolMasa,
                    contenidoMetanolMasa = informeEnsayoLiquido.ContenidoMetanolMasa,
                    contenidoTertbutanoMasa = informeEnsayoLiquido.ContenidoTertbutanoMasa,
                    contenidoDipeMasa = informeEnsayoLiquido.ContenidoDipeMasa,
                    totalOxigenadosMasa = informeEnsayoLiquido.TotalOxigenadosMasa,
                    reaccionAlAgua = informeEnsayoLiquido.ReaccionAlAgua,
                    contenidoSolidos = informeEnsayoLiquido.ContenidoSolidos,
                    contenidoGomas = informeEnsayoLiquido.ContenidoGomas,
                    puntoCongelamiento = informeEnsayoLiquido.PuntoCongelamiento,
                    aguaSedimentos = informeEnsayoLiquido.AguaSedimentos,
                    determinacionBenceno = informeEnsayoLiquido.DeterminacionBenceno,
                    aguaPorDestilacion = informeEnsayoLiquido.AguaPorDestilacion,
                    contaminacionParticulas = informeEnsayoLiquido.ContaminacionParticulas,
                    indiceCetanoFme = informeEnsayoLiquido.IndiceCetanoFme,
                    color = informeEnsayoLiquido.Color,
                    resultadoFinal = informeEnsayoLiquido.ResultadoFinal,
                    remanenteRetirado = informeEnsayoLiquido.RemanenteRetirado,
                    astmd86_10pSpecified = true,
                    astmd86_20pSpecified = true,
                    astmd86_50pSpecified = true,
                    astmd86_5pSpecified = true,
                    astmd86_90pSpecified = true,
                    astmd86_95pSpecified = true,
                    astmd86_perdidasSpecified = true,
                    astmd86_pfeSpecified = true,
                    astmd86_pieSpecified = true,
                    astmd86_recupSpecified = true,
                    astmd86_residuoSpecified = true,
                    contenidoFameVolumenSpecified = true,
                    contenidoManganesoSpecified = true,
                    densidadRelativaSpecified = true,
                    determinacionBencenoSpecified = true,
                    indiceCetanoBajoAzufreSpecified = true,
                    gravidadApiSpecified = true,
                    indiceCetanoProcedenciaASpecified = true,
                    indiceCetanoProcedenciaBSpecified = true,
                    indiceCetanoSpecified = true,
                    nroGuiaSpecified = true,
                    nroMuestraSpecified = true,
                    presionVaporReidSpecified = true,
                    reaccionAlAguaSpecified = true,
                    viscosidadCinematicaSpecified = true, 
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
                    determinacionEtilMercaptano = informeEnsayoGlp.DeterminacionEtilMercaptano,
                    cis2butenoMolSpecified = true,
                    densidadRelativaSpecified = true,
                    determinacionEtilMercaptanoSpecified = true,
                    isobutanoMolSpecified = true ,
                    isopentanoMolSpecified = true,
                    nbutanoMolSpecified = true,
                    nroGuiaSpecified =  true,
                    nroMuestraSpecified= true,
                    presionVaporSpecified = true,
                    propanoMolSpecified = true
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
