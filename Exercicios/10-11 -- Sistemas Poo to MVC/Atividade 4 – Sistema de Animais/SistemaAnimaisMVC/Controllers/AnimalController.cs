using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SistemaAnimaisMVC.Data;
using SistemaAnimaisMVC.Models;

namespace SistemaAnimaisMVC.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AppDbContext _context;

        public AnimalController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _context.TabelaAnimal.ToListAsync();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Criar() => View();

        [HttpPost]
        public async Task<IActionResult> Criar(string nomeConstrutor, string tipoConstrutor)
        {
            Animal? novoAnimal = null;

            if (tipoConstrutor == "Elefante")
            {
                novoAnimal = new Elefante(nomeConstrutor);
            }

            else if (tipoConstrutor == "Leao")
            {
                novoAnimal = new Leao(nomeConstrutor);
            }

            else
            {
                return BadRequest("Tipo de animal invalido");
            }

            _context.TabelaAnimal.Add(novoAnimal);
            _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Deletar(int Id)
        {
            var Animal = await _context.TabelaAnimal.FindAsync(Id);
            if (Animal == null)
                return NotFound();

            _context.TabelaAnimal.Remove(Animal);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}