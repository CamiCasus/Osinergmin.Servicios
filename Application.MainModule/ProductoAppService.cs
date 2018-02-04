using Application.Dto;
using Application.MainModule.Core;
using Application.MainModule.Interfaces;
using AutoMapper;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.MainModule
{
    public class ProductoAppService : BaseAppService, IProductoAppService
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoAppService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IProductoRepository productoRepository)
            :base(unitOfWork, mapper)
        {           
            _productoRepository = productoRepository;
        }

        public IEnumerable<ProductoEntidadDto> ObtenerProductos()
        {
            var productosEntidad = _productoRepository.All();
            return _mapper.Map<IEnumerable<ProductoEntidadDto>>(productosEntidad);
        }
    }
}
