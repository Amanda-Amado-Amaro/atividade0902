using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _09._02
{
    public class Atividadeum
    {
        public string Nome { get; set; }
        public double Idade { get; set; }
        public double NumeroUm { get; set; }
        public double NumeroDois { get; set; }
        public double Dobro { get; set; }

        public double DezAnos()
        {
            return Idade + 10;

        }
        public double Soma()
        {
            return NumeroUm + NumeroDois;

        }
        public double Subtracao()
        {
            return NumeroUm - NumeroDois;

        }
        public double Multiplicacao ()
        {
            return NumeroUm * NumeroDois;

        }
        public double Divisao ()
        {
            return NumeroUm / NumeroDois;

        }
        public double Duplo ()
        {
            return  Dobro*2 ;

        }
                public double Triplo ()
        {
            return Dobro*3 ;

        }


        public void Apresentar()
        {
            Console.WriteLine($"Bem vindo {Nome}");
            Console.WriteLine($"Sua idade daqui 10 anos será {DezAnos()}");
            Console.WriteLine($"As quatro operações com os numeros dados {NumeroUm} e {NumeroDois} é: soma {Soma()}, Subtrção {Subtracao()}, Multiplicação {Multiplicacao()}, Divisão {Divisao()}");
            Console.WriteLine($"o dobro e o triplo do número escolhido {Dobro} é: dobro {Duplo()}, triplo {Triplo()}");
        }
    }
}