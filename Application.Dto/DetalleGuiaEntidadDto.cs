namespace Application.Dto
{
    public class DetalleGuiaEntidadDto
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public int TipoProducto { get; set; }
        public string CodigoEstablecimiento { get; set; }
        public int CantidadMuestras { get; set; }
        public string FechaMuestreo { get; set; }
        public string NumeroActa { get; set; }
        public int NumeroMuestra { get; set; }
        public string NumeroPrescintoDirimencia { get; set; }
        public string NumeroPrescintoLaboratorio { get; set; }
        public string OrigenProducto { get; set; }
        public string TipoEnvase { get; set; }
        public string NombreEnvase { get; set; }
        public string NombreArchivo { get; set; }
        public string FotoMuestra { get; set; }
        public int TipoMuestra { get; set; }
        public string Observaciones { get; set; }
    }
}
