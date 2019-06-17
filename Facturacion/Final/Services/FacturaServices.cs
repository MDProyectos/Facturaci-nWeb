using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final.Models;
namespace Final.Services
{
    public interface FacturaServices
    {
        factura Crea(factura factura);
        IEnumerable<factura> GetAll();
        factura GetById(int id);
        void Eliminar(factura factura);
        factura actualizar(factura factura);
    }
}
