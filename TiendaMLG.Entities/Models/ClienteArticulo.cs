using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMLG.Entities.Models
{
    public class ClienteArticulo
    {
        public int ID { get; set; } 
        public int ClienteID { get; set; } 
        public int ArticuloID { get; set; } 
        public DateTime Fecha { get; set; } = DateTime.Now; 

        public Cliente Cliente { get; set; }
        public Articulo Articulo { get; set; }
    }
}
