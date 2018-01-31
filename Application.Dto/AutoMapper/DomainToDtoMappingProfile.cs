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
            CreateMap<GuiaEntity, GuiaEntidadDto>();
        }
    }
}
