using System;

namespace ClubeDaLeitura.ConsoleApp.Domínios
{
    class Emprestimo : Registro<Emprestimo>
    {
        Amiguinho amiguinho;
        Revista revista;
        DateTime dataEmprestimo;
        DateTime dataDevolucao;

        public Emprestimo()
        {
            id = GeradorID.IdEmprestimo;
        }
        public Emprestimo(Amiguinho amiguinho, Revista revista, DateTime dataEmprestimo, DateTime dataDevolucao)
        {
            this.amiguinho = amiguinho;
            this.revista = revista;
            this.dataEmprestimo = dataEmprestimo;
            this.dataDevolucao = dataDevolucao;
        }

        public DateTime DataEmprestimo { get => dataEmprestimo; set => dataEmprestimo = value; }
        public DateTime DataDevolucao { get => dataDevolucao; set => dataDevolucao = value; }
        public Amiguinho Amiguinho { get => amiguinho; set => amiguinho = value; }
        public Revista Revista { get => revista; set => revista = value; }
    }
}
