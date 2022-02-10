using ClubeDaLeitura.ConsoleApp.Controladores;
using ClubeDaLeitura.ConsoleApp.Domínios;
using System;

namespace ClubeDaLeitura.ConsoleApp.Telas
{
    class TelaCaixa : TelaBase
    {
        private ControladorCaixa controladorCaixa;

        public TelaCaixa(ControladorCaixa controlador)
        {
            controladorCaixa = controlador;
        }

        public override void Registrar(int id)
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Digite a cor da caixa: ");
                string cor = Console.ReadLine();

                Console.Write("Digite a etiqueta da caixa: ");
                string etiqueta = Console.ReadLine();
                if (!string.IsNullOrEmpty(etiqueta) && !string.IsNullOrEmpty(etiqueta))
                {
                    Caixa caixa = new Caixa(cor, etiqueta);
                    controladorCaixa.Registrar(id, caixa);
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\nCredenciais Incorretas"); Console.ResetColor();
                    Console.ReadLine();
                    continue;
                }
            }

        }

        public override void Visualizar()
        {
            Console.Clear();

            string configuracaColunasTabela = "{0,-33} | {1,-33} | {2,-33}";

            MontarCabecalhoTabela(configuracaColunasTabela);

            Caixa[] caixas = new Caixa[controladorCaixa.SelecionarTudo().Length];
            Array.Copy(controladorCaixa.SelecionarTudo(), caixas, controladorCaixa.SelecionarTudo().Length);


            for (int i = 0; i < caixas.Length; i++)
            {
                Console.Write(configuracaColunasTabela,
                   caixas[i].Id, caixas[i].cor, caixas[i].etiqueta);

                Console.WriteLine();
            }

            if (caixas.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Nenhuma caixa cadastrada!");
                Console.ResetColor();
            }

            Console.ReadLine();
        }

        public override void Editar()
        {
            Console.Clear();

            Visualizar();

            Console.WriteLine();

            Console.Write("Digite o número da caixa que deseja editar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Registrar(idSelecionado);
        }

        public override void Excluir()
        {
            Console.Clear();

            Visualizar();

            Console.WriteLine();

            Console.Write("Digite o número da caixa que deseja excluir: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = controladorCaixa.Excluir(idSelecionado);

            if (conseguiuExcluir)
            {
                Console.WriteLine("\nRegistro excluído com sucesso");
                Console.ReadLine();
            }
        }

        public override string ObterOpcao()
        {
            Console.WriteLine("Cadastro de Caixas\n");
            Console.WriteLine("Digite 1 para inserir uma nova caixa");
            Console.WriteLine("Digite 2 para visualizar as caixas");
            Console.WriteLine("Digite 3 para editar uma caixa");
            Console.WriteLine("Digite 4 para excluir uma caixa");

            Console.WriteLine("Digite S para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        private void MontarCabecalhoTabela(string configuracaColunasTabela)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(configuracaColunasTabela, "Número", "Cor", "Etiqueta");

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.ResetColor();
        }
    }
}
