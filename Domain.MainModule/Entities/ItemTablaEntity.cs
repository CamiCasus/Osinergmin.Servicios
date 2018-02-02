using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.MainModule.Entities
{
    public class ItemTablaEntity
    {
        public int Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual string Valor { get; set; }
        public virtual int TablaId { get; set; }
        public int Estado { get; set; }
        public virtual TablaEntity Tabla { get; set; }
    }
}
