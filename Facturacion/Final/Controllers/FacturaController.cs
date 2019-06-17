using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final.Services;
using Microsoft.AspNetCore.Mvc;

namespace Final.Controllers
{
    public class FacturaController : Controller
    {
        private FacturaServices _facturaServices;

        public FacturaController(FacturaServices facturaServices)
        {
            _facturaServices = facturaServices;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
