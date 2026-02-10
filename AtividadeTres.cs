using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _09._02
{
    public class AtividadeTres
    {

        public int Numero { get; set; }

        public void Mostrar()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }


        public void Par()
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void Tabuada()
        {
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{Numero} x {i} = {Numero * i}");
                }
            }

        }


        public int Soma { get; set; } = 0;


        public void LerNumeros()
        {
            int numero;

            do
            {
                Console.Write("Digite um número (0 para sair): ");

                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("Valor inválido! Digite um número inteiro: ");
                }

                Soma += numero;

            } while (numero != 0);
        }

        public void MostrarResultado()
        {
            Console.WriteLine($"Soma total: {Soma}");
        }
        public int Real { get; set; }
        public void positivo()
        {
            if (Real > 0)
            {
                Console.WriteLine($"positivo");
            }
            else if (Real < 0)
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