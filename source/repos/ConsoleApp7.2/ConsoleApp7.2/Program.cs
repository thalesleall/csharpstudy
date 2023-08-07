using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._2
{
    internal class Program
    {
        static int linhas = 3;
        static int colunas = 6;
        static int[,] dados = new int[linhas, colunas];
        static int i = 0;
        static string materia = "";
        static int intMencao = 0;
        static int acm = 0;
       
        static void Main(string[] args)
        {

            
            for (colunas = 0; colunas < 4; colunas++)
            {
                for (linhas = 0; linhas < 3; linhas++)
                {
                    if (i == 0)
                    {
                        materia = "Português";
                    }
                    else if (i == 1)
                    {
                        materia = "Matematica";
                    }
                    else if (i == 2)
                    {
                        materia = "Geografia";
                    }

                    Console.Write("Digite o sua nota de " + materia + " no " + (acm + 1) + "° bimestre" + ": ");
                    dados[linhas, colunas] = Convert.ToInt32(Console.ReadLine());
                    i++;
                }
                acm++;
                i = 0;
            }
            Media();
            Mencao();
            string tabela = "Materia  |  B1  |  B2  |  B3  |  B4  |  Média  |  Menção  |";

            int acmMateria = 0;
            string materia2 = "";

            
            for (linhas = 0; linhas < 3; linhas++)
            {
                if (acmMateria == 0)
                {
                    materia2 = "Português";
                }
                else if (acmMateria == 1)
                {
                    materia2 = "Matematica";
                }
                else if (acmMateria == 2)
                {
                    materia2 = "Geografia";
                }
                tabela = tabela + "\n" + materia2;
                
                for  (colunas = 0; colunas < 6; colunas++)
                {
                    
                    tabela = tabela  + "  |  " + dados[linhas, colunas];

                }
                acmMateria++;
            }
            Console.Write(tabela);
            Console.ReadKey ();

        }

        static void Media()
        {
            int acm = 0;

            for (linhas = 0; linhas < 3; linhas++)
            {
                acm = 0;
                for (colunas = 0; colunas < 4; colunas++)
                {
                    acm = acm + dados[linhas, colunas];
                }
                dados[linhas, colunas] = acm / 4;
            }
        }

        static void Mencao()
        {
            
            for(linhas = 0; linhas < 3; linhas++)
            {
                colunas = 5;
                if (dados[linhas, 4] < 6) 
                {
                    intMencao = 1;//Reprovado
                    dados[linhas, colunas] = intMencao;
                }
                else if (dados[linhas, 4] >=6 && dados[linhas, 4] <= 8)
                {
                    intMencao = 2;//Bom
                    dados[linhas, colunas] = intMencao;
                }
                else if (dados[linhas, 4] > 8)
                {
                    intMencao = 3;//Otimo
                    dados[linhas, colunas] = intMencao;
                }
            }
        }

    } 
}
