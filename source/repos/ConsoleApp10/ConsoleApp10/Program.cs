PROGRAMA


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DECIMA_PRIMEIRA_AULA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // (int Numero, string Data, int Quantidade ,double ValorU, 
            // int codigoCliente, string nomeCliente, string CPFCliente, string tipo,
            //         string cargo, int codigoFuncionario, string nomeFuncionario, string CPFFuncionario)

            Pedido pedido = new Pedido(50, "29/12/2003", 5, 5.0, 55, "Pedro", "461802098-98", "Fiel", "Vendedor", 10, "Pedrinho", "145583938-81");


            Console.WriteLine("Pedido: " + pedido.numero);
            Console.WriteLine("Data: " + pedido.data);
            Console.WriteLine("Quantidade: " + pedido.quantidade);
            Console.WriteLine("Valor Unitario: " + pedido.valorU);
            Console.WriteLine("Código CLIENTE: " + pedido.codigoCliente);
            Console.WriteLine("Nome do CLIENTE: " + pedido.nomeCliente);
            Console.WriteLine("CPF do CLIENTE: " + pedido.CPFCliente);
            Console.WriteLine("Tipo de CLIENTE: " + pedido.tipo);
            Console.WriteLine("Cargo do FUNCIONARIO: " + pedido.Cargo);
            Console.WriteLine("Código do FUNCIONARIO: " + pedido.codigoFuncionario);
            Console.WriteLine("Nome do FUNCIONARIO: " + pedido.nomeFuncionario);
            Console.WriteLine("CPF do FUNCIONARIO: " + pedido.CPFFuncionario);


            Console.ReadKey();






        } // FIM DA CLASSE
    }
}