using System;
using System.Collections.Generic;

namespace punto.Models
{
    public partial class Factura
    {
        public Factura()
        {
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int IdFactura { get; set; }
        public int? IdCliente { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
