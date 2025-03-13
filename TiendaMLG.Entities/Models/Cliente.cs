using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMLG.Entities.Models
{
    public class Cliente
    {
            
            public int ClienteID { get; set; }
            public string Nombre { get; set; }
            public string Apellidos { get; set; } 
            public string Direccion { get; set; } 

            public ICollection<ClienteArticulo> ClienteArticulos { get; set; }
        

    }
}
