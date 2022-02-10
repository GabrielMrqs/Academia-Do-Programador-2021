using ClubeDaLeitura.ConsoleApp.Controladores;
using ClubeDaLeitura.ConsoleApp.Domínios;
using System;

namespace ClubeDaLeitura.ConsoleApp.Telas
{
    class TelaRevista : TelaBase
    {
        private ControladorRevista controladorRevista;
        private ControladorCaixa controladorCaixa;
        private TelaCaixa telaCaixa;

        public TelaRevista(ControladorRevista controladorRevista, ControladorCaixa controladorCaixa)
        {
            this.controladorRevista = controladorRevista;
            this.controladorCaixa = controladorCaixa;
            telaCaixa = new TelaCaixa(controladorCaixa);
        }

        public override void Registrar(int id)
        {
            if (controladorCaixa.SelecionarTudo().Length > 0)
            {
                Console.Clear();

                Console.Write("Digite o nome da revista: ");
                string nomeRevista = Console.ReadLine();

                Console.Write("Digite o nº da edição: ");
                int numeroEdicao = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o ano da revista: ");
                int ano = Convert.ToInt32(Console.ReadLine());

                telaCaixa.Visualizar();

                Console.Write("Digite o nº da caixa onde está guardada a revista: ");
                int nCaixa = Convert.ToInt32(Console.ReadLine());

                Caixa caixa = (Caixa)controladorCaixa.SelecionarPorId(nCaixa);

                Revista revista = new Revista(nomeRevista, numeroEdicao, ano, caixa);

                controladorRevista.Registrar(id, revista);
            }
            else { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Nenhua caixa registrada"); Console.ReadLine(); Console.ResetColor(); }

        }

        public override void Visualizar()
        {
            Console.Clear();

            string configuracaColunasTabela = "{0,-20} | {1,-20} | {2,-20} | {3,-20} | {4,-20}";

            MontarCabecalhoTabela(configuracaColunasTabela);

            Revista[] revistas = new Revista[controladorRevista.SelecionarTudo().Length];
            Array.Copy(controladorRevista.SelecionarTudo(), revistas, controladorRevista.SelecionarTudo().Length);

            for (int i = 0; i < revistas.Length; i++)
            {
                Console.Write(configuracaColunasTabela,
                   revistas[i].Id, revistas[i].NomeRevista, revistas[i].NumeroEdicao, revistas[i].Ano, revistas[i].Caixa.Id);

                Console.WriteLine();
            }

            if (revistas.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Nenhuma revista cadastrada!");
                Console.ResetColor();
            }

            Console.ReadLine();
        }

        public override void Editar()
        {
            Console.Clear();

            Visualizar();

            Console.WriteLine();

            Console.Write("Digite o número da revista que deseja editar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Registrar(idSelecionado);
        }

        public override void Excluir()
        {
            Console.Clear();

            Visualizar();

            Console.WriteLine();

            Console.Write("Digite o número da revista que deseja excluir: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = controladorRevista.Excluir(idSelecionado);

            if (conseguiuExcluir)
            {
                Console.WriteLine("\nRegistro excluído com sucesso");
                Console.ReadLine();
            }
        }

        public override string ObterOpcao()
        {
            Console.WriteLine("Cadastro de Revistas\n");
            Console.WriteLine("Digite 1 para inserir uma nova revista");
            Console.WriteLine("Digite 2 para visualizar as revistas");
            Console.WriteLine("Digite 3 para editar uma revista");
            Console.WriteLine("Digite 4 para excluir uma revista");

            Console.WriteLine("Digite S para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        private void MontarCabecalhoTabela(string configuracaColunasTabela)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(configuracaColunasTabela, "ID", "Nome", "Número", "Ano", "Caixa");

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.ResetColor();
        }

    }
}

