using Application.Dto;
using Application.MainModule.Core;
using Application.MainModule.Interfaces;
using AutoMapper;
using Domain.MainModule.Entities;
using Domain.MainModule.Osinergmin;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.MainModule
{
    public class GuiaAppService : BaseAppService, IGuiaAppService
    {
        private readonly IGuiaRepository _guiaRepository;
        private readonly IDetalleGuiaRepository _detalleGuiaRepository;
        private readonly IOsinergminRepository _osinergminRepository;
        private readonly IInformeEnsayoRepository _informeEnsayoRepository;

        public GuiaAppService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IGuiaRepository guiaRepository, 
            IDetalleGuiaRepository detalleGuiaRepository,
            IInformeEnsayoRepository informeEnsayoRepository,
            IOsinergminRepository osinergminRepository)
            :base(unitOfWork, mapper)
        {
            _guiaRepository = guiaRepository;
            _detalleGuiaRepository = detalleGuiaRepository;
            _osinergminRepository = osinergminRepository;
            _informeEnsayoRepository = informeEnsayoRepository;
        }

        public IEnumerable<GuiaListadoDto> ObtenerListadoGuia()
        {
            var resultadoEntidad = _guiaRepository.All().ToList();
            return _mapper.Map<IEnumerable<GuiaListadoDto>>(resultadoEntidad);
        }

        public IEnumerable<DetalleGuiaListadoDto> ObtenerDetalleGuiaListado(int guiaId)
        {
            var resultadoEntidad = _detalleGuiaRepository.Find(p => p.GuiaId == guiaId && p.Ensayos != null).ToList();
            return _mapper.Map<IEnumerable<DetalleGuiaListadoDto>>(resultadoEntidad);
        }

        public async Task<GuiaEntidadDto> ObtenerGuia(int guiaId)
        {
            var entidadDomain = await _guiaRepository.Get(guiaId, false);
            return _mapper.Map<GuiaEntidadDto>(entidadDomain);
        }

        public async Task<OsinergminResponse> Agregar(GuiaEntidadDto entidadDto)
        {
            var entidadDomain = _mapper.Map<GuiaEntity>(entidadDto);
            var responseOsinergmin = await _osinergminRepository.RegistrarGuiaOsinergmin(entidadDomain);

            if (responseOsinergmin.Exito)
            {
                _unitOfWork.BeginTransaction();

                await _guiaRepository.Add(entidadDomain);

                _unitOfWork.SaveChanges();
            }           

            return responseOsinergmin;
        }

        public void Eliminar(long id)
        {
            _unitOfWork.BeginTransaction();

            var entidadDomain = _guiaRepository.Find(p => p.Id == id).FirstOrDefault();
            _guiaRepository.Delete(entidadDomain);

            _unitOfWork.SaveChanges();
        }

        public async Task<OsinergminResponse> Actualizar(GuiaEntidadDto entidadDto)
        {
            var entidadDomain = await _guiaRepository.Get(entidadDto.Id, false);
            entidadDomain = _mapper.Map(entidadDto, entidadDomain);

            var responseOsinergmin = await _osinergminRepository.RegistrarActualizarDetalle(entidadDomain);

            if (responseOsinergmin.Exito)
            {
                _unitOfWork.BeginTransaction();
                _unitOfWork.SaveChanges();
            }          

            return responseOsinergmin;
        }

        public async Task<OsinergminResponse> PresentarOsinergmin(int guiaId)
        {
            var guiaDomain = await _guiaRepository.Get(guiaId);
            return await _osinergminRepository.PresentarOsinergmin(guiaDomain);
        }

        public async Task<OsinergminResponse> ValidarMuestra(int guiaId, long codigoVerificacion)
        {
            _unitOfWork.BeginTransaction();

            var guiaDomain = await _guiaRepository.Get(guiaId, false);
            var responseOsinergmin = await _osinergminRepository.ValidarMuestra(guiaDomain, codigoVerificacion);

            if (responseOsinergmin.Exito)
            {
                _unitOfWork.BeginTransaction();
                _unitOfWork.SaveChanges();
            }

            return responseOsinergmin;
        }

        public async Task<OsinergminResponse> RegistrarInformeEnsayo(InformeEnsayoEntidadDto informeEnsayoEntidadDto)
        {
            OsinergminResponse respuesta;
            InformeEnsayoEntity informeEnsayoEntidad = informeEnsayoEntidad = await _informeEnsayoRepository.Get(informeEnsayoEntidadDto.Id, false);

            bool esNuevoRegistro = informeEnsayoEntidad == null;

            if (informeEnsayoEntidadDto is InformeEnsayoLiquidoEntidadDto)
            {
                var informeEnsayoLiquidoDto = informeEnsayoEntidadDto as InformeEnsayoLiquidoEntidadDto;                
                var informeEnsayoLiquidoEntidad = _mapper.Map(informeEnsayoLiquidoDto, informeEnsayoEntidad as InformeEnsayoLiquidoEntity);

                informeEnsayoEntidad = informeEnsayoLiquidoEntidad;
                respuesta = await _osinergminRepository.RegistrarInformeEnsayoCombustibleLiquido(informeEnsayoLiquidoEntidad);
            }
            else if(informeEnsayoEntidadDto is InformeEnsayoGlpEntidadDto)
            {
                var informeEnsayoGlpDto = informeEnsayoEntidadDto as InformeEnsayoGlpEntidadDto;
                var informeEnsayoGlpEntidad = _mapper.Map(informeEnsayoGlpDto, informeEnsayoEntidad as InformeEnsayoGlpEntity);

                informeEnsayoEntidad = informeEnsayoGlpEntidad;
                respuesta = await _osinergminRepository.RegistrarInformeEnsayoGlp(informeEnsayoGlpEntidad);
            }
            else
            {
                throw new Exception("El parametro enviado no pertenece a ningun tipo de informe de ensayo");
            }

            if (true)
            {
                _unitOfWork.BeginTransaction();

                if (esNuevoRegistro)
                    await _informeEnsayoRepository.Add(informeEnsayoEntidad);

                _unitOfWork.SaveChanges();
            }           

            return respuesta;
        }

        public async Task<InformeEnsayoEntidadDto> ObtenerInformeEnsayo(int detalleGuiaId)
        {
            var informeEnsayoEntidad = await _informeEnsayoRepository.GetByDetalleId(detalleGuiaId);

            if (informeEnsayoEntidad is InformeEnsayoLiquidoEntity)
                return _mapper.Map<InformeEnsayoLiquidoEntidadDto>(informeEnsayoEntidad as InformeEnsayoLiquidoEntity);
            else if (informeEnsayoEntidad is InformeEnsayoGlpEntity)
                return _mapper.Map<InformeEnsayoGlpEntidadDto>(informeEnsayoEntidad as InformeEnsayoGlpEntity);
            else
                return default(InformeEnsayoEntidadDto);
        }
    }
}
