using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTP.Models
{
    public class DetalleEntrega
    {
        public int ID { get; set; }
        public int EntregaProveedorId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public EntregaProveedor EntregaProveedor { get; set; } 
    }
}
