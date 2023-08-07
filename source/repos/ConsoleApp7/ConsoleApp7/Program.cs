using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linhas = 3;
            int colunas = 2;
            string[,] dados = new string[linhas, colunas];


            int contarLinhas = 0;
            int contarColunas = 0; 

            for(contarLinhas = 0; contarLinhas < linhas; contarLinhas++)
            {
                Console.Write("Digite o nome da pessoa: ");
                dados[contarLinhas, 0] = Console.ReadLine();

                Console.Write("Digite o telefone da pessoa: ");
                dados[contarLinhas, 1] = Console.ReadLine();
            }

            for(contarLinhas = 0; contarLinhas < linhas; contarLinhas++) 
            {
                for(contarColunas = 0; contarColunas < colunas; contarColunas++)
                {
                    Console.Write(dados[contarLinhas, contarColunas] + " - ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }   
    }
}
