using Application.Dto;
using Application.MainModule.Core;
using Application.MainModule.Interfaces;
using AutoMapper;
using Domain.MainModule.Entities;
using Domain.MainModule.Osinergmin;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
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

        public GuiaAppService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IGuiaRepository guiaRepository, 
            IDetalleGuiaRepository detalleGuiaRepository,
            IOsinergminRepository osinergminRepository)
            :base(unitOfWork, mapper)
        {
            _guiaRepository = guiaRepository;
            _detalleGuiaRepository = detalleGuiaRepository;
            _osinergminRepository = osinergminRepository;
        }

        public IEnumerable<GuiaListadoDto> ObtenerListadoGuia()
        {
            var resultadoEntidad = _guiaRepository.All().ToList();
            return _mapper.Map<IEnumerable<GuiaListadoDto>>(resultadoEntidad);
        }

        public IEnumerable<DetalleGuiaListadoDto> ObtenerDetalleGuiaListado(int guiaId)
        {
            var resultadoEntidad = _detalleGuiaRepository.Find(p => p.GuiaId == guiaId).ToList();
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

            var guiaDomain = await _guiaRepository.Get(guiaId);
            var responseOsinergmin = await _osinergminRepository.ValidarMuestra(guiaDomain, codigoVerificacion);

            if (responseOsinergmin.Exito)
            {
                _unitOfWork.BeginTransaction();
                _unitOfWork.SaveChanges();
            }

            return responseOsinergmin;
        }
    }
}
