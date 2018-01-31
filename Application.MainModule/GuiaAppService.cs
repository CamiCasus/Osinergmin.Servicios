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
            var resultadoEntidad = _guiaRepository.Find(p => true).ToList();
            return _mapper.Map<IEnumerable<GuiaListadoDto>>(resultadoEntidad);
        }

        public IEnumerable<DetalleGuiaListadoDto> ObtenerDetalleGuiaListado(int guiaId)
        {
            var resultadoEntidad = _detalleGuiaRepository.Find(p => true).ToList();
            return _mapper.Map<IEnumerable<DetalleGuiaListadoDto>>(resultadoEntidad);
        }

        public GuiaEntidadDto ObtenerGuia(long guiaId)
        {
            var entidadDomain = _guiaRepository.Find(p => p.Id == guiaId).First();
            return _mapper.Map<GuiaEntidadDto>(entidadDomain);
        }

        public void Agregar(GuiaEntidadDto entidadDto)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                var entidadDomain = _mapper.Map<GuiaEntity>(entidadDto);
                _guiaRepository.Add(entidadDomain);

                _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void Eliminar(long id)
        {
            _unitOfWork.BeginTransaction();

            var entidadDomain = _guiaRepository.Find(p => p.Id == id).FirstOrDefault();
            _guiaRepository.Delete(entidadDomain);

            _unitOfWork.SaveChanges();
        }
    }
}
