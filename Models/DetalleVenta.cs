using System;
using System.Collections.Generic;

namespace punto.Models
{
    public partial class DetalleVenta
    {
        public int IdDetalle { get; set; }
        public int? IdFactura { get; set; }
        public int? IdVenta { get; set; }
        public decimal? Total { get; set; }

        public virtual Factura IdFacturaNavigation { get; set; }
        public virtual Venta IdVentaNavigation { get; set; }
    }
}
