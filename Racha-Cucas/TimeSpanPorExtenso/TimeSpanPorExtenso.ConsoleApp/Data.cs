using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanPorExtenso.ConsoleApp
{
    public class Data : DatasPorExtenso
    {
        private DateTime dataDeComparacao;
        public DateTime DataDeComparacao { get => dataDeComparacao; }

        public Data(DateTime data)
        {
            this.dataDeComparacao = data;
        }
    }
}
