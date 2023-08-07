using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.setNome("gol");
            carro.setModelo("TSI");
            carro.setAno(2022);
            carro.setCor("Preto");
            carro.Preco = 30000;

            //Mostrar dados

            Console.WriteLine("Carro: " + carro.getNome());
            Console.WriteLine("Modelo: " + carro.getModelo());
            Console.WriteLine("Ano: " + carro.getAno());
            Console.WriteLine("Cor: " + carro.getCor());
            Console.WriteLine("Classificação: " + carro.getClassificacao());
            Console.WriteLine("Preço: " + carro.Preco.ToString("N2"));
            Console.ReadKey();

            Carro carro2 = new Carro("Prisma", "Sedan", "Preto", 2010, 25000);
            Console.WriteLine("\nCarro: " + carro2.getNome());
            Console.WriteLine("Modelo: " + carro2.getModelo());
            Console.WriteLine("Ano: " + carro2.getAno());
            Console.WriteLine("Cor: " + carro2.getCor());
            Console.WriteLine("Classificação: " + carro2.getClassificacao());
            Console.WriteLine("Preço: " + carro2.Preco.ToString("N2"));
            Console.ReadKey();

            

            Console.ReadKey();
        }
    }
}
