using System;

namespace Exceptions
{
    class DataValida
    {
        int dia, mes, ano;
        bool bixesto;

        public DataValida(int d, int m, int a)
        {
            try
            {
                this.dia = d;
                this.mes = m;
                this.ano = a;
                Validar(d, m, a);
                Console.WriteLine("Deu boa...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public override string ToString()
        {
            return dia + " / " + mes + " / " + ano;
        }

        private void Validar(int d, int m, int a)
        {
            if ((a % 400 == 0 || (a % 4 == 0 && a % 100 != 0)))
            {
                bixesto = true;
            }
            if (bixesto == true)
            {
                if (d > 31 || d < 0 || d > 30 && m == 4 || d > 30 && m == 6 ||
                    d > 30 && m == 9 || d > 30 && m == 11 || d > 29 && m == 2)
                    throw new Exception("Dia inválido!");

                if (m > 12 || m < 0)
                    throw new Exception("Mês inválido!");

                if (a < 0)
                    throw new Exception("Ano inválido");
            }
            else
            {
                if (d > 31 || d < 0 || d > 30 && m == 4 || d > 30 && m == 6 ||
                    d > 30 && m == 9 || d > 30 && m == 11 || d > 28 && m == 2)
                    throw new Exception("Dia inválido!");

                if (m > 12 || m < 0)
                    throw new Exception("Mês inválido");

                if (a < 0)
                    throw new Exception("Ano inválido");
            }
        }
    }
}
