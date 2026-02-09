using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _09._02
{
    public class AtividadeDois
    {
         public double ParImpar { get; set; }
        public double NumeroUm { get; set; }
        public double NumeroDois { get; set; }
        public double Nota { get; set; }
        public double Idade { get; set; }
        public double Real { get; set; }

        public void Impar()
        {
            if (ParImpar % 2 == 0)
            {
                  Console.WriteLine($"o número é par");
            }
            else
            {
                   Console.WriteLine($"o número é impar");
            }
        }
        public void Maior()
        {
            if (NumeroUm > NumeroDois)
            {
                  Console.WriteLine($"o número {NumeroDois} é maior");
            }
            else if (NumeroUm < NumeroDois)
            {
                  Console.WriteLine($"o número {NumeroUm} é maior");
            }
            else
            {
                   Console.WriteLine($"SÃO IGUAIS");
            }
        }
        public void Situacao()
        {
            if (Nota > 7)
            {
                  Console.WriteLine($"aprovado");
            }
            else if (Nota < 3 )
            {
                  Console.WriteLine($"reprovado");
            }
            else
            {
                   Console.WriteLine($"recuperação");
            }
        }
        public void Velha()
        {
            if (Idade >= 55)
            {
                  Console.WriteLine($"idoso");
            }
            else if (Idade >= 18 )
            {
                  Console.WriteLine($"adulto");
            }
            else
            {
                   Console.WriteLine($"criança");
            }
        }

         public void positivo()
        {
            if (Real > 0)
            {
                  Console.WriteLine($"positivo");
            }
            else if (Real < 0 )
            {
                  Console.WriteLine($"negativo");
            }
            else
            {
                   Console.WriteLine($"zero");
            }
        }














    }
}