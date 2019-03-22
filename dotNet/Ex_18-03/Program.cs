// EXERCÍCIO 18-03-19
// GUSTAVO DELGADO (SP1764489) - IFSP 2019

using System;
using System.Text.RegularExpressions;

namespace dotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            // calculaNotas(250.65);
            // calculoEntreDatas("29/02/2016");
            // maiorNumero(1,45);
            // isAnoBissexto();

        }

        // QUESTAO 1
        public static void calculaNotas(double valor) {
            double[] notas = {100, 50, 20, 10, 5, 2, 0.50, 0.25, 0.10, 0.05, 0.01};
            int[] qtdeValores = new int[11];

            if (valor <= 0){
                Console.WriteLine("O número informado não é válido!");
                return;
            }

            for (int i = 0; i < notas.Length; i++)
            {
                while (valor >= notas[i]) {
                    valor = valor - notas[i];
                    qtdeValores[i]++;
                }

                if (qtdeValores[i] != 0){
                    Console.WriteLine("Qtde notas/moedas de " + notas[i] + ": " + qtdeValores[i]);
                }
            }
            
            
        }

        // QUESTAO 2
        public static void calculoEntreDatas(string dataInicial)
        {
            Boolean isBissextoInicial = false;

            Match matchInicial      = Regex.Match(dataInicial, @"[0-3][0-9]/[0-1][0-9]/[0-9][0-9][0-9][0-9]");
            if (matchInicial.Success)
            {
                int diaInicial = Convert.ToInt32(dataInicial.Substring(0,2));
                int mesInicial = Convert.ToInt32(dataInicial.Substring(3,2));
                int anoInicial = Convert.ToInt32(dataInicial.Substring(6,4));

                // verificando se as datas informadas sao validas
                if (anoInicial%4 == 0 & anoInicial%100 != 0) {
                    isBissextoInicial = true;
                } else if (anoInicial%400 == 0){
                    isBissextoInicial = true;
                }

                if (mesInicial == 2 & diaInicial > 28){
                    if (isBissextoInicial == false & diaInicial == 29 | diaInicial > 29){
                        Console.WriteLine("Data inicial inválida!");
                        return;
                    }
                }

                string dataAtual = Convert.ToString(DateTime.Today);
                int diaAtual = Convert.ToInt32(dataAtual.Substring(0,2));
                int mesAtual = Convert.ToInt32(dataAtual.Substring(3,2));
                int anoAtual = Convert.ToInt32(dataAtual.Substring(6,4));


            }
            else
            {
                Console.WriteLine("Data Inválida!");
            }
        }

        // QUESTAO 3
        public static void maiorNumero(double n1, double n2) {
            double maiorNum = n2 > n1 ? n2 : n1;
            Console.WriteLine(maiorNum);
        }

        public static void isAnoBissexto() {
            Console.WriteLine("Digite um ano a ser verificado: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            if (ano % 4 == 0 & ano % 100 != 0) {
                Console.WriteLine("O ano " + ano + " é bissexto.");
            }
            else if (ano % 400 == 0) {
                Console.WriteLine("O ano " + ano + " é bissexto.");
            } else {
                Console.WriteLine("O ano " + ano + " não é bissexto.");
            }
        }
    }
}
