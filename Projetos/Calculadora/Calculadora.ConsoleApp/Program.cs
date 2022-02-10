using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp
{
    class Program
    {   
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            while (true)
            {
                calculadora.MostrarMenu();

                calculadora.opcao = Console.ReadLine();

                if (calculadora.ConfirmacaoOpcaoValida(calculadora.opcao))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida! Tente Novamente");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                if (calculadora.OpcaoCinco(calculadora.opcao))
                {
                    if (calculadora.contadorOperacoesRealizadas == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nenhuma operação! Tente novamente");
                        Console.ResetColor();
                    }
                    else
                    {
                        for (int i = 0; i < calculadora.operacoesRealizadas.Length; i++)
                        {
                            if (calculadora.operacoesRealizadas[i] != null)
                                Console.WriteLine(calculadora.operacoesRealizadas[i]);
                        }
                    }
                    Console.ReadLine();
                    Console.Clear();

                    continue;
                }

                if (calculadora.SairDoAplicativo(calculadora.opcao))
                {
                    break;
                }

                Console.Write("Digite o primeiro número: ");
                calculadora.primeiroNumero = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                calculadora.segundoNumero = Convert.ToDouble(Console.ReadLine());

                calculadora.OutputOperacoes(calculadora.opcao, ref calculadora.resultado, calculadora.primeiroNumero, calculadora.segundoNumero, ref calculadora.simboloOperacao);

                string operacaoRealizada =
                    calculadora.primeiroNumero.ToString() + " " + calculadora.simboloOperacao + " " +
                    calculadora.segundoNumero.ToString() + " = " + calculadora.resultado.ToString();

                calculadora.operacoesRealizadas[calculadora.contadorOperacoesRealizadas] = operacaoRealizada;

                calculadora.contadorOperacoesRealizadas++;

                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();
            }

        }
       
    }
}
