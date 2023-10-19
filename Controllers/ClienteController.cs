using EntregaSemana8.Models;
using EntregaSemana8.Service.Interface;
using EntregaSemana8.Service.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EntregaSemana8.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ICliente objCliente;

        public ClienteController(ICliente clienteObj)
        {
            objCliente= clienteObj;
        }
        public IActionResult Index()
        {
            return View();
        }


        //LISTAR
        [Route("cliente/listar")]
        public IActionResult Listar()
        {
            return View(objCliente.GetAllClientes());
        }


        //GRABAR
        public IActionResult Grabar(TbCliente cliente)
        {
            objCliente.Add(cliente);
            return RedirectToAction("Listar");
        }


        //EDIT
        [Route("Cliente/Edit/{cod}")]
        public IActionResult Edit(int cod)
        {
            return View(objCliente.GetCliente(cod));
        }

        //DELETE
        [Route("Cliente/Delete/{cod}")]
        public IActionResult Delete(int cod)
        {
            objCliente.Delete(cod);
            return RedirectToAction("Listar");
        }

        public IActionResult EditDetails(TbCliente tbCliente)
        {
            objCliente.Update(tbCliente);
            return RedirectToAction("Listar");
        }

    }
}
