using AtividadeSolo.Models;
using AtividadeSolo.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace AtividadeSolo.Controllers
{
    public class UsuarioController : Controller
    {
        private const string ControllerName = "Produto";
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }


        public IActionResult Login()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            
            var usuario = _usuarioRepositorio.ObterUsuario(email);
            if (usuario != null && usuario.Senha == senha)
            {
                return RedirectToAction("CadastrarProduto", "Produto");
            }
            
            ModelState.AddModelError("", "Email ou senha inválidos.");
            return RedirectToAction("index","Home");
        }
    }
}

