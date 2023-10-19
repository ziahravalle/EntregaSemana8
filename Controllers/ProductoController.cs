using EntregaSemana8.Models;
using EntregaSemana8.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EntregaSemana8.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IProducto obj;

        public ProductoController (IProducto productoObj)
        {
            obj = productoObj;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VerProducto()
        {
            return View();
            
        }
        public IActionResult Carrito()
        {
            return View();
        }


        [Route("producto/listar")]
        public IActionResult Listar()
        {
            return View(obj.GetAllProductos());
        }

        //[Route("producto/grabar")]
        public IActionResult Grabar(TbProducto producto)
        {
            obj.Add(producto);
            //return View("Producto");
            return RedirectToAction("Listar");
        }


        [Route("Producto/Edit/{cod}")]
        public IActionResult Edit(string cod)
        {
            return View(obj.GetProducto(cod));
        }

        public IActionResult EditDetails(TbProducto tbProducto)
        {
            obj.Update(tbProducto);
            return RedirectToAction("Listar");
        }


        [Route("Producto/Delete/{cod}")]
        public IActionResult Delete(string cod)
        {
            return RedirectToAction("Listar");
        }
    }
}
