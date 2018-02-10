using Application.Dto.Enums;
using Infraestructura.Data.MainModule.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Application.Dto.AutoMapper.Resolvers
{
    public static class ItemTablaResolver
    {
        public static IServiceCollection ServiceCollection;

        static ItemTablaResolver()
        {
        }

        public static string GetNameByValue(TipoTablaEnum tipoTabla, string valor)
        {
            var itemTablaRepository = ServiceCollection.BuildServiceProvider().GetServices<IItemTablaRepository>().First();

            var itemTablaActual = itemTablaRepository.Find(p => p.TablaId == (int)tipoTabla && p.Valor == valor).First();

            return itemTablaActual.Nombre;
        }
    }
}
