using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaJogosMVC.Models
{
    public abstract class Personagem
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Nivel { get; set; }

        public Personagem(){}
        public Personagem(string nomeConstrutor, int nivelConstrutor)
        {
            Nome = nomeConstrutor;
            Nivel = nivelConstrutor;
        }

        public abstract double CalcularPoder();
    }
}