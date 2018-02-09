using Application.Dto.Enums;
using AutoMapper;
using Domain.MainModule.Entities;
using Infraestructura.Data.MainModule.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dto.AutoMapper.Resolvers
{
    public class ItemTablaNombreByValorResolver : IMemberValueResolver<object, object, string, string>
    {
        private readonly string _propertyName;
        private readonly TipoTablaEnum _tipoTabla;
        private readonly IItemTablaRepository _itemTablaRepository;

        public ItemTablaNombreByValorResolver(string propertyName, TipoTablaEnum tipoTabla, IItemTablaRepository itemTablaRepository)
        {
            _propertyName = propertyName;
            _tipoTabla = tipoTabla;
            _itemTablaRepository = itemTablaRepository;
        }

        public string Resolve(object source, object destination, string sourceMember, string destMember, ResolutionContext context)
        {
            //if (!sourceMember.HasValue)
            //    return "n/a";

            return "";
        }
    }
}
