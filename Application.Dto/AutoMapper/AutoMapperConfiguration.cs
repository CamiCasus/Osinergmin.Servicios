using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dto.AutoMapper
{
    public abstract class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToDtoMappingProfile>();
                x.AddProfile<DtoToDomainMappingProfile>();
            });
        }
    }
}
