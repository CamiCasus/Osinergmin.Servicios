﻿using Domain.MainModule.Entities;
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
