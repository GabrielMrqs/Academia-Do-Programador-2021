using System;

namespace CalculadoraEmDupla
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            while (true)
            {

                #region Menu
                Console.WriteLine("Calculadora Andrey & Gabriel ltda\n");
                Console.WriteLine("Insira 1 para Adição");
                Console.WriteLine("Insira 2 para Subtração");
                Console.WriteLine("Insira 3 para Multiplicação");
                Console.WriteLine("Insira 4 para Divisão");
                Console.WriteLine("Insira 5 para Histórico de contas");
                Console.WriteLine("Insira S para Sair");
                Console.Write("Opção: ");

                string opcao = Console.ReadLine().ToLower();

                if (opcao == "s")
                    break;

                if (opcao == "5")
                {
                    calculadora.MostrarHistorico();
                    continue;
                }

                #endregion

                #region Operacao

                Console.Clear();

                Console.Write("Insira o primeiro número: ");
                int primeiroNum = Convert.ToInt32(Console.ReadLine());

                int segundoNum;
                while (true)
                {
                    Console.Write("Insira o segundo número: ");
                    segundoNum = Convert.ToInt32(Console.ReadLine());
                    if (segundoNum == 0)
                        Console.WriteLine("\nImpossível dividir por 0");
                    else
                        break;
                }
                int resultado = calculadora.RealizarOperacoes(opcao, primeiroNum, segundoNum);

                string operacao = calculadora.GetOperacao(opcao);

                string simbolo = calculadora.GetSimbolo(opcao);

                Conta conta = new Conta(primeiroNum + " " + simbolo + " " + segundoNum + " = " + resultado);

                calculadora.AdicionarAoHistorico(conta);

                #endregion

                #region Resultado

                Console.Clear();
                Console.WriteLine("Resultado da " + operacao + ":\n" + conta);
                Console.ReadKey();
                Console.Clear();
                #endregion

            }
        }


    }
}
