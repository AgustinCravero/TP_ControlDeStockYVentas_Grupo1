using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTP.Models
{
    public class EntregaProveedor
    {
        public int Id { get; set; }
        public int ProveedorId { get; set; }
        public DateTime Fecha { get; set; }
        public Proveedor Proveedor { get; set; }
        public List<DetalleEntrega> DetallesEntrega { get; set; } = new List<DetalleEntrega>();
    }
}
