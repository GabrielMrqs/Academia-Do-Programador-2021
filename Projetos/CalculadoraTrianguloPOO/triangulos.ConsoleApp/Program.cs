using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculadora Triângulos\n");

                Console.WriteLine("Insira o lado A do triângulo: ");
                int ladoA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira o lado B do triângulo: ");
                int ladoB = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira o lado C do triângulo: ");
                int ladoC = Convert.ToInt32(Console.ReadLine());

                Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);

                if (triangulo.TrianguloValido())
                {
                    Console.WriteLine(triangulo.TrianguloTipo());
                }
                else
                {
                    Console.WriteLine("Triângulo Inválido!");
                }

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
