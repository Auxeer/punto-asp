using System;
using System.Collections.Generic;

namespace punto.Models
{
    public partial class Admins
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Telefono { get; set; }
        public byte[] Creacion { get; set; }
    }
}
