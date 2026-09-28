using Microsoft.AspNetCore.Mvc;
using SistemaLogin.Data;
using SistemaLogin.Services;

namespace SistemaLogin.Controllers
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
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                ViewBag.Erro = "Todos os campos sao obrigatorios";
                return View("Index");
            }

            // hash da senha digitada
            byte[] senhaDigitadaHash = HashService.GerarHashBytes(senha);
            var user = _context.Usuarios.FirstOrDefault(u => u.Email == email);
            if (user == null)
            {
                ViewBag.Erro = "Dados invalidos";
                return View("Index");
            }

            else if (!user.SenhaHash.SequenceEqual(senhaDigitadaHash))
            {
                ViewBag.Error = "Dados invalidos";
                return View("Index");
            }

            //login estiver ok => ele salva na sessar
            HttpContext.Session.SetString("UsuarioNome", user.NomeCompleto);
            HttpContext.Session.SetInt32("UsusarioId", user.Id);

            return RedirectToAction("Index", "Home");
        }
        public IActionResult Sair()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}