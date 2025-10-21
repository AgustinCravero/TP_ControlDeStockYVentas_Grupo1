using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTP.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public double MontoTotal { get; set; }
        public List<DetalleVenta> DetallesVenta { get; set; } = new List<DetalleVenta>();
        public Venta() { }
        public Venta(DateTime Fecha, List<DetalleVenta> DetallesVenta)
        {
            this.Fecha = Fecha;
            this.DetallesVenta = DetallesVenta;
            MontoTotal = 0;
        }
    }
}
