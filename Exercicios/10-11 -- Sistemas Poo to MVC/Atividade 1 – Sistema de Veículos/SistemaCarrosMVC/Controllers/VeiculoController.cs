using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaCarrosMVC.Data;
using SistemaCarrosMVC.Models;

namespace SistemaCarrosMVC.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly AppDbContext _context;

        public VeiculoController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }

        //Listar
        public async Task<IActionResult> Index()
        {
            var lista = await _context.TabelaVeiculo.ToListAsync();
            return View(lista);
        }

        [HttpGet]
        public IActionResult criar() => View();

        [HttpPost]
        public async Task<IActionResult> Criar(string modeloConstrutor, int anoConstrutor, string tipoConstrutor)
        {
            Veiculo? novoVeiculo = null;

            if (tipoConstrutor == "Carro")
            {
                novoVeiculo = new Carro(modeloConstrutor, anoConstrutor);
            }
            else if (tipoConstrutor == "Moto")
            {
                novoVeiculo = new Moto(modeloConstrutor, anoConstrutor);
            }
            else
            {
                return BadRequest("Tipo de Veiciulo invalido");
            }

            _context.TabelaVeiculo.Add(novoVeiculo);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // Excluir
        public async Task<IActionResult> Deletar(int id)
        {
            var Veiculo = await _context.TabelaVeiculo.FindAsync(id);

            if (Veiculo == null)
                return NotFound();

            _context.TabelaVeiculo.Remove(Veiculo);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
