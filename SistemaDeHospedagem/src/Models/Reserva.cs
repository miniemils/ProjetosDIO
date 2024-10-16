using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Models
{
    public class Reserva
    {
        
        public Reserva(int diasReservados, Suite suite)
        {
            DiasReservados = diasReservados;
            Suite = suite;
            Hospedes = new List<Pessoa>();
        }

        public int DiasReservados { get; set; }
        public Suite Suite { get; set; }
        public List<Pessoa> Hospedes { get; set; }

        public string CadastrarHospedes(List<Pessoa> listaDeHospedes)
        {
            if(listaDeHospedes.Count <= Suite.Capacidade)
            {
                Hospedes = listaDeHospedes;
                if(listaDeHospedes.Count == 1) {
                    return "Hóspede cadastrado com sucesso.";
                }
                else
                {
                    return $"{listaDeHospedes.Count} hóspedes foram cadastrados com sucesso.";
                }
            }
            else
            {
                throw new ArgumentException("O número de hóspedes cadastrados excede a capacidade máxima do tipo de suíte escolhida.");
            }
        }

        public decimal CalcularValorDiaria()
        {

            if(DiasReservados >= 10)
            {
                return Suite.ValorDiaria * DiasReservados * 0.90m;
            }
            else
            {
                return Suite.ValorDiaria * DiasReservados;
            }
        }

    }
}