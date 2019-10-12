using System;
using System.Collections.Generic;

namespace punto.Models
{
    public partial class Venta
    {
        public Venta()
        {
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int IdVenta { get; set; }
        public string Producto { get; set; }
        public decimal? Precio { get; set; }
        public int? Cantidad { get; set; }
        public string Cliente { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Total { get; set; }

        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
