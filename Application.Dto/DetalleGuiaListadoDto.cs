using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dto
{
    public class DetalleGuiaListadoDto
    {
        public int Id { get; set; }
        public string Guia { get; set; }
        public int NumeroMuestra { get; set; }
        public int TipoMuestra { get; set; }
        public string Ensayos { get; set; }
    }
}
