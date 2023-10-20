using EntregaSemana8.Models;
using EntregaSemana8.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EntregaSemana8.Controllers
{
    public class ProveedorController : Controller
    {
        private readonly IProveedores objP;

        public ProveedorController(IProveedores proveedorObj)
        {
            objP = proveedorObj;
        }
        public IActionResult Index(TbProveedor provee)
        {
            objP.Add(provee);
            return View();
        }


        [Route("proveedor/listar")]
        public IActionResult Listar()
        {
            return View(objP.GetAllProveedores());
        }

        [Route("proveedor/grabar")]
        public IActionResult Grabar(TbProveedor provee)
        {
            objP.Add(provee);
            //return View("Producto");
            return RedirectToAction("Listar");
        }


        [Route("proveedor/Edit/{cod}")]
        public IActionResult Edit(int cod)
        {
            return View(objP.GetProveedor(cod));
        }

        [Route("proveedor/Delete/{cod}")]
        public IActionResult Delete(int cod)
        {
            objP.Delete(cod);
            return RedirectToAction("Listar");
        }

        public IActionResult EditDetails(TbProveedor tbprovee)
        {
            objP.Update(tbprovee);
            return RedirectToAction("Listar");
        }
      


            

    }
}
