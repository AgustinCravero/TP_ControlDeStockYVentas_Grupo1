using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTP.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Observaciones { get; set; }
        public List<EntregaProveedor> Entregas { get; set; } = new List<EntregaProveedor>(); 
    }
}
