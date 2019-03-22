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
            // calculoIMC(86, 1.75);
            // listagemDDDs();
            calculadora();
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
        // QUESTAO 6
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
        // QUESTAO 7
        public static void calculoIMC(double peso, double altura) {
            double IMC = peso/(altura*altura);
            if (IMC < 18.5) {
                Console.WriteLine("Você está abaixo do peso.");
            } else if (IMC >= 18.5 & IMC < 25) {
                Console.WriteLine("Você está no seu peso normal.");
            } else if (IMC >= 25 & IMC < 30) {
                Console.WriteLine("Você está com sobrepeso.");
            } else if (IMC >= 30 & IMC < 35) {
                Console.WriteLine("Você está com obesidade grau I.");
            } else if (IMC >= 35 & IMC < 40) {
                Console.WriteLine("Você está com obesidade grau II.");
            } else if (IMC > 40) {
                Console.WriteLine("Você está com obesidade grau III.");
            } else 
                Console.WriteLine("Erro.");
        }
        // QUESTAO 8
        public static void listagemDDDs() {
            Console.WriteLine("Digite o seu DDD: ");
            int input_ddd = Convert.ToInt32(Console.ReadLine());

            switch (input_ddd)
            {
                case 11: {
                    Console.WriteLine("São Paulo - SP");
                    break;
                }
                case 21: {
                    Console.WriteLine("Rio de Janeiro - RJ");
                    break;
                }
                case 27: {
                    Console.WriteLine("Vitória - ES");
                    break;
                }
                case 31: {
                    Console.WriteLine("Belo Horizonte - MG");
                    break;
                }
                case 41: {
                    Console.WriteLine("Curitiba - PR");
                    break;
                }
                case 48: {
                    Console.WriteLine("Florianópolis - SC");
                    break;
                }
                case 51: {
                    Console.WriteLine("Porto Alegre - RS");
                    break;
                }
                case 61: {
                    Console.WriteLine("Brasília - DF");
                    break;
                }
                default: {
                    Console.WriteLine("Parâmetro inválido");
                    break;
                }
            }
        }
        // QUESTAO 9
        public static void calculadora() {
            Console.WriteLine("=================");
            Console.WriteLine("1 - soma    ");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - multiplicação");
            Console.WriteLine("4 - divisão");
            Console.WriteLine("=================");
            Console.WriteLine("Digite a opção desejada: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            double n1, n2;

            switch (opcao)
            {
                case 1: {
                    Console.WriteLine("Digite o primeiro número a ser somado: ");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número a ser somado: ");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(n1 + n2);
                    break;
                }
                case 2: {
                    Console.WriteLine("Digite o primeiro número a ser subtraído: ");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número a ser subtraído: ");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(n1 - n2);
                    break;
                }
                case 3: {
                    Console.WriteLine("Digite o primeiro número a ser multiplicado: ");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número a ser multiplicado: ");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(n1 * n2);
                    break;
                }
                case 4: {
                    Console.WriteLine("Digite o primeiro número a ser dividido: ");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número a ser dividido: ");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    if (n2 == 0){
                        Console.WriteLine("Não existe divisão por zero");
                        break;
                    }
                    Console.WriteLine(n1 / n2);
                    break;
                }
                default: {
                    Console.WriteLine("Sem tempo irmão.");
                    break;
                }
            }
        }
    }
}