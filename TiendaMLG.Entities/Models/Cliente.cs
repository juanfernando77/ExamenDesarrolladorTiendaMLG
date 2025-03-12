using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMLG.Entities.Models
{
    public class Cliente
    {
            
            public int ClienteID { get; set; } // Clave primaria
            public string Nombre { get; set; } // Nombre del cliente
            public string Apellidos { get; set; } // Apellidos del cliente
            public string Direccion { get; set; } // Dirección del cliente

            // Relación con ClienteArticulo (Un cliente puede comprar muchos artículos)
            public ICollection<ClienteArticulo> ClienteArticulos { get; set; }
        

    }
}
