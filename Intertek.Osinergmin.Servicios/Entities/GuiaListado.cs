using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intertek.Osinergmin.Servicios.Entities
{
    public class GuiaListado
    {
        public string Codigo { get; set; }
        public string RepresentanteOsinergmin { get; set; }
        public string RepresentanteIntertek { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
