﻿using AutoMapper;
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

            CreateMap<DetalleGuiaEntity, DetalleGuiaEntidadDto>();
        }
    }
}
