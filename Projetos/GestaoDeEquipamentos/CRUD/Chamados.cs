using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Chamados
    {
        private string titulo;
        private string descricao;
        private Equipamentos equipamento;
        private DateTime data_abertura;

        public Chamados(string titulo, string descricao, Equipamentos equipamento, DateTime data_abertura)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.equipamento = equipamento;
            this.data_abertura = data_abertura;
        }
        private static string exibirData(DateTime data)
        {
            return data.Day + "/" + data.Month + "/" + data.Year;
        }
        public int dias_em_aberto(DateTime data)
        {
            TimeSpan difereca = DateTime.Now.Subtract(data);
            return Convert.ToInt32(difereca.TotalDays);
        }
        public override string ToString()
        {
            return "Título: " + titulo + "| Equipamento: " + equipamento.Nome + "| Data de Abertura: " + exibirData(data_abertura);
        }
    }
}
