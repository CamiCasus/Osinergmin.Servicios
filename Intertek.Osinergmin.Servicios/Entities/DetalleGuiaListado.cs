using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intertek.Osinergmin.Servicios.Entities
{
    public class DetalleGuiaListado
    {
        public int Id { get; set; }
        public string Guia { get; set; }
        public int NumeroMuestra { get; set; }
        public int TipoMuestra { get; set; }
        public string Ensayos { get; set; }
    }
}
