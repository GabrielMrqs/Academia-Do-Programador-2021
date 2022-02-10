using System.Collections.Generic;

namespace ConversorRomanos
{
    public class UnidadeIndoArabica
    {
        private Dictionary<int, string> DicionarioIndoArabico = new Dictionary<int, string>()
        {
            { 10000, "X̄" },{ 9000, "ĪX̄" },{ 8000, "V̄ĪĪĪ" },{ 7000, "V̄ĪĪ" }, { 6000, "V̄Ī" },
            { 5000, "V̄" }, { 4000, "ĪV̄" },{ 1000, "M" },{ 900, "CM" },{ 500, "D" },
            { 400, "CD"} , { 100, "C" },{ 90, "XC" },{ 50, "L" }, { 40, "XL" },
            { 10, "X" }, { 9, "IX" },{ 5, "V" }, { 4, "IV" },{ 1, "I" },
        };
        public string ConverterIndoArabicaParaRomano(int algarismoIndoArabico)
        {
            foreach (int numero in DicionarioIndoArabico.Keys)
            {
                if (algarismoIndoArabico >= numero)
                    return DicionarioIndoArabico[numero] + ConverterIndoArabicaParaRomano(algarismoIndoArabico - numero);
            }
            return "";
        }
    }
}
