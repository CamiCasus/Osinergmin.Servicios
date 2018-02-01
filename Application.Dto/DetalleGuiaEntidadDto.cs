using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dto
{
    public class DetalleGuiaEntidadDto
    {
        public int Id { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoEstablecimiento { get; set; }
        public int CantidadMuestras { get; set; }
        public DateTime FechaMuestreo { get; set; }
        public string NumeroActa { get; set; }
        public int NumeroMuestra { get; set; }
        public string NumeroPrescintoDirimencia { get; set; }
        public string NumeroPrescintoLaboratorio { get; set; }
        public string OrigenProducto { get; set; }
        public string TipoEnvase { get; set; }
        public string NombreArchivo { get; set; }
        public string FotoMuestra { get; set; }
        public int TipoMuestra { get; set; }
    }
}
