﻿using Domain.MainModule.Entities;
using Infraestructura.Data.MainModule.Core.Interfaces;

namespace Infraestructura.Data.MainModule.Interfaces
{
    public interface IGuiaRepository : IRepository<GuiaEntity, int>
    {
    }
}
