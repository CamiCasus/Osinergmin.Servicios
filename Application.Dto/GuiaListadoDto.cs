using System;

namespace Application.Dto
{
    public class GuiaListadoDto
    {
        public int Id { get; set; }
        public string NumeroGuia { get; set; }
        public string Codigo { get; set; }
        public string RepresentanteOsinergmin { get; set; }
        public string RepresentanteIntertek { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public int Estado { get; set; }
    }
}
