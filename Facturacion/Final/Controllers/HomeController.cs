using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Final.Models;
using Microsoft.AspNetCore.Authorization;
using Final.Services;
using Final.Models.HomeViewModels;

namespace Final.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private productoServices _productoServices;
        private FacturaServices _facturaServices;
        private IClientesData _clienteData;

        public HomeController(productoServices productoServices,
                              FacturaServices facturaServices,
                              IClientesData clientesData)
        {
            _productoServices = productoServices;
            _facturaServices = facturaServices;
            _clienteData = clientesData;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CrearProducto()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CrearProducto(ProductosEditModel model)
        {
            if (ModelState.IsValid)
            {
                var newProducto = new productos();
                newProducto.nombre = model.nombre;
                newProducto.cantidad = model.cantidad;
                newProducto.detalle = model.detalle;
                newProducto.precio = model.precio;
                
                newProducto = _productoServices.Crea(newProducto);

                return RedirectToAction(nameof(DetalleProducto), new { id = newProducto.Id });
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult CrearCliente()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CrearCliente(ClienteEditModel model)
        {
            if (ModelState.IsValid)
            {
                var newCliente = new Cliente();
                newCliente.Nombre = model.nombre;
                newCliente.cedula = model.cedula;
                newCliente.telefono = model.telefono;
                newCliente.direccion = model.direccion;
                newCliente.Email = model.Email;

                newCliente = _clienteData.Add(newCliente);

                return RedirectToAction(nameof(DetalleCliente), new { id = newCliente.id });
            }
            else
            {
                return View();
            }
        }

        
        public IActionResult DetalleProducto(int id)
        {
            var model = _productoServices.GetById(id);
            if (model == null)
            {
                return RedirectToAction("Inventario");
            }
            return View(model);
        }

        public IActionResult Inventario(Cliente cliente = null)
        {
            var model = new HomeInventarioModel();
            model.productos = _productoServices.GetAll();
            return View(model);
            
        }

        public IActionResult DetalleCliente(int id)
        {
            var model = _clienteData.Get(id);
            if (model == null)
            {
                return RedirectToAction("Clientes");
            }
            return View(model);
        }

        public IActionResult Clientes(Cliente cliente = null)
        {
            var model = new HomeClientesModel();
            model.clientes = _clienteData.GetAll();
            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
