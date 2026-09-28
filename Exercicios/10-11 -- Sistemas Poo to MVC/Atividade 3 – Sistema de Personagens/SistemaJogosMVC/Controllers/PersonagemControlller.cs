using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SistemaJogosMVC.Data;
using SistemaJogosMVC.Models;

namespace SistemaJogosMVC.Controllers
{
    public class PersonagemController : Controller
    {
        private readonly AppDbContext _context;

        public PersonagemController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }

        //listar 
        public async Task<IActionResult> Index()
        {
            var lista = await _context.TabelaJogos.ToListAsync();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Criar() => View();

        [HttpPost]
        public async Task<IActionResult> Criar(string nomeConstrutor, int nivelConstrutor, string tipoConstrutor)
        {
            Personagem? novoPersonagem = null;

            if (tipoConstrutor == "Guerreiro")
            {
                novoPersonagem = new Guerreiro(nomeConstrutor, nivelConstrutor);
            }

            else if (tipoConstrutor == "Mago")
            {
                novoPersonagem = new Mago(nomeConstrutor, nivelConstrutor);
            }

            else
            {
                return BadRequest("Tipo de personagem é invalido");
            }

            _context.TabelaJogos.Add(novoPersonagem);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Deletar(int id)
        {
            var Personagem = await _context.TabelaJogos.FindAsync(id);

            if (Personagem == null) return NotFound();

            _context.TabelaJogos.Remove(Personagem);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}