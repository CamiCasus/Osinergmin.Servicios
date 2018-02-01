using AutoMapper;
using Domain.MainModule.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Application.Dto.AutoMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile()
        {
            CreateMap<GuiaEntidadDto, GuiaEntity>()
                .ForMember(d => d.FechaRecepcion, x => x.MapFrom(p => DateTime.ParseExact(p.FechaRecepcion, "yyyy-MM-dd", CultureInfo.InvariantCulture)));
        }
    }
}
