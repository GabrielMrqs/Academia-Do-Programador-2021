using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class Jogo
    {
        public Jogo(List<Jogador> jogadores)
        {
            Jogadores = jogadores;
        }

        public List<Jogador> Jogadores { get; }
        private readonly Dictionary<char, double> cartas = new Dictionary<char, double>()
        {
            {'2', 1.1}, {'3', 1.2}, {'4', 1.3}, {'5', 1.4}, {'6', 1.5}, {'7', 1.6}, {'8', 1.7}, {'9', 1.8}, {'T', 1.9}, {'J', 2}, {'Q', 2.1}, {'K', 2.2}, {'A', 2.3}
        };

        public string RetornarVencedor()
        {
            AtribuirPontos();

            double pontoMax = int.MinValue;
            int indexMax = 0;

            for (int i = 0; i < Jogadores.Count; i++)
            {
                if (Jogadores[i].Pontos > pontoMax)
                {
                    pontoMax = Jogadores[i].Pontos;
                    indexMax = i + 1;
                }

            }
            return $"O jogador {indexMax} venceu!!!";
        }
        private void AtribuirPontos()
        {
            foreach (var jogador in Jogadores)
            {
                string[] array = jogador.Cartas.Mao.Split(' ');

                double[] numeroP = ConverterNumeroCartaEmValor(array);

                jogador.Pontos = RetornarPontuacaoFinal(array, numeroP);
            }
        }
        private double[] ConverterNumeroCartaEmValor(string[] array)
        {
            double[] valor = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
                valor[i] = cartas[array[i][0]];

            return valor;
        }
        private double VerificarFlush(double[] numero, string[] array)
        {
            if (VerificarSeEhRoyalFlush(array, numero))
                return 2500;

            if (VerificarSeEhMesmoNaipe(array) && VerificarSeEhSequencia(numero))
                return 2000;

            if (VerificarSeEhMesmoNaipe(array))
                return 500;

            if (VerificarSeEhSequencia(numero))
                return 400;

            return 0;
        }
        private double VerificarDuplaTrincaQuadraFullHouse(double[] array)
        {
            List<int> listCount = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                int cont = 1;

                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] == array[j])
                        cont++;

                listCount.Add(cont);
            }

            return IncrementarPontos(array, listCount);
        }
        private double IncrementarPontos(double[] array, List<int> listCount)
        {
            var soma = listCount.Sum(x => x);

            switch (soma)
            {
                case 6: return 50 * array[listCount.IndexOf(listCount.Find(x => x == 2))];
                case 7: return 100 * array[listCount.IndexOf(listCount.Find(x => x == 2))];
                case 8: return 300;
                case 9: return 450 * array[listCount.IndexOf(listCount.Find(x => x == 3))];
                case 11: return 1500;
                default: return 0;
            }
        }
        private double RetornarPontuacaoFinal(string[] array, double[] numeroP)
        {
            return VerificarDuplaTrincaQuadraFullHouse(numeroP) + VerificarFlush(numeroP, array) + RetornarPontosCartas(numeroP);
        }
        private double RetornarPontosCartas(double[] numeroP)
        {
            return numeroP.ToList().Sum(x => x);
        }
        private bool VerificarSeEhRoyalFlush(string[] arrayS, double[] arrayI)
        {
            return arrayS[0][0] == 'A' && VerificarSeEhSequencia(arrayI) && VerificarSeEhMesmoNaipe(arrayS);
        }
        private bool VerificarSeEhSequencia(double[] array)
        {
            int cont = 1;

            for (int i = 0; i < 4; i++)
            {
                var numAtual = array[i];
                var numProx = Math.Round(array[i + 1] + 0.1, 1);
                if (numAtual == numProx)
                    cont++;
            }

            return cont == 5;
        }
        private bool VerificarSeEhMesmoNaipe(string[] array)
        {
            int cont = 1;

            for (int j = 1; j < array.Length; j++)
                if (array[0][1] == array[j][1])
                    cont++;

            return cont == 5;
        }
    }
}