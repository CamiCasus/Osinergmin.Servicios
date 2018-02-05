using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.MainModule.Osinergmin
{
    public class OsinergminResponse
    {
        public bool Exito { get; set; }
        public string Mensaje { get; set; }

        public object Parametro { get; set; }
    }
}
