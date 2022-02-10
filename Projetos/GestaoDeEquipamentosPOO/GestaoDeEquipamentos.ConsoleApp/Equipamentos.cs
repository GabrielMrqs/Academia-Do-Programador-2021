using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEquipamentos.ConsoleApp
{
    class Equipamentos
    {
        private string nome;
        private double preco;
        private int numeroSerie;
        private DateTime dataFabricacao;
        private string fabricante;
        static int espacoEquip = 0;
        public static Equipamentos[] equip = new Equipamentos[10];

        public Equipamentos()
        {

        }

        public Equipamentos(string nome, double preco, int numeroSerie, DateTime dataFabricacao, string fabricante)
        {
            this.nome = nome;
            this.preco = preco;
            this.numeroSerie = numeroSerie;
            this.dataFabricacao = dataFabricacao;
            this.fabricante = fabricante;
        }

        public string Nome { get => nome; set => nome = value; }

        public void RealizarExlusaoEquipamentos()
        {
            if (equip[0] == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhum equipamento cadastrado");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                int id = 0;
                for (int i = 0; i < equip.Length; i++)
                {
                    if (equip[i] != null)
                        Console.WriteLine("ID: " + i + " " + equip[i]);
                }
                Console.WriteLine("\nInsira o ID do equipamento que deseja apagar:");
                id = Convert.ToInt32(Console.ReadLine());
                equip[id] = null;
                Console.Clear();
            }

        }

        public void RealizarCadastroEquipamentos()
        {
            int o = EncontrarCampoVazio(); equip[o] = Create();
        }

        public void VisualizarEquipamentosCadastrados()
        {
            if (equip[0] == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhum equipamento cadastrado");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Read(equip);
            }
            
        }

        public void RealizarEdicaoEquipamentos()
        {
            if (equip[0] == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhum equipamento cadastrado");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                int id = Update(); equip[id] = Create();
            }
        }

        public override string ToString()
        {
            return "| Nome: " + nome + " | Nº de série: " + numeroSerie + " | Fabricante: " + fabricante + " |";
        }

        private static int EncontrarCampoVazio()
        {
            for (int i = 0; i < equip.Length; i++)
            {
                if (equip[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }

        private static Equipamentos Create()
        {
            string nome;
            double preco;
            int numeroSerie;
            DateTime dataFabricacao;
            string fabricante;

            while (true)
            {
                Console.WriteLine("Insira o nome:");
                nome = Console.ReadLine();

                if (nome.Length < 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O nome precisa ter no mínimo 6 letras");
                    Console.ResetColor(); Console.ReadLine(); Console.Clear();
                    continue;
                }
                break;
            }
            while (true)
            {
                Console.WriteLine("\nInsira o preco:");
                if (double.TryParse(Console.ReadLine(), out preco)) { break; }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInsira um preço válido, utilizando números (0-9)");
                    Console.ResetColor();
                }
            }
            while (true)
            {
                Console.WriteLine("\nInsira o nº de série:");
                if (int.TryParse(Console.ReadLine(), out numeroSerie)) { break; }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInsira um Nº de série válido, utilizando números (0-9)");
                    Console.ResetColor();
                }
            }
            while (true)
            {
                Console.WriteLine("\nInsira a data de fabricação (DD/MM/AAAA):");
                if (DateTime.TryParse(Console.ReadLine(), out dataFabricacao) && dataFabricacao < DateTime.Now) { break; }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInsira uma data válida, utilizando o modelo (DD/MM/AAAA)");
                    Console.ResetColor();
                }

            }

            Console.WriteLine("\nInsira o fabricante:");
            fabricante = Console.ReadLine();

            Console.Clear();

            Equipamentos adicionarEquip = new Equipamentos(nome, preco, numeroSerie, dataFabricacao, fabricante);

            espacoEquip++;

            return adicionarEquip;
        }

        private void Read(Object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                    Console.WriteLine("ID: " + i + " " + array[i]);
            }
            Console.ReadLine();
            Console.Clear();
        }

        private static int Update()
        {
            int id = 0;
            for (int i = 0; i < equip.Length; i++)
            {
                if (equip[i] != null)
                    Console.WriteLine("ID: " + i + " " + equip[i]);
            }
            Console.WriteLine("\nInsira o ID do equipamento que deseja atualizar:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return id;
        }


    }
}
