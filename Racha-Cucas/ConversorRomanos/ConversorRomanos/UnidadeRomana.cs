using System.Collections.Generic;

namespace ConversorRomanos
{
    public class UnidadeRomana
    {
        private readonly Dictionary<char, int> DicionarioIndoArabico = new Dictionary<char, int>()
        {
            {'x', 10000}, {'v', 5000 },{'i', 1000 },{ 'M', 1000 }, { 'D', 500 }, { 'C', 100 },{ 'L', 50 }, { 'X', 10 }, { 'V', 5 }, { 'I', 1 }
        };
        public int ConverterRomanoParaIndoArabico(string algarismoRomano)
        {
            int resultadoEmIndoArabico = 0;
            for (int i = 0; i < algarismoRomano.Length; i++)
            {
                algarismoRomano = AlgarismoRecolocado(algarismoRomano);

                char algarismoAtual = algarismoRomano[i];
                int resultadoAtual = DicionarioIndoArabico[algarismoAtual];

                if (EhPossivelSubtrair(algarismoAtual, VerificarAlgarismoAEsquerda(algarismoRomano, i)))
                    resultadoEmIndoArabico = AtualSubtraidoPeloAEsquerda(resultadoAtual, resultadoEmIndoArabico, VerificarAlgarismoAEsquerda(algarismoRomano, i));
                else
                    resultadoEmIndoArabico += resultadoAtual;
            }
            return resultadoEmIndoArabico;
        }

        private static string AlgarismoRecolocado(string algarismoRomano)
        {
            algarismoRomano = algarismoRomano.Replace("Ī", "i");
            algarismoRomano = algarismoRomano.Replace("V̄", "v");
            algarismoRomano = algarismoRomano.Replace("X̄", "x");
            return algarismoRomano;
        }
        private int AtualSubtraidoPeloAEsquerda(int resultadoAtualMultiplicado, int resultadoEmIndoArabico, char algarismoAEsquerda)
        {
            if (resultadoAtualMultiplicado > DicionarioIndoArabico[algarismoAEsquerda])
                resultadoEmIndoArabico += resultadoAtualMultiplicado - ((DicionarioIndoArabico[algarismoAEsquerda]) * 2);
            else
                resultadoEmIndoArabico += resultadoAtualMultiplicado;
            return resultadoEmIndoArabico;
        }
        private static bool EhPossivelSubtrair(char algarismoAtual, char algarismoAEsquerda)
        {
            return !(algarismoAEsquerda != 'I' && algarismoAEsquerda != 'X' && algarismoAEsquerda != 'C' && algarismoAEsquerda != 'i' && algarismoAEsquerda != 'x' && algarismoAEsquerda != 'v' || algarismoAtual == algarismoAEsquerda);
        }
        private static char VerificarAlgarismoAEsquerda(string algarismoRomano, int i)
        {
            return i != 0 ? algarismoRomano[i - 1] : ' ';
        }
    }
}