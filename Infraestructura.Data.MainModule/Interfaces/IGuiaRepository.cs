using Domain.MainModule.Entities;
using Infraestructura.Data.MainModule.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Data.MainModule.Interfaces
{
    public interface IGuiaRepository : IRepository<GuiaEntity, int>
    {
    }
}
