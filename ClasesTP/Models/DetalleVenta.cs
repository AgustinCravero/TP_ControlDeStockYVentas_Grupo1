using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTP.Models
{
    public class DetalleVenta
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double Subtotal { get; set; }
        public Venta Venta { get; set; }
        public Producto Producto { get; set; }
        public DetalleVenta() { }
        public DetalleVenta (int ProductoId, int Cantidad, double PrecioUnitario)
        {
            this.ProductoId = ProductoId;
            this.Cantidad = Cantidad;
            this.PrecioUnitario = PrecioUnitario;
            this.Subtotal = Cantidad * PrecioUnitario;
        }
    }
}
