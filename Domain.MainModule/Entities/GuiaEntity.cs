using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.MainModule.Entities
{
    public class GuiaEntity
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public string RepresentanteOsinergmin { get; set; }
        public string DniRepresentanteOsinergmin { get; set; }
        public string RepresentanteIntertek { get; set; }
        public string DniRepresentanteIntertek { get; set; }
        public string SupervisorExtraccionMuestra { get; set; }
        public string Comentario { get; set; }
        public string NombreArchivo { get; set; }
        public string GuiaAdjunta { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<DetalleGuiaEntity> Detalles { get; set; }
    }
}