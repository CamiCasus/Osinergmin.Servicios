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
        private readonly IDetalleGuiaRepository _detalleGuiaRepository;

        public OsinergminRepository(
            IProductoRepository productoRepository,
            IDetalleGuiaRepository detalleGuiaRepository,
            OsinergminConfig osinergminConfig)
        {
            _osinergminConfig = osinergminConfig;
            _productoRepository = productoRepository;
            _osinergminClient = new LabCalidadPortTypeClient();
            _detalleGuiaRepository = detalleGuiaRepository;
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
            var detalleGuiaAsociada = informeEnsayoLiquido.DetalleGuia ?? await _detalleGuiaRepository.Get(informeEnsayoLiquido.DetalleGuiaId, false);

            var responseClienteOsinergmin = await _osinergminClient.registrarInformeLabLiquidoCalidadAsync(
                new informeLiquido
                {
                    loginUsuario = _osinergminConfig.Usuario,
                    claveUsuario = _osinergminConfig.Password,
                    nroMuestra = detalleGuiaAsociada.NumeroMuestra,
                    nroGuia = detalleGuiaAsociada.Guia.NumeroGuia,

                    observaciones = informeEnsayoLiquido.Observaciones,
                    numeroInformeLaboratorio = informeEnsayoLiquido.NumeroInformeLaboratorio,
                    octanaje = informeEnsayoLiquido.Octanaje,
                    puntoInflamacion = informeEnsayoLiquido.PuntoInflamacion,
                    presionVaporReid = informeEnsayoLiquido.PresionVaporReid ?? default(float),
                    presionVaporReidSpecified = informeEnsayoLiquido.PresionVaporReid.HasValue,
                    contenidoAzufre4294 = informeEnsayoLiquido.ContenidoAzufre4294,
                    contenidoAzufre5453 = informeEnsayoLiquido.ContenidoAzufre5453,
                    viscosidadCinematica = informeEnsayoLiquido.ViscosidadCinematica ?? default(float),
                    viscosidadCinematicaSpecified = informeEnsayoLiquido.ViscosidadCinematica.HasValue, 
                    contenidoManganeso = informeEnsayoLiquido.ContenidoManganeso ?? default(float),
                    contenidoManganesoSpecified = informeEnsayoLiquido.ContenidoManganeso.HasValue,
                    puntoEscurrimiento = informeEnsayoLiquido.PuntoEscurrimiento,
                    contenidoPlomo = informeEnsayoLiquido.ContenidoPlomo,
                    contenidoPlomoAstmd3341 = informeEnsayoLiquido.ContenidoPlomoAstmd3341,
                    contenidoPlomoAstmd3237 = informeEnsayoLiquido.ContenidoPlomoAstmd3237,
                    astmd86_pie = informeEnsayoLiquido.Astmd86_pie ?? default(float),
                    astmd86_pieSpecified = informeEnsayoLiquido.Astmd86_pie.HasValue,
                    astmd86_5p = informeEnsayoLiquido.Astmd86_5p ?? default(float),
                    astmd86_5pSpecified = informeEnsayoLiquido.Astmd86_5p.HasValue,
                    astmd86_10p = informeEnsayoLiquido.Astmd86_10p ?? default(float),
                    astmd86_10pSpecified = informeEnsayoLiquido.Astmd86_10p.HasValue,
                    astmd86_20p = informeEnsayoLiquido.Astmd86_20p ?? default(float),
                    astmd86_20pSpecified = informeEnsayoLiquido.Astmd86_20p.HasValue,
                    astmd86_50p = informeEnsayoLiquido.Astmd86_50p ?? default(float),
                    astmd86_50pSpecified = informeEnsayoLiquido.Astmd86_50p.HasValue,
                    astmd86_90p = informeEnsayoLiquido.Astmd86_90p ?? default(float),
                    astmd86_90pSpecified = informeEnsayoLiquido.Astmd86_90p.HasValue,
                    astmd86_95p = informeEnsayoLiquido.Astmd86_95p ?? default(float),
                    astmd86_95pSpecified = informeEnsayoLiquido.Astmd86_95p.HasValue,
                    astmd86_pfe = informeEnsayoLiquido.Astmd86_pfe ?? default(float),
                    astmd86_pfeSpecified = informeEnsayoLiquido.Astmd86_pfe.HasValue,
                    astmd86_recup = informeEnsayoLiquido.Astmd86_recup ?? default(float),
                    astmd86_recupSpecified = informeEnsayoLiquido.Astmd86_recup.HasValue,
                    astmd86_residuo = informeEnsayoLiquido.Aastmd86_residuo ?? default(float),
                    astmd86_residuoSpecified = informeEnsayoLiquido.Aastmd86_residuo.HasValue,
                    astmd86_perdidas = informeEnsayoLiquido.Aastmd86_perdidas ?? default(float),
                    astmd86_perdidasSpecified = informeEnsayoLiquido.Aastmd86_perdidas.HasValue,
                    gravidadApi = informeEnsayoLiquido.GravidadApi ?? default(float),
                    gravidadApiSpecified = informeEnsayoLiquido.GravidadApi.HasValue,
                    densidadRelativa = informeEnsayoLiquido.DensidadRelativa ?? default(float),
                    densidadRelativaSpecified = informeEnsayoLiquido.DensidadRelativa.HasValue,
                    indiceCetano = informeEnsayoLiquido.IndiceCetano ?? default(float),
                    indiceCetanoSpecified = informeEnsayoLiquido.IndiceCetano.HasValue,
                    indiceCetanoProcedenciaA = informeEnsayoLiquido.IndiceCetanoProcedenciaA ?? default(float),
                    indiceCetanoProcedenciaASpecified = informeEnsayoLiquido.IndiceCetanoProcedenciaA.HasValue,
                    indiceCetanoProcedenciaB = informeEnsayoLiquido.IndiceCetanoProcedenciaB ?? default(float),
                    indiceCetanoProcedenciaBSpecified = informeEnsayoLiquido.IndiceCetanoProcedenciaB.HasValue,
                    indiceCetanoBajoAzufre = informeEnsayoLiquido.IndiceCetanoBajoAzufre ?? default(float),
                    indiceCetanoBajoAzufreSpecified = informeEnsayoLiquido.IndiceCetanoBajoAzufre.HasValue,
                    contenidoFameVolumen = informeEnsayoLiquido.ContenidoFameVolumen ?? default(float),
                    contenidoFameVolumenSpecified = informeEnsayoLiquido.ContenidoFameVolumen.HasValue,
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
                    reaccionAlAgua = informeEnsayoLiquido.ReaccionAlAgua ?? default(float),
                    reaccionAlAguaSpecified = informeEnsayoLiquido.ReaccionAlAgua.HasValue,
                    contenidoSolidos = informeEnsayoLiquido.ContenidoSolidos,
                    contenidoGomas = informeEnsayoLiquido.ContenidoGomas,
                    puntoCongelamiento = informeEnsayoLiquido.PuntoCongelamiento,
                    aguaSedimentos = informeEnsayoLiquido.AguaSedimentos,
                    determinacionBenceno = informeEnsayoLiquido.DeterminacionBenceno ?? default(float),
                    determinacionBencenoSpecified = informeEnsayoLiquido.DeterminacionBenceno.HasValue,
                    aguaPorDestilacion = informeEnsayoLiquido.AguaPorDestilacion,
                    contaminacionParticulas = informeEnsayoLiquido.ContaminacionParticulas,
                    indiceCetanoFme = informeEnsayoLiquido.IndiceCetanoFme,
                    color = informeEnsayoLiquido.Color,
                    resultadoFinal = informeEnsayoLiquido.ResultadoFinal,
                    remanenteRetirado = informeEnsayoLiquido.RemanenteRetirado,
                    nroGuiaSpecified = true,
                    nroMuestraSpecified = true,
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
            var detalleGuiaAsociada = informeEnsayoGlp.DetalleGuia ?? await _detalleGuiaRepository.Get(informeEnsayoGlp.DetalleGuiaId);

            var responseClienteOsinergmin = await _osinergminClient.registrarInformeLabGlpCalidadAsync(
                new informeGlp
                {
                    loginUsuario = _osinergminConfig.Usuario,
                    claveUsuario = _osinergminConfig.Password,
                    nroMuestra = detalleGuiaAsociada.NumeroMuestra,
                    nroGuia = detalleGuiaAsociada.Guia.NumeroGuia,

                    observaciones = informeEnsayoGlp.Observaciones,
                    numeroInformeLaboratorio = informeEnsayoGlp.NumeroInformeLaboratorio,
                    densidadRelativa = informeEnsayoGlp.DensidadRelativa ?? default(float),
                    densidadRelativaSpecified = informeEnsayoGlp.DensidadRelativa.HasValue,
                    presionVapor = informeEnsayoGlp.PresionVapor ?? default(float),
                    presionVaporSpecified = informeEnsayoGlp.PresionVapor.HasValue,
                    numeroOctanoMotor = informeEnsayoGlp.NumeroOctanoMotor,
                    metanoMol = informeEnsayoGlp.MetanoMol,
                    etanoMol = informeEnsayoGlp.EtanoMol,
                    etilenoMol = informeEnsayoGlp.EtilenoMol,
                    propanoMol = informeEnsayoGlp.PropanoMol ?? default(float),
                    propanoMolSpecified = informeEnsayoGlp.PropanoMol.HasValue,
                    propilenoMol = informeEnsayoGlp.PropilenoMol,
                    isobutanoMol = informeEnsayoGlp.IsobutanoMol ?? default(float),
                    isobutanoMolSpecified = informeEnsayoGlp.IsobutanoMol.HasValue,
                    nbutanoMol = informeEnsayoGlp.NbutanoMol ?? default(float),
                    nbutanoMolSpecified = informeEnsayoGlp.NbutanoMol.HasValue,
                    trans2butenoMol = informeEnsayoGlp.Trans2butenoMol,
                    butenoMol = informeEnsayoGlp.ButenoMol,
                    isobutilenoMol = informeEnsayoGlp.IsobutilenoMol,
                    cis2butenoMol = informeEnsayoGlp.Cis2butenoMol ?? default(float),
                    cis2butenoMolSpecified = informeEnsayoGlp.Cis2butenoMol.HasValue,
                    isopentanoMol = informeEnsayoGlp.IsopentanoMol ?? default(float),
                    isopentanoMolSpecified = informeEnsayoGlp.IsopentanoMol.HasValue,
                    npentanoMol = informeEnsayoGlp.NpentanoMol,
                    butadienoMol = informeEnsayoGlp.ButadienoMol,
                    hexano = informeEnsayoGlp.Hexano,
                    corrosionLaminaCobre = informeEnsayoGlp.CorrosionLaminaCobre,
                    determinacionEtilMercaptano = informeEnsayoGlp.DeterminacionEtilMercaptano ?? default(float),
                    determinacionEtilMercaptanoSpecified = informeEnsayoGlp.DeterminacionEtilMercaptano.HasValue,
                    nroGuiaSpecified = true,
                    nroMuestraSpecified = true
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
