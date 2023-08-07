using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static int n1 = 0;
        static int n2 = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("SALVE" + VerificaNumero(n1, n2));
            Console.ReadKey();
        }

        static string VerificaNumero(int n1, int n2)
        {
            string resultado = "";
            if(n1 > n2)
            {
                resultado = ("O numero maior é: " + n1);
            }
            else if(n1 < n2)
            {
                resultado = ("O numero maior é: " + n2);
            }
            else if(n1 == n2)
            {
                resultado = ("Os numeros são iguais");
            }
            return resultado;
        }
    }
}
