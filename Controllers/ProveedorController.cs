using EntregaSemana8.Models;
using EntregaSemana8.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EntregaSemana8.Controllers
{
    public class ProveedorController : Controller
    {
        private readonly IProveedores objProv;
        public IActionResult Index()
        {
            return View();
        }


        //LISTAR
        [Route("proveedor/listar")]
        public IActionResult Listar()
        {
            return View(objProv.GetAllProveedores());
        }


        //GRABAR
        public IActionResult Grabar(TbProveedor proveedor)
        {
            objProv.Add(proveedor);
            return RedirectToAction("Listar");
        }


        //EDIT
        [Route("proveedor/Edit/{cod}")]
        public IActionResult Edit(int cod)
        {
            return View(objProv.GetProveedor(cod));
        }
        public IActionResult EditDetails(TbProveedor tbProveedor)
        {
            objProv.Update(tbProveedor);
            return RedirectToAction("Listar");
        }


        //DELETE
        [Route("proveedor/Delete/{cod}")]
        public IActionResult Delete(int cod)
        {
            objProv.Delete(cod);
            return RedirectToAction("Listar");
        }

    }
}
