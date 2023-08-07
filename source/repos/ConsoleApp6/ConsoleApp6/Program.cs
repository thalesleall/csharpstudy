using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[5];
            numeros[0] = 20;
            numeros[1] = 30;
            numeros[2] = 40;
            numeros[3] = 50;
            numeros[4] = 60;
            Console.WriteLine("Escrevendo os valores do vetor");
            int cont = 0;
            Console.WriteLine("Tamanho do vetor: " + numeros.Length);
            for(cont = 0; cont < numeros.Length; cont++)
            {
                Console.WriteLine("Indice: " + cont + " tem valor: " + numeros[cont]);
            }
            Console.ReadKey();
        }
    }
}
