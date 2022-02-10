using System;
using System.Collections.Generic;

namespace ChequeValorPorExtenso.ConsoleApp
{
    public class Conversor
    {
        public string RetornaValorPorExtenso(decimal valor)
        {
            if (valor <= 0 || valor >= 1000000000000000)
                return "Quantidade inválida";

            Stack<string> ordens = new Stack<string>();

            List<string> picotados = FormatarValorEmClasses(valor);

            bool valorRedondo = ConferirSeProximaClasseEhVazia(picotados);

            MontarNumeroCompleto(valor, picotados, ordens, valorRedondo);

            return MontarString(ordens);
        }
            
        private int MontarNumeroCompleto(decimal valor, List<string> picotados, Stack<string> ordens, bool valorRedondo)
        {
            int indiceBases = 0;
            for (int i = picotados.Count; i > 0; i--)
            {
                string classeAtual = picotados[i - 1];
                string espacadorClasse = "";
                string baseAtual;
                if (classeAtual != "000" || (indiceBases == 1 && valor > 1))
                {
                    espacadorClasse = ValidarPreposicoes(picotados, indiceBases, valorRedondo, i, espacadorClasse);

                    baseAtual = ConferirSeClasseEhSingularOuPlural(indiceBases, classeAtual);

                    ordens.Push(" " + baseAtual + espacadorClasse);
                }
                indiceBases++;

                ordens.Push(MontarClassePorExtenso(classeAtual));
            }

            return indiceBases;
        }
        private static string ValidarPreposicoes(List<string> picotados, int indiceBases, bool valorRedondo, int i, string espacadorClasse)
        {
            if (indiceBases == 1 && picotados[i] != "000") espacadorClasse = " e ";
            else if (indiceBases > 1 && picotados[i] != "000") espacadorClasse = " ";
            else if (i < picotados.Count - 2 && valorRedondo) espacadorClasse = " de";
            else if (i < picotados.Count - 2) espacadorClasse = " e ";
            return espacadorClasse;
        }
        private string ConferirSeClasseEhSingularOuPlural(int indiceBases, string classeAtual)
        {
            string baseAtual;
            if (classeAtual == "001") baseAtual = Valores.basesSingular[indiceBases];
            else baseAtual = Valores.basesPlural[indiceBases];
            return baseAtual;
        }
        private string MontarClassePorExtenso(string classeAtual)
        {
            string espacadorDezena = "";
            string espacadorCentena = "";
            int unidade = (int)Char.GetNumericValue(classeAtual[2]);
            int dezena = (int)Char.GetNumericValue(classeAtual[1]);
            int centena = (int)Char.GetNumericValue(classeAtual[0]);
            string strUnidade = Valores.unidades[unidade];
            string strDezena = Valores.dezenas[dezena];
            string strCentena = Valores.centenas[centena];

            if (classeAtual == "100")
                strCentena = "cem";
            if (centena > 0 && (dezena > 0 || unidade > 0))
                espacadorCentena = " e ";
            if (dezena > 1 && unidade != 0)
                espacadorDezena = " e ";

            if (dezena == 1 && unidade != 0)
            {
                strDezena = Valores.onzeAteDezenove[unidade];
                strUnidade = "";
            }
            return strCentena + espacadorCentena + strDezena + espacadorDezena + strUnidade;
        }
        private static List<string> FormatarValorEmClasses(decimal valor)
        {
            String strValor = Convert.ToDecimal(valor).ToString("000,000,000,000,000.00");
            string[] centavos = strValor.Split(',');
            string[] classes = centavos[0].Split('.');

            List<string> separados = new List<string>();
            foreach (string classe in classes)
            {
                separados.Add(classe);
            }
            separados.Add("0" + centavos[1]);
            return separados;
        }
        private bool ConferirSeProximaClasseEhVazia(List<string> classes)
        {
            int ocorrencias = 0;
            for (int i = classes.Count - 1; i > 0; i--)
            {
                if (classes[i - 1] != "000") ocorrencias++;
            }
            return ocorrencias == 1;
        }
        private static string MontarString(Stack<string> ordens)
        {
            string resultado = "";
            while (ordens.Count > 0)
                resultado += ordens.Pop();
            return resultado;
        }
    }
}
