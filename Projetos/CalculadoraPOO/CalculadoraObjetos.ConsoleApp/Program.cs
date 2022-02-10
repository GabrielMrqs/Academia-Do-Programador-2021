using System;

namespace CalculadoraObjetos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            int contadorOperacoesRealizadas = 0;
            double resultado = 0, num1 = 0, num2 = 0;
            string simboloOperacao = "", opcao = "";
            string[] operacoesRealizadas = new string[100];

            while (true)
            {

                calculadora.Menu();

                opcao = Console.ReadLine();

                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida, tente novamente!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                if (opcao == "6") { break; }

                switch (opcao)
                {
                    case "5": calculadora.VisualizarOperacoes(contadorOperacoesRealizadas, operacoesRealizadas); Console.ReadLine(); Console.Clear(); continue;
                    default: break;
                }

                Console.WriteLine("Digite o primeiro número: "); num1 = Convert.ToDouble((Console.ReadLine()));
                Console.WriteLine("Digite o segundo número: "); num2 = Convert.ToDouble((Console.ReadLine()));

                calculadora.Operacoes(ref simboloOperacao, opcao, num1, num2, ref resultado);

                if (opcao != "4" && num2 != 0)
                {
                    Console.WriteLine("Resultado: " + resultado); Console.ReadLine(); Console.Clear();
                }

                string operacaoRealizada = num1.ToString() + " " + simboloOperacao + " " + num2.ToString() + " = " + resultado.ToString();

                operacoesRealizadas[contadorOperacoesRealizadas] = operacaoRealizada;

                contadorOperacoesRealizadas++;

            }

        }

    }
}
