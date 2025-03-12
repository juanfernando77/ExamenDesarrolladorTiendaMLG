using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMLG.Entities.Models
{
    public class Articulo
    {
        public int ArticuloID { get; set; } // Clave primaria
        public string Codigo { get; set; } // Código único del artículo
        public string Descripcion { get; set; } // Descripción del artículo
        public decimal Precio { get; set; } // Precio del artículo
        public string Imagen { get; set; } // URL de la imagen del artículo
        public int Stock { get; set; } // Cantidad de stock disponible

        // Relación con ArticuloTienda (Un artículo puede estar en varias tiendas)
        public ICollection<ArticuloTienda> ArticuloTiendas { get; set; }

        // Relación con ClienteArticulo (Un artículo puede ser comprado por varios clientes)
        public ICollection<ClienteArticulo> ClienteArticulos { get; set; }
    }
}
