using System;

namespace Domain.MainModule.Entities
{
    public class DetalleGuiaEntity
    {
        public int Id { get; set; }
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
        public string Observaciones { get; set; }

        public int GuiaId { get; set; }
        public int ProductoId { get; set; }

        public GuiaEntity Guia { get; set; }
        public ProductoEntity Producto { get; set; }
        public InformeEnsayoEntity InformeEnsayo { get; set; }

        public int Version { get; set; }
        public string Ensayos { get; set; }
    }
}