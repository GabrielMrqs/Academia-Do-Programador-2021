using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp
{
    class Calculadora
    {
        public string[] operacoesRealizadas = new string[100];
        public string opcao = "";
        public double resultado = 0;
        public int contadorOperacoesRealizadas = 0;
        public string simboloOperacao = "";
        public double primeiroNumero, segundoNumero;

        public bool OpcaoCinco(string opcao)
        {
            return opcao == "5";
        }

        public void OutputOperacoes(string opcao, ref double resultado, double primeiroNumero, double segundoNumero, ref string simboloOperacao)
        {

            switch (opcao)
            {
                case "1":

                    resultado = primeiroNumero + segundoNumero;
                    simboloOperacao = "+";
                    Console.WriteLine("O resultado é: " + resultado); break;
                case "2":

                    resultado = primeiroNumero - segundoNumero;
                    simboloOperacao = "-";
                    Console.WriteLine("O resultado é: " + resultado); break;
                case "3":

                    resultado = primeiroNumero * segundoNumero;
                    simboloOperacao = "*";
                    Console.WriteLine("O resultado é: " + resultado); break;
                case "4":

                    if (segundoNumero == 0)
                    {
                        Console.WriteLine("Impossível Dividir por 0");
                        break;
                    }
                    resultado = primeiroNumero / segundoNumero;
                    simboloOperacao = "/";
                    Console.WriteLine("O resultado é: " + resultado); break;

            }
        }

        public bool SairDoAplicativo(string opcao)
        {
            return opcao.Equals("s", StringComparison.OrdinalIgnoreCase);
        }

        public bool ConfirmacaoOpcaoValida(string opcao)
        {
            return opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "S" && opcao != "s";
        }

        public void MostrarMenu()
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("Digite 1 para somar");
            Console.WriteLine("Digite 2 para subtrair");
            Console.WriteLine("Digite 3 para multiplicar");
            Console.WriteLine("Digite 4 para dividir");
            Console.WriteLine("Digite 5 para visualizar as operações realizadas");
            Console.WriteLine("Digite S para sair");
        }

    }

}
