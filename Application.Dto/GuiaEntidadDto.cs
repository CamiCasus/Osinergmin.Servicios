using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dto
{
    public class GuiaEntidadDto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string FechaRecepcion { get; set; }
        public string RepresentanteOsinergmin { get; set; }
        public string DniRepresentanteOsinergmin { get; set; }
        public string RepresentanteIntertek { get; set; }
        public string DniRepresentanteIntertek { get; set; }
        public string SupervisorExtraccionMuestra { get; set; }
        public string Comentario { get; set; }
        public string NombreArchivo { get; set; }
        public string GuiaAdjunta { get; set; }
    }
}
