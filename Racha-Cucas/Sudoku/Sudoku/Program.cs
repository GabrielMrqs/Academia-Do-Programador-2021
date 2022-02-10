using System;
using System.Collections.Generic;

namespace Sudoku
{
    class Program
    {
        static int[,] sudoku = new int[,] {
                     {1,3,2,5,7,9,4,6,8},
                     {4,9,8,2,6,1,3,7,5},
                     {7,5,6,3,8,4,2,1,9},
                     {6,4,3,1,5,8,7,9,2},
                     {5,2,1,7,9,3,8,4,6},
                     {9,8,7,4,2,6,5,3,1},
                     {2,1,4,9,3,5,6,8,7},
                     {3,6,5,8,1,7,9,2,4},
                     {8,7,9,6,4,2,1,5,3}};
       
        static void Main(string[] args)
        {
            printarMatriz(sudoku);

            validacao(sudoku);

            Console.ReadLine();
        }

        private static void validacao(int[,] matriz)
        {
            if (verificarColunas(matriz) && verificarLinhas(matriz) && verificarQuadrados(matriz)) { Console.WriteLine("\nSIM!"); }
            else { Console.WriteLine("\nNÃO!"); }
        }

        private static bool verificarQuadrados(int[,] matriz)
        {
            HashSet<int> numeros = new HashSet<int>();
            bool certo = true;

            for (int s = 0; s < 9; s += 3)
            {
                for (int m = 0; m < 9; m += 3)
                {
                    numeros = new HashSet<int>();

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            certo = numeros.Add(matriz[i + s, j + m]);
                            if (!certo) { return certo; }
                        }
                    }
                    
                }
            }
            return certo;
        }

        private static bool verificarColunas(int[,] matriz)
        {
            bool certo = true;

            for (int j = 0; j < 9; j++)
            {
                HashSet<int> numeros = new HashSet<int>();
                for (int i = 0; i < 9; i++)
                {
                    certo = numeros.Add(matriz[i, j]);
                    if (!certo) { return certo; }
                }
            }
            return certo;
        }

        private static bool verificarLinhas(int[,] matriz)
        {
            bool certo = true;

            for (int i = 0; i < 9; i++)
            {
                HashSet<int> numeros = new HashSet<int>();
                for (int j = 0; j < 9; j++)
                {
                    certo = numeros.Add(matriz[i, j]);
                    if (!certo) { return certo; }
                }
            }
            return certo;
        }

        private static void printarMatriz(int[,] matriz)
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }

}