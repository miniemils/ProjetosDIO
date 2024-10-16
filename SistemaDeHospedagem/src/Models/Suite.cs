using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Models
{
    public class Suite
    {
        
        public Suite(string tipoSuite, int capacidadeSuite, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidadeSuite;
            ValorDiaria = valorDiaria;
        }

        private string _tipoSuite = string.Empty;

        public string TipoSuite
        {
            get => _tipoSuite;
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O tipo da suíte não pode estar vazio.");
                }
                _tipoSuite = value;
                }
        }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

    }
}