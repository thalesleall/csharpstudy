using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6._2
{

    internal class Program
    {
        static int[] numeros = new int[5];
        static int posicao = 0;
        static int valor = 0;
        static void Main(string[] args)
        {


            do
            {
                Console.Write("Digite a posição que deseja inserir o valor: ");
                posicao = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o valor: ");
                valor = Convert.ToInt32(Console.ReadLine());

                if (posicao >= 5 || posicao < 0)
                {
                    Console.Write("Posição invalida\n");
                }

            } while (posicao >= 5 || posicao < 0);
                Inserir(posicao, valor);

            Console.Write("\nQUER SABER O VALOR DE QUAL POSIÇÃO? ");
            posicao = Convert.ToInt32(Console.ReadLine());
            Indicar(posicao);
            Console.ReadKey();
        }

        static int Inserir(int posicao, int valor)
        {
                
            numeros[posicao] = valor;      
                return numeros[posicao];
        }
        static void Indicar(int posicao)
        {
            if (posicao >= 5 || posicao < 0)
            {
                Console.WriteLine("Posição invalida!");
            }
            else
            {
                Console.WriteLine("O numero que se encontra nessa posição é igual a: " + numeros[posicao]);
            }
        }
        
    }
}
