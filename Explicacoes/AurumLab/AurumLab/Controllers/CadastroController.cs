using AurumLab.Data;
using AurumLab.Models;
using AurumLab.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AurumLab.Controllers
{
    public class CadastroController : Controller
    {
        private readonly AppDbContext _context;
        public CadastroController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(string Nome, string Email, string Senha, string Confirmar)
        {
            if (string.IsNullOrWhiteSpace(Nome) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Senha) || string.IsNullOrWhiteSpace(Confirmar))
            {
                ViewBag.Error("Preencha todos os campos");
                return View("Index");
            }

            if(Senha != Confirmar)
            {
            ViewBag.Error("As senhas não coincidem");
                return View("Index");
            }

            if(_context.Usuarios.Any(u => u.Email == Email))
            {
                ViewBag.Error("Dados ja cadastrados");
                return View("Index");
            }

            byte[] senhaHash = HashService.GerarHashBytes(Senha);
            
            Usuario usuario = new Usuario()
            {
                NomeCompleto = Nome,
                Email = Email,
                Senha = senhaHash,
                Foto = null,
                RegraId = 1
            };
            
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return RedirectToAction("Index", "Login");
        }
    }
}