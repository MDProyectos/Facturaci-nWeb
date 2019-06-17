using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final.Models;

namespace Final.Services
{
    public interface productoServices
    {
        productos Crea(productos productos);
        IEnumerable<productos> GetAll();
        productos GetById(int id);
        void Eliminar(productos productos);
        productos actualizar(productos productos);
    }
}
