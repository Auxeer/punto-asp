using System;
using System.Collections.Generic;

namespace punto.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            DetallePedido = new HashSet<DetallePedido>();
        }

        public int IdPedido { get; set; }
        public string Producto { get; set; }
        public decimal? Precio { get; set; }
        public int? CantidadPedido { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<DetallePedido> DetallePedido { get; set; }
    }
}
