using System.Collections.Generic;

namespace EscrevendoNoCelular.ConsoleApp
{
    public class Conversoes
    {
        public string SepararLetras(string mensagemPassada)
        {
            List<string> numeros = new List<string>();
            string resultado = "";
            int i = 0;
            if (mensagemPassada.Length > 255) return "Mensagem extrapola limite de 255 caracteres";
            foreach (char letra in mensagemPassada)
            {
                string separador = "";
                numeros.Add(AgregarValorAoChar(letra));

                if (i > 0 && numeros[i][0] == numeros[i - 1][0]) separador = "_";

                resultado += separador + numeros[i];
                i++;
            }

            return resultado;
        }
        private string AgregarValorAoChar(char letra)
        {
            switch (letra)
            {
                case 'A': return "2";
                case 'B': return "22";
                case 'C': return "222";
                case 'D': return "3";
                case 'E': return "33";
                case 'F': return "333";
                case 'G': return "4";
                case 'H': return "44";
                case 'I': return "444";
                case 'J': return "5";
                case 'K': return "55";
                case 'L': return "555";
                case 'M': return "6";
                case 'N': return "66";
                case 'O': return "666";
                case 'P': return "7";
                case 'Q': return "77";
                case 'R': return "777";
                case 'S': return "7777";
                case 'T': return "8";
                case 'U': return "88";
                case 'V': return "888";
                case 'W': return "9";
                case 'X': return "99";
                case 'Y': return "999";
                case 'Z': return "9999";
                case ' ': return "0";
                default: return "ALGORISMO INVÁLIDO!";
            }
        }
    }
}
