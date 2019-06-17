using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Services
{
    public interface IClientesData
    {
        IEnumerable<Cliente> GetAll();
        Cliente Get(int id);
        Cliente Add(Cliente cliente);
        Cliente Update(Cliente cliente);
        void Delete(Cliente cliente);
    }
}
