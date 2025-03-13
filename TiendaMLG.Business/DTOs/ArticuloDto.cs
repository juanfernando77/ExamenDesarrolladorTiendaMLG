using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMLG.Business.DTOs
{
    public class ArticuloDto
    {
        public int ArticuloID { get; set; }     
        public string Codigo { get; set; }        
        public string Descripcion { get; set; }       
        public decimal Precio { get; set; }
        public string? Imagen { get; set; }
        public int Stock { get; set; }
    }
}
