using Microsoft.AspNetCore.Mvc;
using TesteDevCSharp.Models;
using TesteDevCSharp.Services;

namespace TesteDevCSharp.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Usuario usuario)
        {
            _usuarioService.CriarUsuario(usuario);

            return RedirectToAction("Criar");
        }
    }
}