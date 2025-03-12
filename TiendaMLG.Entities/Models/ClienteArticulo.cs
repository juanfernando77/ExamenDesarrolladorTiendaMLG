using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMLG.Entities.Models
{
    public class ClienteArticulo
    {
        public int ID { get; set; } // Clave primaria
        public int ClienteID { get; set; } // Clave foránea de Cliente
        public int ArticuloID { get; set; } // Clave foránea de Articulo
        public DateTime Fecha { get; set; } = DateTime.Now; // Fecha de compra

        // Relaciones con Cliente y Articulo
        public Cliente Cliente { get; set; }
        public Articulo Articulo { get; set; }
    }
}
