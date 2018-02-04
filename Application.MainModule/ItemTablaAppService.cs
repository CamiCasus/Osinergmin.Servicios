using Application.Dto;
using Application.MainModule.Core;
using Application.MainModule.Interfaces;
using AutoMapper;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
using System.Collections.Generic;

namespace Application.MainModule
{
    public class ItemTablaAppService : BaseAppService, IItemTablaAppService
    {
        private readonly IItemTablaRepository _itemTablaRepository;

        public ItemTablaAppService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IItemTablaRepository itemTablaRepository)
            :base(unitOfWork, mapper)
        {
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
