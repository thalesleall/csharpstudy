using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//CONDICIONAL
            // Simples
            // Composta
            // Encadeada
            
            int a = 0; 
            Console.WriteLine("Digite um numero: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a < 10)
            {
                a = a + 1;
            }
            else if (a < 2) 
            {
                a = a + 2;
            }

            Console.WriteLine("Valor de A: " + a);
            Console.ReadKey();*/

            //int a = 0;
            //int b = 0;
            //int c = 0;
            //int d = 0;

            //Console.Write("Digite um numero para A: ");
            //a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Digite um numero para B: ");
            //b = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Digite um numero para C: ");
            //c = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Digite um numero para D: ");
            //d = Convert.ToInt32(Console.ReadLine());

            //if (a == b && b == c && c == d)
            //{
            //    Console.WriteLine(" _____");
            //    Console.WriteLine("|     |");
            //    Console.WriteLine("|     |");
            //    Console.WriteLine("|     |");
            //    Console.WriteLine(" -----");

            //    Console.Write("Parabéns isso é um quadrado!");
            //}
            //else
            //{
            //    Console.Write("Isso não é um quadrado :(");
            //}
            //Console.ReadKey();

            //int a = 0;
            //int b = 0;

            //Console.Write("Digite um numero para A: ");
            //a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Digite um numero para B: ");
            //b = Convert.ToInt32(Console.ReadLine());

            //if(a != b)
            //{
            //    if(a > b)
            //    {
            //        Console.Write("O numero maior é o A, que é igual a: " + a);
            //    }
            //    else if(a < b)
            //    {
            //        Console.Write("O numero maior é o A, que é igual a: " + b);
            //    }
            //}
            //else
            //{
            //    Console.Write("Os numeros são iguais!");
            //}
            //Console.ReadKey();

            double a = 0.0;
            double b = 0.0;

            string equacao = "";


            Console.Write("Digite um numero para A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite um numero para B: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("A - para somar os numeros\nS - para subtrair os numeros\nM - para dividir os numeros\nD - para dividir os numeros\nDigite: ");
            equacao = Console.ReadLine();

            if(equacao == "A")
            {
                Console.WriteLine("O resultado da soma de A por B é: " + (a + b));
            }
            else if(equacao == "S")
            {
                Console.WriteLine("O resultado da subtração de A por B é: " + (a - b));
            }
            else if(equacao == "M")
            {
                Console.WriteLine("O resultado da multiplicação de A por B é: " + (a * b));
            }
            else if(equacao == "D") 
            {
                Console.WriteLine("O resultado da divisao de A por B é: " + (a / b));
            }
            else
            {
                Console.WriteLine("Digite uma equação valida");
            }

            Console.ReadKey();

        }
    }
}
