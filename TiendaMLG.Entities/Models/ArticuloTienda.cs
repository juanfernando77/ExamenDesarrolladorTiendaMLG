using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMLG.Entities.Models
{
    public class ArticuloTienda
    {
        public int ID { get; set; } 
        public int ArticuloID { get; set; } 
        public int TiendaID { get; set; } 
        public DateTime Fecha { get; set; } = DateTime.Now; 

        public Articulo Articulo { get; set; }
        public Tienda Tienda { get; set; }
    }
}
