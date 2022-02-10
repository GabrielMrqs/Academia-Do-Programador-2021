using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Equipamentos
    {
        private string nome;
        private double preco;
        private int n_serie;
        private DateTime data_fabricacao;
        private string fabricante;

        public Equipamentos(string nome, double preco, int n_serie, DateTime data_fabricacao, string fabricante)
        {
            this.nome = nome;
            this.preco = preco;
            this.n_serie = n_serie;
            this.data_fabricacao = data_fabricacao;
            this.fabricante = fabricante;
        }

        public string Nome { get => nome; set => nome = value; }

        public override string ToString()
        {
            return "Nome: " + nome + "| Nº de série: " + n_serie + "| Fabricante: " + fabricante;
        }
    }  
}
