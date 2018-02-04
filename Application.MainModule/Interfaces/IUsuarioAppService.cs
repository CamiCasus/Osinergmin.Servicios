using System;
using System.Collections.Generic;
using System.Text;

namespace Application.MainModule.Interfaces
{
    public interface IUsuarioAppService
    {
        bool Autenticar(string usuario, string password);
    }
}
