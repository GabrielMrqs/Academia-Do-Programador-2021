using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraObjetos.ConsoleApp
{
    class Calculadora
    {
        public void Menu()
        {
            Console.WriteLine("Calculadora P.O.O");
            Console.WriteLine("Digite 1 para somar");
            Console.WriteLine("Digite 2 para subtrair");
            Console.WriteLine("Digite 3 para multiplicar");
            Console.WriteLine("Digite 4 para dividir");
            Console.WriteLine("Digite 5 para visualizar as operações realizadas");
            Console.WriteLine("Digite 6 para sair");
        }
        public void Operacoes(ref string simboloOperacao, string opcao, double num1, double num2, ref double resultado)
        {
            switch (opcao)
            {
                case "1": simboloOperacao = "+"; resultado = num1 + num2; break;
                case "2": simboloOperacao = "-"; resultado = num1 - num2; break;
                case "3": simboloOperacao = "*"; resultado = num1 * num2; break;
                case "4":
                    simboloOperacao = "/";
                    if (num2 == 0)
                    {
                        resultado = 0;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Impossível dividir por 0, tente novamente!");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    resultado = num1 / num2; break;
                default: break;
            }
        }
        public void VisualizarOperacoes(int contadorOperacoesRealizadas, string[] operacoesRealizadas)
        {
            if (contadorOperacoesRealizadas == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhuma operação, tente novamente!");
                Console.ResetColor();
            }
            else
            {
                for (int i = 0; i < operacoesRealizadas.Length; i++)
                {
                    if (operacoesRealizadas[i] != null)
                        Console.WriteLine(operacoesRealizadas[i]);
                }
            }
        }
    }
}
