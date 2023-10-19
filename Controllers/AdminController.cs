using EntregaSemana8.Models;
using Microsoft.AspNetCore.Mvc;
using EntregaSemana8.Service.Interface;
using EntregaSemana8.Service.Repository;

namespace EntregaSemana8.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdmin obj;

        public AdminController(IAdmin adminObj) { 
            obj=adminObj;
        }
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
