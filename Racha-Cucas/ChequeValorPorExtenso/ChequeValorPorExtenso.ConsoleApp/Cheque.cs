using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequeValorPorExtenso.ConsoleApp
{
    public class Cheque : Conversor
    {
        private decimal valor;

        public Cheque(decimal valor)
        {
            this.valor = valor;
        }

    }
}
