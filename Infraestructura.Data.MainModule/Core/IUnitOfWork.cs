using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Data.MainModule.Core
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void SaveChanges();
    }
}
