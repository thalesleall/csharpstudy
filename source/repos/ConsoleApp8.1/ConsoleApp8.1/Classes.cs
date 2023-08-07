using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8._1
{
    public class ContaBancaria
    {
        private int nConta;
        private string nomeCliente;
        private string cpf;
        private int saldo;
        

        public ContaBancaria(int nConta, string nomeCliente, string cpf, int saldo)
        {
            this.nConta = nConta;
            this.nomeCliente = nomeCliente;
            this.cpf = cpf;
            this.saldo = saldo;
        }

        public int deposito(int valorDeposito) 
        {
            saldo = saldo + valorDeposito;
            return this.saldo;
        }
        public void saque(int valorSaque)
        {
            if(saldo - valorSaque < 0)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            else if(saldo - valorSaque > 0)
            {
                saldo = saldo - valorSaque;
                Console.WriteLine("Saque realizado com sucesso!");
                Console.WriteLine("O seu novo saldo é igual a:" + saldo);
            }
            
        }
        public int getnConta() { return nConta; }
        public string getNomeCliente() { return nomeCliente; }
        public string getCpf() { return cpf; }
        public int getSaldo() { return saldo; }


    }
}
