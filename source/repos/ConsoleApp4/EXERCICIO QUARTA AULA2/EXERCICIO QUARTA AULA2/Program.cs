using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_QUARTA_AULA2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //EXERCICIO TABUADA
            
            int numero = 0;
            int cont = 0;
            int resultado = 0;

            Console.WriteLine("Digite qual tabuada você deseja: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for(cont = 0; cont <= 10; cont++)
            {        
                resultado = cont * numero;
                Console.WriteLine(numero + "X" + cont + " = " + resultado);
            }
            
            

        }
    }
}
