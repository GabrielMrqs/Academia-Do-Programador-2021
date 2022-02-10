using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEquipamentos.ConsoleApp
{
    class GestaoDeEquipamentos
    {
        static Equipamentos equipamentos = new Equipamentos();
        static Chamados chamados = new Chamados();
        static void Main(string[] args)
        {

            while (true)
            {
                int opcao = MostrarMenu();

                if (opcao == 1)
                {
                    Equipamentos();
                }
                else if (opcao == 2)
                {
                    Chamados();
                }
                else if (opcao == 3)
                    break;

            }
        }

        private static void Chamados()
        {
            int comando = MostrarMenuChamados();
            switch (comando)
            {
                case 1: chamados.RealizarCadastroChamados(); break;
                case 2: chamados.VisualizarChamadosCadastrados(); break;
                case 3: chamados.RealizarEdicaoChamados(); break;
                case 4: chamados.RealizarExlusaoChamados(); break;
                case 5: break;
                default: break;
            }
        }

        private static void Equipamentos()
        {
            int comando = MostrarMenuEquipamentos();
            switch (comando)
            {
                case 1: equipamentos.RealizarCadastroEquipamentos(); break;
                case 2: equipamentos.VisualizarEquipamentosCadastrados(); break;
                case 3: equipamentos.RealizarEdicaoEquipamentos(); break;
                case 4: equipamentos.RealizarExlusaoEquipamentos(); break;
                case 5: break;
                default: break;
            }
        }

        private static int MostrarMenuChamados()
        {
            Console.WriteLine("Insira 1 para adicionar chamado");
            Console.WriteLine("Insira 2 para visualizar chamados");
            Console.WriteLine("Insira 3 para atualizar chamados");
            Console.WriteLine("Insira 4 para apagar chamados");
            Console.WriteLine("Insira 5 para voltar\n");
            int comando = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return comando;
        }

        private static int MostrarMenuEquipamentos()
        {
            Console.WriteLine("Insira 1 para adicionar equipamento");
            Console.WriteLine("Insira 2 para visualizar equipamentos");
            Console.WriteLine("Insira 3 para atualizar equipamentos");
            Console.WriteLine("Insira 4 para apagar equipamentos");
            Console.WriteLine("Insira 5 para voltar\n");
            int comando = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return comando;
        }

        private static int MostrarMenu()
        {
            Console.WriteLine("Gestão de Equipamentos e Chamados");
            Console.WriteLine("\nInsira 1 para equipamentos"); Console.ResetColor();
            Console.WriteLine("Insira 2 para chamados"); Console.ResetColor();
            Console.WriteLine("Insira 3 para sair\n"); Console.ResetColor();
            int opcao = 0;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out opcao)) { break; }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Insira um comando válido");
                    Console.ResetColor();
                }
            }
            Console.Clear();
            return opcao;
        }

    }
}
