using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesTP.Models;

namespace ClasesTP.Data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<DetalleVenta> DetallesVenta { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<EntregaProveedor> EntregasProveedor { get; set; }
        public DbSet<DetalleEntrega> DetallesEntrega { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost;Database=TPWindowsForms;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
