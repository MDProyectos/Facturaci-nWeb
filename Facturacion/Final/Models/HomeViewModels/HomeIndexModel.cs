using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models.HomeViewModels
{
    public class HomeIndexModel
    {
        public IEnumerable<productos> productos { get; set; }
        public IEnumerable<Cliente> clientes { get; set; }
    }
}
