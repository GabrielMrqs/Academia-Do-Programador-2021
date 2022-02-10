using System;
using System.Collections.Generic;

namespace TimeSpanPorExtenso.ConsoleApp
{
    public class DatasPorExtenso
    {
        List<string> unidades = new List<string> { "", "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
        List<string> unidadesHoras = new List<string> { "", "", "uma", "duas", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
        List<string> onzeAteDezenove = new List<string> { "", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
        List<string> dezenas = new List<string> { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
        List<string> diasSingular = new List<string> { " dia ", " mês ", " ano " };
        List<string> diasPlural = new List<string> { " dias ", " meses ", " anos " };
        List<string> horasSingular = new List<string> { " hora ", " minuto ", " segundo " };
        List<string> horasPlural = new List<string> { " horas ", " minutos ", " segundos " };

        string[] strDataArray, strHoraArray, strVazio;
        string horario = "", diaMesAno = "", separador = "";

        public void Separar(string data)
        {
            strVazio = data.Split(' ');
            strDataArray = strVazio[0].Split('/');
            strHoraArray = strVazio[1].Split(':');
        }
        public string Retornar()
        {
            MontaStringData();
            MontaStringHorario();
            return diaMesAno + horario + "atrás";
        }
        public string TimeSpan(DateTime data, DateTime dataPassada)
        {
            DateTime recebe = new DateTime();
            TimeSpan diferenca = dataPassada.Subtract(data);
            DateTime resultado = recebe.Add(diferenca);
            return resultado.ToString();
        }
        private void MontaStringData()
        {
            string complementoDiaMes;
            for (int i = 2; i >= 0; i--)
            {
                int unidadeDiaMes = 0, dezenaDiaMes = 0;
                if (i == 2)
                {
                    unidadeDiaMes = (int)Char.GetNumericValue(strDataArray[i][3]);
                    dezenaDiaMes = (int)Char.GetNumericValue(strDataArray[i][2]);
                }
                else if (i < 2)
                {
                    unidadeDiaMes = (int)Char.GetNumericValue(strDataArray[i][1]);
                    dezenaDiaMes = (int)Char.GetNumericValue(strDataArray[i][0]);
                }

                string strUnidadeDiaMes = unidades[unidadeDiaMes];
                string strDezenaDiaMes = dezenas[dezenaDiaMes];

                if (unidadeDiaMes == 2 && dezenaDiaMes == 0)
                { complementoDiaMes = diasSingular[i]; }
                else complementoDiaMes = diasPlural[i];

                if (dezenaDiaMes == 1 && unidadeDiaMes != 0)
                {
                    strDezenaDiaMes = onzeAteDezenove[unidadeDiaMes - 1];
                    strUnidadeDiaMes = "";
                }

                if (dezenaDiaMes >= 2 && unidadeDiaMes != 0) separador = " e ";
                else separador = "";

                if (dezenaDiaMes == 0 && unidadeDiaMes == 1) continue;

                diaMesAno += strDezenaDiaMes + separador + strUnidadeDiaMes + complementoDiaMes;
            }
        }
        private void MontaStringHorario()
        {
            string complementoHora;
            for (int i = 0; i < 3; i++)
            {
                int unidadeHora = (int)Char.GetNumericValue(strHoraArray[i][1]);
                int dezenaHora = (int)Char.GetNumericValue(strHoraArray[i][0]);

                string strDezenaHora = dezenas[dezenaHora];
                string strUnidadeHora;
                if (i == 0) { strUnidadeHora = unidadesHoras[unidadeHora + 1]; }
                else strUnidadeHora = unidades[unidadeHora + 1];

                if (unidadeHora == 1 && dezenaHora == 0)
                { complementoHora = horasSingular[i]; }
                else complementoHora = horasPlural[i];

                if (dezenaHora == 1 && unidadeHora != 0)
                {
                    strDezenaHora = onzeAteDezenove[unidadeHora];
                    strUnidadeHora = "";
                }

                if (dezenaHora >= 2 && unidadeHora != 0) separador = " e ";
                else separador = "";

                if (dezenaHora == 0 && unidadeHora == 0) continue;

                horario += strDezenaHora + separador + strUnidadeHora + complementoHora;
            }
        }
    }
}
