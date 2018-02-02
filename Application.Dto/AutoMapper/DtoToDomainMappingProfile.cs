using AutoMapper;
using Domain.MainModule.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Application.Dto.AutoMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile()
        {
            CreateMap<GuiaEntidadDto, GuiaEntity>()
                .ForMember(d => d.FechaRecepcion, x => x.MapFrom(p => DateTime.ParseExact(p.FechaRecepcion, "yyyy-MM-dd", CultureInfo.InvariantCulture)))
                .ForMember(d => d.Detalles, x => x.Ignore())
                .AfterMap(AddOrUpdateDetails);

            CreateMap<DetalleGuiaEntidadDto, DetalleGuiaEntity>()
                .ForMember(d => d.FechaMuestreo, x => x.MapFrom(p => DateTime.ParseExact(p.FechaMuestreo, "yyyy-MM-dd", CultureInfo.InvariantCulture)));
        }

        private void AddOrUpdateDetails(GuiaEntidadDto dto, GuiaEntity guiaEntity)
        {
            foreach (var detalleGuiaDto in dto.DetalleGuia)
            {
                if (detalleGuiaDto.Id == 0)
                {
                    if (guiaEntity.Detalles == null)
                        guiaEntity.Detalles = new List<DetalleGuiaEntity>();

                    guiaEntity.Detalles.Add(Mapper.Map<DetalleGuiaEntity>(detalleGuiaDto));                    
                }
                else
                {
                    Mapper.Map(detalleGuiaDto, guiaEntity.Detalles.SingleOrDefault(c => c.Id == detalleGuiaDto.Id));
                }
            }
        }
    }
}
