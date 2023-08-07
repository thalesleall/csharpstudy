
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[10, 2];
            
            int numero = 0;
            int l  = 0;
            int c = 0;
            string table = "";

            for (l = 0; l < 10; l++)
            {
                for (c = 0; c < 2; c++)
                {
                    Console.Write("Digite 20 numeros: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    if (numero % 2 == 0)
                    {
                        numeros[l, 0] = numero;
                    }
                    else if (numero % 2 != 0)
                    {
                        numeros[l, 1] = numero;
                    }
                }
            }

            for (l = 0; l < 10; l++)
            {
                for (c = 0; c < 2; c++)
                {
                    Console.Write(" | " + numeros[l, c] + " | ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
