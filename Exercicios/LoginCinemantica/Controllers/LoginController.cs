using Microsoft.AspNetCore.Mvc;
using LoginCinemantica.Data;
using SistemaLogin.Services;

namespace LoginCinemantica.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(string email, string senha)
        {
            if(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                ViewBag.Error = "Todos os campos precisam ser preenchidos";
                return View("Index");
            }

            byte[] SenhaDigitadaHash = HashService.GerarHashBytes(senha);
            var user = _context.Usuarios.FirstOrDefault(u => u.Email == email);
            if(user == null)
            {
                ViewBag.Error = "Dados invalidos";
                return View("Index");
            }
            
            else if(!user.Senha.SequenceEqual(SenhaDigitadaHash))
            {
                ViewBag.Error = "Dados invalidos";
                return View("Index");
            }

            //* Se login estiver ok
            HttpContext.Session.SetString("UsuarioNome", user.Nome);
            HttpContext.Session.SetInt32("UsuarioId", user.IdUsuario);

            return RedirectToAction("Index", "Home");
        }
        public IActionResult Sair()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}