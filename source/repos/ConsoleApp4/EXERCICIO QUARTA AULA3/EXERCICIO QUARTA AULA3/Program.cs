using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_QUARTA_AULA3
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
