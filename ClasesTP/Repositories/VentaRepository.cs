using ClasesTP.Data;
using ClasesTP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ClasesTP.Repositories
{
    public static class VentaRepository
    {
        public static void GuardarVenta(Venta venta)
        {
            using var context = new AplicationDbContext();
            foreach (var d in venta.DetallesVenta)
            {
                d.Producto = null;
            }
            context.Ventas.Add(venta);
            
            foreach (var detalle in venta.DetallesVenta)
            {
                var producto = context.Productos.Find(detalle.ProductoId);
                if (producto != null)
                {
                    producto.Stock -= detalle.Cantidad;
                }
            }
            context.SaveChanges();
        }
        public static List<Venta> ObtenerVentasPorRango(DateTime desde, DateTime hasta)
        {
            using var context = new AplicationDbContext();
                return context.Ventas
                    .Where(v => v.Fecha >= desde && v.Fecha <= hasta)
                    .ToList();
        }
    }
}
