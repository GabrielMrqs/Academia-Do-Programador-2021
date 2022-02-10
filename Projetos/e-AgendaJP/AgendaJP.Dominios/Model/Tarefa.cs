using System;

namespace AgendaJP.Dominios.Model
{
    public class Tarefa : EntidadeBase
    {
        public Tarefa(string prioridade, string titulo, DateTime dataCriacao, DateTime dataConclusao, double percentual)
        {
            this.Titulo = titulo;
            this.Prioridade = prioridade;
            this.DataCriacao = dataCriacao;
            this.DataConclusao = dataConclusao;
            this.Percentual = percentual;
        }

        public string Titulo { get; private set; }
        public string Prioridade { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataConclusao { get; private set; }
        public double Percentual { get; private set; }
        public override string ToString()
        {
            return $"ID: {Id} \nPrioridade: {Prioridade} \nTítulo: {Titulo} \nData de Criação: {DataCriacao.ToString("d")}" +
                $" \nData de Conclusão: {DataConclusao.ToString("d")} \nPercentual: {Percentual}%" +
                $"\n------------------------------------------------------------------------------------------------------------------------";
        }

        public override string Validar()
        {
            string ehValido = "";
            if (string.IsNullOrEmpty(Titulo))
                ehValido += "Titulo em branco.\n";
            if (string.IsNullOrEmpty(Prioridade))
                ehValido += "Prioridade em branco.\n";
            if (Percentual > 100 || Percentual < 0)
                ehValido += "Percentual inválido.\n";
            if (DataCriacao > DataConclusao)
                ehValido += "Data em formato inválido.\n";

            return ehValido;
        }
    }
}
