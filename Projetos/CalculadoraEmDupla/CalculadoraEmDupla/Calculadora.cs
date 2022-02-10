using System;
using System.Collections.Generic;

namespace CalculadoraEmDupla
{
    public class Calculadora
    {
        public List<Conta> historico;
        public Calculadora()
        {
            historico = new List<Conta>();
        }
        public void AdicionarAoHistorico(Conta conta)
        {
            historico.Add(conta);
        }
        public int RealizarOperacoes(string opcao, int primeiroNum, int segundoNum)
        {
            switch (opcao)
            {
                case "1": return primeiroNum + segundoNum;
                case "2": return primeiroNum - segundoNum;
                case "3": return primeiroNum * segundoNum;
                case "4": return primeiroNum / segundoNum;
                default: return 0;
            }

        }
        public void MostrarHistorico()
        {
            Console.Clear();
            Console.WriteLine("Histórico de Operações Realizadas\n");

            if (historico.Count == 0)
                Console.WriteLine("Histórico Vazio :(");
            else
                foreach (var item in historico)
                    Console.WriteLine(item);

            Console.ReadKey();
            Console.Clear();
        }
        public string GetOperacao(string opcao)
        {
            switch (opcao)
            {
                case "1": return "Adição";
                case "2": return "Subtração";
                case "3": return "Multiplicação";
                case "4": return "Divisão";
                default: return "";
            }
        }
        public string GetSimbolo(string opcao)
        {
            switch (opcao)
            {
                case "1": return "+";
                case "2": return "-";
                case "3": return "*";
                case "4": return "/";
                default: return "";
            }
        }
    }
}
