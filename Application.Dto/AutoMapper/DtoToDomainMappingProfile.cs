using AutoMapper;
using Domain.MainModule.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dto.AutoMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile()
        {
            CreateMap<GuiaEntidadDto, GuiaEntity>();
        }
    }
}
