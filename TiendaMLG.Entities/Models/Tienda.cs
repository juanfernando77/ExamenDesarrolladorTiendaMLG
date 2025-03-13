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
        public int TiendaID { get; set; } 
        public string Sucursal { get; set; } 
        public string Direccion { get; set; } 

        public ICollection<ArticuloTienda> ArticuloTiendas { get; set; }

    }
}
