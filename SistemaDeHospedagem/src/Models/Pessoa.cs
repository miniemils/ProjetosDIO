using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Models
{
    public class Pessoa
    {
        
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome = string.Empty;
        private string _sobrenome = string.Empty;

        public string Nome
        {
            get => _nome;
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O nome não pode estar vazio.");
                }
                _nome = value;
                }
        }
        public string Sobrenome
        {
            get => _sobrenome;
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O sobrenome não pode estar vazio.");
                }
                _sobrenome = value;
                }
        }

    }
}