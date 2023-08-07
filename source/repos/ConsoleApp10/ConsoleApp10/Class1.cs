using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DECIMA_PRIMEIRA_AULA
{
    public class pessoa  // COMEÇO DA CLASSE -----------------------------
    {
        int codigo;
        string nome;
        string cPF;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string CPF { get => cPF; set => cPF = value; }

        public pessoa() { }

        public pessoa(int codigo, string nome, string CPF) // MÉTODO CONSTRUTOR 
        {
            this.codigo = codigo;
            this.nome = nome;
            this.CPF = CPF;
        }


    }// ----------------------------- FIM DA CLASSE  -----------------------------

    public class Cliente : pessoa // COMEÇO DA CLASSE -----------------------------
    {
        string tipo;

        public string Tipo { get => tipo; set => tipo = value; }

        public Cliente() { }

        public Cliente(int codigo, string nome, string CPF, string tipo) : base(codigo, nome, CPF)  // MÉTODO CONSTRUTOR 

        {
            this.tipo = tipo;
        }
    }// ----------------------------- FIM DA CLASSE  -----------------------------


    public class Funcionario : pessoa // COMEÇO DA CLASSE -----------------------------
    {
        string cargo;

        public string Cargo { get => cargo; set => cargo = value; }

        public Funcionario() { }

        public Funcionario(int codigo, string nome, string CPF, string cargo) : base(codigo, nome, CPF)// MÉTODO CONSTRUTOR 
        {
            this.cargo = cargo;
        }


    }// ----------------------------- FIM DA CLASSE  -----------------------------

    public class Produto // COMEÇO DA CLASSE -----------------------------
    {
        int codigo;
        string nome;

        public string Nome { get => nome; set => nome = value; }
        public int Codigo { get => codigo; set => codigo = value; }

        public Produto() { }

        public Produto(int codigo, string nome) // MÉTODO CONSTRUTOR
        {
            this.codigo = codigo;
            this.nome = nome;
        }
    }// ----------------------------- FIM DA CLASSE  -----------------------------

    public class Pedido // COMEÇO DA CLASSE -----------------------------
    {
        int Numero;
        string Data;

        Cliente cliente;
        Funcionario funcionario;
        Produto produto;

        int Quantidade;
        double ValorU;


        public int numero { get => Numero; set => Numero = value; }
        public string data { get => Data; set => Data = value; }
        public double valorU { get => ValorU; set => ValorU = value; }
        public int quantidade { get => Quantidade; set => Quantidade = value; }
        public string tipo { get => cliente.Tipo; set => cliente.Tipo = value; }
        public string Cargo { get => funcionario.Cargo; set => funcionario.Cargo = value; }
        public int codigoFuncionario { get => produto.Codigo; set => produto.Codigo = value; }
        public string nomeFuncionario { get => funcionario.Nome; set => funcionario.Nome = value; }
        public string CPFFuncionario { get => funcionario.CPF; set => funcionario.CPF = value; }

        public int codigoCliente { get => produto.Codigo; set => produto.Codigo = value; }
        public string nomeCliente { get => cliente.Nome; set => cliente.Nome = value; }

        public string CPFCliente { get => cliente.CPF; set => cliente.CPF = value; }


        public Pedido(int Numero, string Data, int Quantidade, double ValorU,
                      int codigoCliente, string nomeCliente, string CPFCliente, string tipo,
                      string cargo, int codigoFuncionario, string nomeFuncionario, string CPFFuncionario) // MÉTODO CONSTRUTOR
        {
            this.Numero = Numero;
            this.Data = Data;
            this.Quantidade = Quantidade;
            this.valorU = ValorU;
            this.cliente = new Cliente(codigoCliente, nomeCliente, CPFCliente, tipo);
            this.funcionario = new Funcionario(codigoFuncionario, nomeFuncionario, CPFFuncionario, cargo);
            this.produto = new Produto(codigoCliente, nomeCliente);

        }


    }// ----------------------------- FIM DA CLASSE  -----------------------------
}