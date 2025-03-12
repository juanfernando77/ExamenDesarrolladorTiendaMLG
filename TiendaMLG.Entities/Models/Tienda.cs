using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMLG.Entities.Models
{
    [Table("Tiendas")]
    public class Tienda
    {
        public int TiendaID { get; set; } // Clave primaria
        public string Sucursal { get; set; } // Nombre de la tienda
        public string Direccion { get; set; } // Dirección de la tienda

        // Relación con ArticuloTienda (Una tienda puede vender muchos artículos)
        public ICollection<ArticuloTienda> ArticuloTiendas { get; set; }

    }
}
