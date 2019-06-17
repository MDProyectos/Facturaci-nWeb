using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final.Models;
using Final.Data;
using Microsoft.EntityFrameworkCore;

namespace Final.Services
{
    public class ServiceFactura : FacturaServices
    {
        private readonly ApplicationDbContext _context;
        public ServiceFactura(ApplicationDbContext ctx)
        {
            _context = ctx;
        }

        public factura actualizar(factura factura)
        {
            _context.Attach(factura).State = EntityState.Modified;
            _context.SaveChanges();
            return factura;
        }

        public factura Crea(factura factura)
        {
            _context.factura.Add(factura);
            _context.SaveChanges();
            return factura;
        }

        public void Eliminar(factura factura)
        {
            _context.Attach(factura).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public IEnumerable<factura> GetAll()
        {
            return _context.factura.OrderBy(r => r.id);
        }

        public factura GetById(int id)
        {
            return _context.factura.FirstOrDefault(r => r.id == id);
        }
    }
}
