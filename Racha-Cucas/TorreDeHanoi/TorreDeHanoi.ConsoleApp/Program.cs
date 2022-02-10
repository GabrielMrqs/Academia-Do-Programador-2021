using System;

namespace TorreDeHanoi.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Calculador de Movimentos Torre de Hanoi (CMTH.LTDA)");

            Console.WriteLine("Insira a quantidade de discos máxima que queira ver:");
            int repeticoes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Jogar(repeticoes);

        }

        private static void Jogar(int repeticoes)
        {
            for (int i = 1; i <= repeticoes; i++)
            {
                Torre torre = new(i);
                Jogo jogo = new(torre);
                var movimentos = jogo.RealizarMovimentos();
                Console.WriteLine($"Será(ão) necessário(s) {movimentos} movimento(s)" +
                                  $" para completar o jogo com {torre.Discos} disco(s)");
            }
        }
    }
}
