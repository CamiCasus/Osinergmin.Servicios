using Application.Dto;
using System.Collections.Generic;

namespace Application.MainModule.Interfaces
{
    public interface IItemTablaAppService
    {
        IEnumerable<ItemTablaEntidadDto> ObtenerDatosMaestro(int tipoTabla);
    }
}
