﻿using Application.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.MainModule.Interfaces
{
    public interface IProductoAppService
    {
        IEnumerable<ProductoEntidadDto> ObtenerProductos();
    }
}
