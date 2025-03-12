using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMLG.Entities.Models
{
    public class ArticuloTienda
    {
        public int ID { get; set; } // Clave primaria
        public int ArticuloID { get; set; } // Clave foránea de Articulo
        public int TiendaID { get; set; } // Clave foránea de Tienda
        public DateTime Fecha { get; set; } = DateTime.Now; // Fecha de asociación

        // Relaciones con Articulo y Tienda
        public Articulo Articulo { get; set; }
        public Tienda Tienda { get; set; }
    }
}
