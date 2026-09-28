using Microsoft.AspNetCore.Mvc;
using AurumLab.Data;
using Microsoft.Identity.Client;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using AurumLab.Services;
using NuGet.DependencyResolver;
using AurumLab.Models;

namespace AurumLab.Controllers;
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
            ViewBag.Error("Preencha todos os campos");
            return View("Index");
        }

        byte[] senhaDigHash = HashService.GerarHashBytes(senha);

        var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == email);

        if(usuario == null)
        {
            ViewBag.Error("Dados incorretos");
            return View("Index");
        }

        else if(!usuario.Senha.SequenceEqual(senhaDigHash))
        {
            ViewBag.Error("Dados incorretos");
            return View("Index");
        }

        HttpContext.Session.SetString("UsuarioNome", usuario.NomeCompleto);
        HttpContext.Session.SetInt32("UsuarioId", usuario.IdUsuario);
        return View("Dashboard", "Dashboard"); //* View recarrega a pagina toda
    }

    public IActionResult Sair()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index"); //* Redirect to action Apenas redireciona...
    }
}