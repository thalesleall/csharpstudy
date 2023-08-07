using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8._1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int nConta = 0;
            string nomeCliente = "";
            string cpf = "";
            int saldo = 0;

            Console.Write("Digite o numero da sua conta: ");
            nConta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o seu nome: ");
            nomeCliente = Convert.ToString(Console.ReadLine());

            Console.Write("Digite o seu cpf: ");
            cpf = Convert.ToString(Console.ReadLine());

            Console.Write("Digite o seu saldo: ");
            saldo = Convert.ToInt32(Console.ReadLine());

            ContaBancaria cb = new ContaBancaria(nConta, nomeCliente, cpf, saldo);
            Console.WriteLine("Numero da conta: " + cb.getnConta());
            Console.WriteLine("Nome do cliente: " + cb.getNomeCliente());
            Console.WriteLine("CPF: " + cb.getCpf());
            Console.WriteLine("Saldo: " + cb.getSaldo() + "\n");

            Console.WriteLine("-----OPERAÇÕES-----");
            Console.WriteLine("1 - DEPOSITO");
            Console.WriteLine("2 - SAQUE");
            Console.WriteLine("3 - CONFERIR SALDO");
            Console.Write("Digite: ");

            string operacao = "";
            operacao = Console.ReadLine();
            if(operacao == "1")
            {
                int valorDeposito = 0;
                Console.Write("Digite o valor do deposito: ");
                valorDeposito = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Deposito de: " +  valorDeposito + " realizado com sucesso!");
                Console.WriteLine("O seu novo saldo é de: " + cb.deposito(valorDeposito));
            }
            else if(operacao == "2")
            {
                int valorSaque = 0;
                Console.Write("Digite o valor do saque: ");
                valorSaque = Convert.ToInt32(Console.ReadLine());
                cb.saque(valorSaque);
            }
            else if(operacao == "3")
            {
                Console.WriteLine("Seu saldo é igual a: " + cb.getSaldo());
            }
            Console.ReadKey();
        }
    }
}
