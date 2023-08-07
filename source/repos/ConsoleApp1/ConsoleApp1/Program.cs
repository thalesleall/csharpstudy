using System.Numerics;

namespace ConsoleApp1_Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int numero = 0;
             int N = 10;
             string nome = "";
             int idade = 0;

             Console.WriteLine("Hello World!!");
             Console.WriteLine(1 + 1);
             Console.WriteLine("Soma: "  + (1 + 1));  //WRITE: MESMA LINHA; WRITELINE: PULA DE LINHA
             Console.Clear();
             Console.Write("Digite seu nome : ");
             nome = Console.ReadLine();
             Console.Write("Digite sua idade: ");
             idade = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("O nome é igual a: " + nome + ", e a idade é igual a: " + idade);

             Console.ReadKey(); */

            /*int n1 = 0;
            int n2 = 0;

            Console.Write("Digite o primeiro numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Digite o segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O primeiro numero digitado foi: " + n1 );
            Console.WriteLine("O segundo numero digitado foi: " + n2);

            Console.WriteLine("A soma dos dois numeros é igual a: " + (n1 + n2));*/

            Console.Write("Digite seu nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Digite a cidade que mora: ");
            string Cidade = Console.ReadLine();
            Console.Write("Digite o estado em que você mora: ");
            string Estado = Console.ReadLine();
            Console.Write("Digite seu telefone: ");
            string Telefone = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("Estado: " + Estado);
            Console.WriteLine("Telefone: " + Telefone);
        }
    }
}