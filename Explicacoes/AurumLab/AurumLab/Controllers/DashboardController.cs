using AurumLab.Data;
using AurumLab.Models;
using Humanizer;
using Microsoft.AspNetCore.Mvc;

namespace AurumLab.Controllers
{
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;
        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult DashBoard()
        {
            if (HttpContext.Session.GetInt32("UsuarioID") == null)
                return RedirectToAction("Index", "Login");

            var usuarioId = HttpContext.Session.GetInt32("UsuarioId");
            var usuario = _context.Usuarios.FirstOrDefault(u => u.IdUsuario == usuarioId);

            //TODO Tipos Dispositivos = JOIN + AGRUPAMENTO
            //! Consultar a tabela dispositivos atravez da ViewModel
            var DispositivosPorTipo = _context.Dispositivos
            .Join
            (
                    _context.TipoDispositivos, //* Tipos dispositivos  (On)
                    dispositivo => dispositivo.IdTipoDispositivo, //* dispositivo.IdTipoDispositivo
                    TipoDispositivo => TipoDispositivo.IdTipoDispositivo, //* = TipoDispositivo.IdTipoDispositivo
                    (dispositivo, TipoDispositivo) => new {dispositivo, TipoDispositivo.Nome}
                    //* Cada par encontrado - um dispositivo e seu tipo, correspondem a um objeto...
                    
            )

        }
    }
}