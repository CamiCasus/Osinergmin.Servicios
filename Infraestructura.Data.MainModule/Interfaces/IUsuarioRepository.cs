using Domain.MainModule.Entities;
using Infraestructura.Data.MainModule.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Data.MainModule.Interfaces
{
    public interface IUsuarioRepository : IRepository<UsuarioEntity, int>
    {
       
    }
}
