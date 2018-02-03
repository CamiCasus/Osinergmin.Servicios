using AutoMapper;
using Domain.MainModule.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dto.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<GuiaEntity, GuiaListadoDto>();
            CreateMap<DetalleGuiaEntity, DetalleGuiaListadoDto>();
            CreateMap<GuiaEntity, GuiaEntidadDto>()
                .ForMember(d => d.FechaRecepcion, x => x.MapFrom(p => p.FechaRecepcion.ToString("yyyy-MM-dd")))
                .ForMember(d => d.DetalleGuia, x => x.MapFrom(p => p.Detalles));

            CreateMap<DetalleGuiaEntity, DetalleGuiaEntidadDto>()
                .ForMember(d => d.FechaMuestreo, x => x.MapFrom(p => p.FechaMuestreo.ToString("yyyy-MM-dd")))
                .ForMember(d => d.TipoProducto, x => x.MapFrom(p => p.Producto.TipoProducto))
                .ForMember(d => d.NombreProducto, x => x.MapFrom(p => p.Producto.Nombre));

            CreateMap<ProductoEntity, ProductoEntidadDto>();
            CreateMap<ItemTablaEntity, ItemTablaEntidadDto>();
        }
    }
}
