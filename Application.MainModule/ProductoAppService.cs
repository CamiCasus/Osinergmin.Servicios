using Application.Dto;
using Application.MainModule.Interfaces;
using AutoMapper;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.MainModule
{
    public class ProductoAppService : IProductoAppService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IProductoRepository _productoRepository;

        public ProductoAppService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IProductoRepository productoRepository)
        {           
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _productoRepository = productoRepository;
        }

        public IEnumerable<ProductoEntidadDto> ObtenerProductos()
        {
            var productosEntidad = _productoRepository.All();
            return _mapper.Map<IEnumerable<ProductoEntidadDto>>(productosEntidad);
        }
    }
}
