using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[5];
            int i = 0;
            
            for(i = 0; i < 5; i++)
            {
                Console.Write("Digite o numero para a " + (i+1) + "° posição: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(i=0; i < 5;i++)
            {
                Console.Write("O valor da posição " + (i+1) + "° é: " + numeros[i]);
                if (numeros[i] % 2 == 0)
                {
                    Console.Write(" - Esse numero é par!\n");
                }
                else
                {
                    Console.Write(" - Esse numero é impar!\n");
                }
            }
            Console.ReadKey();
        }
    }
}
