using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Carro
    {
        private string nome;
        private string modelo;
        private int ano;
        private string cor;
        private double preco;

        //metodo construtor

        public Carro()
        {

        }
        public Carro(string nome, string modelo, string cor, int ano, double preco)
        {
            this.nome = nome; this.modelo = modelo; this.cor = cor  ; this.ano = ano; this.preco = preco;
        }

        //metodos set e get 
        public double Preco { get => preco; set => preco = value; }
        public void setNome(string n) { nome = n; }
        public void setModelo(string m) {  modelo = m; }
        public void setCor(string c) {  cor = c; }
        public void setAno(int y) { ano = y; }

        public int getAno() {  return ano; }
        public string getCor() { return cor; }
        public string getModelo() { return modelo; }
        public string getNome() { return nome; }

        //metodos 
        public string getClassificacao()
        {
            string r = "";
            if (ano < 2000)
            {
                r = "Antigo";
            }
            else if (ano < 2015)
            {
                r = "Semi-Novo";
            }
            else
            {
                r = "Novo";
            }
            return r;
        }
    }
}
