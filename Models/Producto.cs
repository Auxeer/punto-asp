using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace punto.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetallePedido = new HashSet<DetallePedido>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }

        public virtual ICollection<DetallePedido> DetallePedido { get; set; }

        [NotMapped]
        public List <Producto> Listasnom { get; set; }

        [NotMapped]
        public IEnumerable < SelectListItem > ProductoListItems  
        {  
            get  
            {  
                return new SelectList(Listasnom ?? new List<Producto>(), "Id", "Nombre"); 
        
            }
        }
    }
}
