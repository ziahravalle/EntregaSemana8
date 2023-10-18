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

       [Route("Admin/listarProductos")]
        public IActionResult listarProductos()
        {
            return View(obj.GetAllProductos());
        }


        [Route("Admin/Grabar")]
        public IActionResult agregarProducto(TbProducto producto)
        {
            obj.Add(producto);
            return RedirectToAction("Grabar");
        }


        [Route("Admin/editarProductos/{cod}")]
        public IActionResult editarProductos(string cod)
        {
            return View(obj.GetProducto(cod));
        }


        [Route("Admin/eliminarProductos/{cod}")]
        public IActionResult eliminarProductos(string cod)
        {
            return RedirectToAction("Listar");
        }

        public IActionResult EditDetails(TbProducto tbProducto)
        {
            obj.Update(tbProducto);
            return RedirectToAction("listarProductos");
        }

        //clientes productos proveedores trabajadores
    }
}
