using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_QUARTA_AULA_0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
           //EXERCICIO 

           int A = 20, B = 10, C = 30, R = 0;
           if (A == 20 && B == A) //Não é 
           {
               A = B;
           }
           else if (C == 30 && A <= B)//Não 
           {
               C = A;
           }
           else if (C <= B && A != B) //Não 
           {
               B = A + 10;
           }
           else if (C > B + 20 || A != B + 10) //Não é 
           {
               B = A + 30;
           }
           else if (A == 10 || B > A) //Não é 
           {
               B = C;
           }
           else if (B > A && A > C || A < 10) //Não é 
           {
               C = B + A;
           }
           else if (A == 20 && C > 50 || B == A) // Não é 
           {
               C = A;
           }
           else if (A == 20 || C == 10 && B < 20) // Esse 
           {
               C = 10;
               B = 10;
               A = 10;
           }

           Console.WriteLine("A: " + A);
           Console.WriteLine("B: " + B);
           Console.WriteLine("C: " + C);

           Console.ReadKey();
           
        }
    }
}
