using System.Collections.Generic;

namespace ChequeValorPorExtenso.ConsoleApp
{
    public class Valores
    {
        public static List<string> unidades = new List<string> { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
        public static List<string> onzeAteDezenove = new List<string> { "", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
        public static List<string> dezenas = new List<string> { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
        public static List<string> centenas = new List<string> { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };
        public static List<string> basesSingular = new List<string> { "centavo de real", "real", "mil", "milhão", "bilhão", "trilhão" };
        public static List<string> basesPlural = new List<string> { "centavos de real", "reais", "mil", "milhões", "bilhões", "trilhões" };
    }
}
