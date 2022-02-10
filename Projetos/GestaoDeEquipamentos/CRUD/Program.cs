using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Program
    {

        static Equipamentos[] equip = new Equipamentos[10];
        static Chamados[] chamado = new Chamados[10];
        static int espacoEquip = 0;
        static int espacoChamado = 0;


        static void Main(string[] args)
        {
            Console.WriteLine("Gestão de Equipamentos e Chamados");
            int opcao = 0;

            while (true)
            {
                opcao = menu();

                if (opcao == 1)
                {
                    int comando = menuEquip();
                    switch (comando)
                    {
                        case 1: int o = encontrarVazio(); equip[o] = cadastroEquip(); break;
                        case 2: mostrarLista(equip); break;
                        case 3: int id = editEquip(); equip[id] = cadastroEquip(); break;
                        case 4: apagarEquip(); break;
                        default:
                            break;
                    }
                }
                else if (opcao == 2)
                {
                    int comando = menuChamado();

                    switch (comando)
                    {
                        case 1: int o = encontrarVazio(); chamado[o] = cadastroChamado(); break;
                        case 2: mostrarLista(chamado); break;
                        case 3: int id = editChamado(); chamado[id] = cadastroChamado(); ; break;
                        case 4: apagarChamado(); break;
                        default:
                            break;
                    }

                }
                else if (opcao == 3)
                {
                    break;
                }
            }

        }

        private static void apagarChamado()
        {
            int id = 0;
            for (int i = 0; i < chamado.Length; i++)
            {
                Console.WriteLine(i + " " + chamado[i]);
            }
            Console.WriteLine("\nInsira o ID do equipamento que deseja apagar:");
            id = Convert.ToInt32(Console.ReadLine());

            chamado[id] = null;
            Console.ReadLine();
            Console.Clear();
        }

        private static void apagarEquip()
        {
            int id = 0;
            for (int i = 0; i < equip.Length; i++)
            {
                Console.WriteLine(i + " " + equip[i]);
            }
            Console.WriteLine("\nInsira o ID do equipamento que deseja apagar:");
            id = Convert.ToInt32(Console.ReadLine());

            equip[id] = null;
            Console.ReadLine();
            Console.Clear();
        }

        private static int editChamado()
        {
            int id = 0;
            for (int i = 0; i < chamado.Length; i++)
            {
                Console.WriteLine(i + " " + chamado[i]);
            }
            Console.WriteLine("\nInsira o ID do equipamento que deseja atualizar:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.Clear();
            return id;
        }

        private static int editEquip()
        {
            int id = 0;
            for (int i = 0; i < equip.Length; i++)
            {
                Console.WriteLine(i + " " + equip[i]);
            }
            Console.WriteLine("\nInsira o ID do equipamento que deseja atualizar:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.Clear();
            return id;
        }

        private static Chamados cadastroChamado()
        {
            string titulo;
            string descricao;
            DateTime data_abertura;

            Console.WriteLine("\nInsira o nome do chamado:");
            titulo = Console.ReadLine();
            Console.WriteLine("\nInsira a descrião do chamado:");
            descricao = Console.ReadLine();
            Console.WriteLine("\nInsira o ID do equipamento:");
            for (int i = 0; i < equip.Length; i++)
            {
                Console.WriteLine(i + " " + equip[i]);
            }
            int equipNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInsira a data de abertura (DD/MM/AAAA):");
            data_abertura = Convert.ToDateTime(Console.ReadLine());
            Console.ReadLine();
            Console.Clear();

            Chamados adicionarChamado = new Chamados(titulo, descricao, equip[equipNum], data_abertura);

            espacoChamado++;

            return adicionarChamado;

        }

        private static Equipamentos cadastroEquip()
        {
            string nome;
            double preco;
            int n_serie;
            DateTime data_fabricacao;
            string fabricante;

            while (true)
            {
                Console.WriteLine("\nInsira o nome:");
                nome = Console.ReadLine();

                if (nome.Length < 6)
                {
                    continue;
                }
                break;
            }
            Console.WriteLine("\nInsira o preco:");
            preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInsira o nº de série:");
            n_serie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInsira a data de fabricação (DD/MM/AAAA):");
            data_fabricacao = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("\nInsira o fabricante:");
            fabricante = Console.ReadLine();
            Console.ReadLine();
            Console.Clear();

            Equipamentos adicionarEquip = new Equipamentos(nome, preco, n_serie, data_fabricacao, fabricante);

            espacoEquip++;

            return adicionarEquip;
        }

        private static int menuChamado()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nInsira 1 para adicionar chamado");
            Console.WriteLine("Insira 2 para visualizar chamados");
            Console.WriteLine("Insira 3 para atualizar chamados");
            Console.WriteLine("Insira 4 para apagar chamados\n");
            Console.ResetColor();
            int comando = Convert.ToInt32(Console.ReadLine());
            return comando;
        }  

        private static int menuEquip()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nInsira 1 para adicionar equipamento");
            Console.WriteLine("Insira 2 para visualizar equipamentos");
            Console.WriteLine("Insira 3 para atualizar equipamentos");
            Console.WriteLine("Insira 4 para apagar equipamentos\n");
            Console.ResetColor();
            int comando = Convert.ToInt32(Console.ReadLine());
            return comando;
        }

        private static int menu()
        {
            int opcao;
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("\nInsira 1 para equipamentos"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Insira 2 para chamados"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Insira 3 para sair\n"); Console.ResetColor();
            opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }

        private static void mostrarLista(Object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("ID: " + i + " " + array[i]);
            }
        }

        private static int encontrarVazio()
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

    }
}

