using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestCore.Models
{
    public class Producto
    {
        //tener cuidado de no tener un campo con el mismo nombre de la clase
        [Key]//PK con la libreria System.ComponentModel.DataAnnotations;
        public int id { get; set; }
        public string Nombre { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }
    }
}
