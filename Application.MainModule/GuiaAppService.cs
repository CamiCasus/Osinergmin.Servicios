using Application.Dto;
using Application.MainModule.Interfaces;
using AutoMapper;
using Domain.MainModule.Entities;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MainModule
{
    public class GuiaAppService : IGuiaAppService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGuiaRepository _guiaRepository;
        private readonly IDetalleGuiaRepository _detalleGuiaRepository;        

        public GuiaAppService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IGuiaRepository guiaRepository, 
            IDetalleGuiaRepository detalleGuiaRepository)
        {
            _guiaRepository = guiaRepository;
            _detalleGuiaRepository = detalleGuiaRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
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

        public async Task Agregar(GuiaEntidadDto entidadDto)
        {
            _unitOfWork.BeginTransaction();

            var entidadDomain = _mapper.Map<GuiaEntity>(entidadDto);
            await _guiaRepository.Add(entidadDomain);

            _unitOfWork.SaveChanges();
        }

        public void Eliminar(long id)
        {
            _unitOfWork.BeginTransaction();

            var entidadDomain = _guiaRepository.Find(p => p.Id == id).FirstOrDefault();
            _guiaRepository.Delete(entidadDomain);

            _unitOfWork.SaveChanges();
        }

        public async Task Actualizar(GuiaEntidadDto entidadDto)
        {
            _unitOfWork.BeginTransaction();

            var entidadDomain = await _guiaRepository.Get(entidadDto.Id, false);
            entidadDomain = _mapper.Map(entidadDto, entidadDomain);

            _unitOfWork.SaveChanges();
        }
    }
}
