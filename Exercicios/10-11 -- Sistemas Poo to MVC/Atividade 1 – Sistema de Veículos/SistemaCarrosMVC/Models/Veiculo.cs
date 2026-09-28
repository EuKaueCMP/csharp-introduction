using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCarrosMVC.Models
{
    public abstract class Veiculo
    {
        [Key]
        public int id { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public Veiculo(){}
        public Veiculo(string modeloConstrutor, int anoConstrutor)
        {
            Modelo = modeloConstrutor;
            Ano = anoConstrutor;
        }

        public abstract double CalcularRevisao();
    }
}