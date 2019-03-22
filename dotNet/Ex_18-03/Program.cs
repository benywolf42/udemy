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
            calculaNotas(250.65);
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
        public static void calculoEntreDatas(string data)
        {
            Match match = Regex.Match(data, @"[0-3][0-9]/[0-1][0-9]/[0-9][0-9][0-9][0-9]");
            if (match.Success)
            {
                Console.WriteLine("Funcionou!");
            }
            else
            {
                Console.WriteLine("Data Inválida!");
            }
        }
    }
}
    }

    
}
