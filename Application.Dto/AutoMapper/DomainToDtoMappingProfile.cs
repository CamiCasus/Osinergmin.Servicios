using AutoMapper;
using Domain.MainModule.Entities;

namespace Application.Dto.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<GuiaEntity, GuiaListadoDto>();
            CreateMap<UsuarioEntity, UsuarioLoginDto>();

            CreateMap<DetalleGuiaEntity, DetalleGuiaListadoDto>()
                .ForMember(p => p.TipoMuestra, x => x.MapFrom(d => d.Producto.TipoProducto))
                .ForMember(p => p.Guia, x => x.MapFrom(d => d.Guia.Codigo));

            CreateMap<GuiaEntity, GuiaEntidadDto>()
                .ForMember(p => p.GuiaAdjunta, x => x.Ignore())
                .ForMember(d => d.FechaRecepcion, x => x.MapFrom(p => p.FechaRecepcion.ToString("yyyy-MM-dd")))
                .ForMember(d => d.DetalleGuia, x => x.MapFrom(p => p.Detalles));

            CreateMap<DetalleGuiaEntity, DetalleGuiaEntidadDto>()
                .ForMember(p => p.FotoMuestra, x => x.Ignore())
                .ForMember(d => d.FechaMuestreo, x => x.MapFrom(p => p.FechaMuestreo.ToString("yyyy-MM-dd")))
                .ForMember(d => d.TipoProducto, x => x.MapFrom(p => p.Producto.TipoProducto))
                .ForMember(d => d.NombreProducto, x => x.MapFrom(p => p.Producto.Nombre))
                .ForMember(d=> d.NombreEnvase, x=>x.MapFrom(p=>p.TipoEnvase;

            CreateMap<ProductoEntity, ProductoEntidadDto>();
            CreateMap<ItemTablaEntity, ItemTablaEntidadDto>();
        }
    }
}
