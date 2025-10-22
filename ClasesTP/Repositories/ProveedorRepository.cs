using ClasesTP.Data;
using ClasesTP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTP.Repositories
{
    public static class ProveedorRepository
    {
        public static void GuardarProveedor(Proveedor proveedor)
        {
            using var context = new AplicationDbContext();
            context.Proveedores.Add(proveedor);
            context.SaveChanges();
        }
        public static List<Proveedor> ObtenerProveedores()
        {
            using var context = new AplicationDbContext();
            return context.Proveedores.ToList();
        }
        public static void EliminarProveedor(Proveedor proveedor)
        {
            using var context = new AplicationDbContext();
            context.Proveedores.Remove(proveedor);
            context.SaveChanges();
        }
        public static Proveedor ObtenerProveedorPorId(int id)
        {
            using var context = new AplicationDbContext();
            return context.Proveedores.FirstOrDefault(p => p.Id == id);
        }
        public static void ActualizarProveedor(Proveedor proveedor)
        {
            using var context = new AplicationDbContext();
            context.Proveedores.Update(proveedor);
            context.SaveChanges();
        }
    }
}
