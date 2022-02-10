using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEquipamentos.ConsoleApp
{
    class Chamados
    {
        private string titulo;
        private string descricao;
        private Equipamentos equipamento;
        private DateTime dataAbertura;
        public static Chamados[] chamado = new Chamados[10];
        static int espacoChamado = 0;

        public Chamados()
        {

        }

        public Chamados(string titulo, string descricao, Equipamentos equipamento, DateTime dataAbertura)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.equipamento = equipamento;
            this.dataAbertura = dataAbertura;
        }

        public override string ToString()
        {
            return "| Título: " + titulo + " | Equipamento: " + equipamento.Nome + " | Data de Abertura: " + FormatarData(dataAbertura) + " | Dias em Aberto: " + ContarDiasEmAberto(dataAbertura) + " |";
        }

        public void RealizarExlusaoChamados()
        {
            if (chamado[0] == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhum chamado cadastrado");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                int id = 0;
                for (int i = 0; i < chamado.Length; i++)
                {
                    if (chamado[i] != null)
                        Console.WriteLine("ID: " + i + " " + chamado[i]);
                }
                Console.WriteLine("\nInsira o ID do chamado que deseja apagar:");
                id = Convert.ToInt32(Console.ReadLine());

                chamado[id] = null;
                Console.Clear();
            }

        }

        public void RealizarCadastroChamados()
        {
            int o = EncontrarCampoVazio(); chamado[o] = Create();
        }

        public void VisualizarChamadosCadastrados()
        {
            if (chamado[0] == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhum chamado cadastrado");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Read(chamado);
            }

        }

        public void RealizarEdicaoChamados()
        {
            if (chamado[0] == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhum chamado cadastrado");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                int id = Update(); chamado[id] = Create();
            }

        }

        private static Chamados Create()
        {
            string titulo;
            string descricao;
            DateTime data_abertura;
            int equipNum;


            Console.WriteLine("Insira o título do chamado:");
            titulo = Console.ReadLine();
            Console.WriteLine("\nInsira a descrição do chamado:");
            descricao = Console.ReadLine();
            Console.WriteLine();
            for (int i = 0; i < Equipamentos.equip.Length; i++)
            {
                if (Equipamentos.equip[i] != null)
                    Console.WriteLine("ID: " + i + " " + Equipamentos.equip[i]);
            }
            while (true)
            {
                Console.WriteLine("\nInsira o ID do equipamento:");
                if (int.TryParse(Console.ReadLine(), out equipNum)) { break; }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInsira um ID válido, utilizando números (0-9)");
                    Console.ResetColor();
                }
            }

            data_abertura = DateTime.Now;

            Console.Clear();

            Chamados adicionarChamado = new Chamados(titulo, descricao, Equipamentos.equip[equipNum], data_abertura);

            espacoChamado++;

            return adicionarChamado;

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
            for (int i = 0; i < chamado.Length; i++)
            {
                if (chamado[i] != null)
                    Console.WriteLine("ID: " + i + " " + chamado[i]);
            }
            Console.WriteLine("\nInsira o ID do chamado que deseja atualizar:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return id;
        }

        private static int EncontrarCampoVazio()
        {
            for (int i = 0; i < chamado.Length; i++)
            {
                if (chamado[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }

        private static string FormatarData(DateTime data)
        {
            return data.Day + "/" + data.Month + "/" + data.Year;
        }

        private int ContarDiasEmAberto(DateTime data)
        {
            TimeSpan difereca = DateTime.Now.Subtract(data);
            return Convert.ToInt32(difereca.TotalDays);
        }
    }
}
