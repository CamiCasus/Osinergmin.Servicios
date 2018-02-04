using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.MainModule.Entities
{
    public class UsuarioEntity
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public int Estado { get; set; }
    }
}
