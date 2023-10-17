using EntregaSemana8.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EntregaSemana8.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuario _usuario;
        public UsuarioController(IUsuario usuario)
        {
            _usuario = usuario;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Validar()
        {
            return View();
        }
    }

}
