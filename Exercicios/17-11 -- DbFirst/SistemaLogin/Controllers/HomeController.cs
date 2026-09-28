using Microsoft.AspNetCore.Mvc;

namespace SistemaLogin.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        if (HttpContext.Session.GetString("UsuarioNome") == null)
        {
            return RedirectToAction("Index", "Login");
        }

        // Nesse caso a view bag carrega as informacoes para a view 
        ViewBag.Usuario = HttpContext.Session.GetString("UsuarioNome");
        return View();
    }
}
