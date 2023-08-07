using System;
using System.IO;
namespace ConsoleApp_1_AULA12_Arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cria um StreamWriter, veja: Esse é para escrever arquivos
            StreamWriter sw;

            //Define a string com o caminho do arquivo
            string ARQUIVO = "C:\\Users\\thale\\OneDrive\\Área de Trabalho\\textoo.txt";

            //A propriedade CreateText usamos para criar o arquivo,
            // Podemos também inserir dados no arquivo, no entanto
            // O conteúdo anterior é perdido
            sw = File.CreateText(ARQUIVO);
            sw.WriteLine("Hello world!");
            sw.WriteLine();
            sw.WriteLine("Aula de c#, tratando de arquivos de texto");

            sw.Close(); //Não se esqueça é importante sempre fechar o arquivo
                        // A propriedade AppendText, podemos abrir o arquivo para adição de
                        // Novas linhas no seu final, o conteúdo original é preservado

            sw = File.AppendText(ARQUIVO);

            //Escreve uma linha no arquivo
            sw.WriteLine("Introdução ao c#");
            sw.WriteLine();
            sw.WriteLine("Linguagem de programação orientada a objetos");
            sw.Close(); //Como ja informado, sempre feche o arquivo
                        //Ler um arquivo de texto
                        // Para ler o arquivo de texto, temos que usar outro Stream, no caso de
                        // leitura usamos o StreamReader

            StreamReader sr; //Declara o stream
                             //Abre o arquivo para leitura
            sr = File.OpenText(ARQUIVO);
            //Define a variavel string para receber o conteúdo
            //No comando abaixo ira ler apenas a primeira linha do arquivo
            string linha = sr.ReadLine();
            Console.WriteLine(linha);
            //Ler o conteúdo do arquivo linha a linha
            int contaLinha = 1; //Apenas uma variável para colocar o numero da linha
                                //Aqui: enquanto não chegar o final do arquivo, continua lendo
            while (sr.EndOfStream == false)
            {
                linha = sr.ReadLine();
                Console.WriteLine("Linha: " + contaLinha + " - " + linha);
                contaLinha++;
            }
            sr.Close(); //Não se esqueça, feche o arquivo aberto
            Console.ReadKey();
        }
    }
}