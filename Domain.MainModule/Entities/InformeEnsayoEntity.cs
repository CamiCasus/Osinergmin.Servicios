namespace Domain.MainModule.Entities
{
    public class InformeEnsayoEntity
    {
        public int Id { get; set; }
        public int Version { get; set; }
        public string CodigoRecepcion { get; set; }

        public int DetalleGuiaId { get; set; }
        public DetalleGuiaEntity DetalleGuia { get; set; }
    }
}
