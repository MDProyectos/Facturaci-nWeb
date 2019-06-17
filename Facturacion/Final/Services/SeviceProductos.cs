using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final.Models;
using Final.Data;
using Microsoft.EntityFrameworkCore;

namespace Final.Services
{
    public class SeviceProductos : productoServices
    {
        private readonly ApplicationDbContext _context;
        public SeviceProductos(ApplicationDbContext tx)
        {
            _context = tx;
        }

        public productos actualizar(productos productos)
        {
            _context.Attach(productos).State = EntityState.Modified;
            _context.SaveChanges();
            return productos;
        }

        public productos Crea(productos productos)
        {
            _context.productos.Add(productos);
            _context.SaveChanges();
            return productos;
        }

        public void Eliminar(productos productos)
        {
            _context.Attach(productos).State = EntityState.Deleted;
            _context.SaveChanges();
            
        }

        public IEnumerable<productos> GetAll()
        {
            return _context.productos.OrderBy(r => r.nombre);
        }

        public productos GetById(int id)
        {
            return _context.productos.FirstOrDefault(r => r.Id == id);
        }
    }
}
