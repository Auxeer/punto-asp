using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace punto.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Factura = new HashSet<Factura>();
        }

        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nit { get; set; }
        public string Direccion { get; set; }

        public virtual ICollection<Factura> Factura { get; set; }

        [NotMapped]
        public List <Cliente> ListasCli { get; set; }

        [NotMapped]
        public IEnumerable < SelectListItem > ClienteListItems  
        {  
            get  
            {  
                return new SelectList(ListasCli ?? new List<Cliente>(), "IdCliente", "Nombre"); 
        
            }
        }

    }
}
