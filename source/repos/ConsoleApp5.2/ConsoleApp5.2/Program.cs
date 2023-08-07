using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._2
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            int caso = 0;
            while (caso != 4)
            {
                Console.WriteLine("1 - Para calcular o IMC");
                Console.WriteLine("2 - Realizar a tabuada de um número");
                Console.WriteLine("3 - Realizar as quatro operações básicas da matemática");
                Console.WriteLine("4 - Sair do programa");
                Console.Write("Selecione uma opção: ");
                caso = Convert.ToInt32(Console.ReadLine());

                switch (caso)
                {
                    case 1:

                        string nome = "";
                        int altura = 0;
                        int peso = 0;
                        Console.WriteLine("Digite o Nome: ");
                        nome = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Digite a Altura: ");
                        altura = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o Peso: ");
                        peso = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(IMC(nome, peso, altura));

                        break;
                    case 2:

                        int numero = 0;

                        Console.Write("Digite um numero para calcular a sua tabuada: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(tabuada(numero));

                        break;
                    case 3:
                        int numero2 = 0;
                        int numero22 = 0;
                        Console.Write("Digite o primeiro numero para realizar as 4 operações: ");
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o segundo numero para realizar as 4 operações: ");
                        numero22 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(operacoes(numero2, numero22));
                        break;
                }
            }
        }

        static string IMC(string nome, int altura, int peso)
        {
            int imc = 0;
            string classificacao = "";
            imc = peso / altura * altura;
            if (imc > 40)
            {
                classificacao = "Obesidade grau III";
            }
            else if (imc < 39.9 && imc > 35.0)
            {
                classificacao = "Obesidade grau II";
            }
            else if (imc < 34.9 && imc > 30.0)
            {
                classificacao = "Obesidade grau I";
            }
            else if (imc < 29.9 && imc > 25.0)
            {
                classificacao = "Pré-Obeso";
            }
            else if (imc < 24.9 && imc > 18.5)
            {
                classificacao = "Adequado";
            }
            else if (imc < 18.4 && imc > 17.0)
            {
                classificacao = "Magreza grau I";
            }
            else if (imc < 16.9 && imc > 16.0)
            {
                classificacao = "Magreza grau II";
            }
            else if(imc < 16)
            {
                classificacao = "Magreza grau III";
            }

            return classificacao;
        }
        static string tabuada(int numero)
        {
            int resultado = 0;
            int i = 0;
            string tabuada = "";
            for (i = 1; i != 11; i++)
            {
                resultado = numero * i;

                tabuada = tabuada + numero +" * " + i + " = "+ resultado + "\n";
            }
            
            return tabuada;
        }
        static string operacoes(int numero1, int numero2)
        {
            string ops = "";
            ops = ops + numero1 + " + " + numero2 + " = " + (numero1 + numero2) + 
                "\n" + numero1 + " - " + numero2 + " = " + (numero1 - numero2) +
                "\n" + numero1 + " * " + numero2 + " = " + (numero1 * numero2) + 
                "\n" + numero1 + " / " + numero2 + " = " + (numero1 / numero2);


            return ops;
        }
    }
}
