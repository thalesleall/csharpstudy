using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                E &&
                OU ||
             */

            //int a = 10;
            //int b = 2;
            //int c = 10;
            //if(a == b || a > b || c != a) 
            //{
            //    Console.WriteLine("Verdadeiro");
            //}
            //else
            //{
            //    Console.WriteLine("Falso");
            //}
            //Console.ReadKey();

            string nome = "";
            double salario = 0;
            int dependentes = 0;

            double novoSalario = 0;
            int bonus = 0;
            double descINSS = 0;
            double descIR = 0;
            string porcentagem = "";
            string IR = "";

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o seu salario: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o numero de dependentes: ");
            dependentes = Convert.ToInt32(Console.ReadLine());

            if(salario <= 1500)
            {
                descINSS = salario * 0.1;
                porcentagem = "10%";
                novoSalario = (salario - descINSS);
                bonus = dependentes * 100;
                IR = "Sem desconto IR";
                novoSalario += bonus;
                
            }
            else if (salario <= 2000)
            {
                descINSS = salario * 0.12;
                IR = "Sem desconto IR";
                porcentagem = "12%";
                novoSalario = (salario - descINSS);
                bonus = dependentes * 50;
                novoSalario += bonus;
            }
            else if (salario <= 3500)
            {
                descINSS = salario * 0.15;
                IR = "15%";
                descIR = salario * 0.15;
                porcentagem = "15%";
                novoSalario = (salario - descINSS);
                novoSalario -= (salario - descIR);
            }
            else if (salario <= 5000)
            {
                descINSS = salario * 0.15;
                descIR = salario * 0.20;
                IR = "20%";
                porcentagem = "15%";
                novoSalario = (salario - descINSS);
                novoSalario -= (salario - descIR);
            }
            else if (salario > 5000)
            {
                descINSS = 850;
                descIR = salario * 0.25;
                IR = "25%";
                porcentagem = "Desconto fixo de 850 reais";
                novoSalario = (salario - descINSS);
                novoSalario -= (salario - descIR);
            }

            Console.WriteLine("O seu novo salário é igual a: " + novoSalario + "\nO bonus aplicado foi igual a: " + bonus + "\nO desconto do inss foi igual a: " + descINSS + "\nA porcentagem do desconto do INSS é igual a: " + porcentagem + "\nO desconto do IR é igual a: " + descIR + "\nA porcentagem do desconto do IR é igual a: " + IR);
            Console.ReadKey();
        }
    }
}
