using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesTP.Data;
using ClasesTP.Models;
using ClasesTP.Data;
using Microsoft.EntityFrameworkCore;

namespace ClasesTP.Repositories
{
    public static class ProductoRepository
    {
        public static void GuardarProducto(Producto producto)
        {
            using var context = new AplicationDbContext();
            context.Productos.Add(producto);
            context.SaveChanges();
        }
        public static List<Producto> ObtenerProductos()
        {
            using var context = new AplicationDbContext();
            return context.Productos.ToList();
        }
        public static void EliminarProducto (Producto producto)
        {
            using var context = new AplicationDbContext();
            context.Productos.Remove(producto);
            context.SaveChanges();
        }
        public static Producto ObtenerProductoPorId(int id)
        {
            using var context = new AplicationDbContext();
            return context.Productos.FirstOrDefault(p => p.Id == id);
        }
        public static void ActualizarProducto(Producto producto)
        {
            using var context = new AplicationDbContext();
            context.Productos.Update(producto);
            context.SaveChanges();
        }
    }
}
