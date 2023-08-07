using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUARTA_AULA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //FOR 
            //Comando (inicio;condição;incremento){
            // bloco de código a ser executado}

            //--------------------------------------------------------------------
            //FOR
            /*
            Console.WriteLine("Estrutura FOR");

            int cont = 0;

            for (cont = 1;cont <= 10;cont++)
            {
                Console.BackgroundColor = ConsoleColor.White; // MUDA FUNDO
                Console.ForegroundColor = ConsoleColor.Red;  // MUDA LETRA
                Console.WriteLine(cont);
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            */
            //--------------------------------------------------------------------



            //--------------------------------------------------------------------
            //WHILE
            /*
             
            Console.WriteLine("Estrutura WHILE");

            cont = 0;
            while(cont < 10)
            {
                Console.WriteLine(cont);
                cont++;
            }
            */
            //--------------------------------------------------------------------



            //--------------------------------------------------------------------
            /*
            // WHILE COM STRING
                
            string continuar = "s";
            while(continuar == "s")
            {
                Console.WriteLine("Digite S para continuar");
                continuar = Console.ReadLine();
            }
            */
            //--------------------------------------------------------------------


            //EXERCICIO 1 ATÉ 100

            int num = 0;

            while (num <= 100)
            {
                          
                if (num % 2 == 0)
                {                 
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    
                }

                else
                {
                    
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    

                }
                Console.Write(" " + num + " ");
                num++;

            }







          

        }
    }
}
