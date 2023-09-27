using Microsoft.AspNetCore.Mvc;

namespace EntregaSemana8.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult vistaClientes() { 
            return View();
        }
        public IActionResult vistaProductos()
        {
            return View();
        }
        public IActionResult vistaProveedores()
        {
            return View();
        }
        public IActionResult vistaTrabajadores()
        {
            return View();
        }

        //clientes productos proveedores trabajadores
    }
}
