using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final.Data;
using Final.Models;
using Microsoft.EntityFrameworkCore;

namespace Final.Services
{
    public class SqlClientesData : IClientesData
    {
        private ApplicationDbContext _context;

        public SqlClientesData(ApplicationDbContext context)
        {
            _context = context;
        }

        public Cliente Add(Cliente cliente)
        {
            _context.clientes.Add(cliente);
            _context.SaveChanges();
            return cliente;
        }

        public void Delete(Cliente cliente)
        {
            _context.Attach(cliente).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public Cliente Get(int id)
        {
            return _context.clientes.FirstOrDefault(r => r.id == id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _context.clientes.OrderBy(r => r.Nombre);
        }

        public Cliente Update(Cliente cliente)
        {
            _context.Attach(cliente).State = EntityState.Modified;
            _context.SaveChanges();
            return cliente;
        }
    }
}
