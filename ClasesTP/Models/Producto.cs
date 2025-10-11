using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTP.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public List<DetalleVenta> DetallesVenta { get; set; } = new List<DetalleVenta>();
        public List<DetalleEntrega> DetallesEntrega { get; set; } = new List<DetalleEntrega>();
    }
}
