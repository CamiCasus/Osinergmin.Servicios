using Application.Dto;
using Application.MainModule.Interfaces;
using AutoMapper;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
using System.Collections.Generic;

namespace Application.MainModule
{
    public class ItemTablaAppService : IItemTablaAppService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IItemTablaRepository _itemTablaRepository;

        public ItemTablaAppService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IItemTablaRepository itemTablaRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _itemTablaRepository = itemTablaRepository;
        }

        public IEnumerable<ItemTablaEntidadDto> ObtenerDatosMaestro(int tipoTabla)
        {
            try
            {
                var datosMaestrosDomain = _itemTablaRepository.Find(p => p.TablaId == tipoTabla);
                return _mapper.Map<IEnumerable<ItemTablaEntidadDto>>(datosMaestrosDomain);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}
