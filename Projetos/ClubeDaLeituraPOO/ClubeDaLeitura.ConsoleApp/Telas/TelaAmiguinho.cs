using ClubeDaLeitura.ConsoleApp.Controladores;
using ClubeDaLeitura.ConsoleApp.Domínios;
using System;

namespace ClubeDaLeitura.ConsoleApp.Telas
{
    class TelaAmiguinho : TelaBase
    {
        private ControladorAmiguinho controladorAmiguinho;

        public TelaAmiguinho(ControladorAmiguinho controlador)
        {
            controladorAmiguinho = controlador;
        }

        public override void Registrar(int id)
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Digite o nome do amiguinho: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o nome do responsável pelo amiguinho: ");
                string nomeResponsavel = Console.ReadLine();

                Console.Write("Digite o nº de telefone do amiguinho: ");
                string numero = Console.ReadLine();

                Console.Write("Digite o bairro onde o amiguinho mora: ");
                string localizacao = Console.ReadLine();

                if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(nomeResponsavel) && !string.IsNullOrEmpty(numero) && !string.IsNullOrEmpty(localizacao))
                {
                    Amiguinho amiguinho = new Amiguinho(nome, nomeResponsavel, numero, localizacao);
                    controladorAmiguinho.Registrar(id, amiguinho);
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

            string configuracaColunasTabela = "{0,-20} | {1,-20} | {2,-20} | {3,-20} | {4,-20}";

            MontarCabecalhoTabela(configuracaColunasTabela);

            Amiguinho[] amiguinhos = new Amiguinho[controladorAmiguinho.SelecionarTudo().Length];
            Array.Copy(controladorAmiguinho.SelecionarTudo(), amiguinhos, controladorAmiguinho.SelecionarTudo().Length);

            for (int i = 0; i < amiguinhos.Length; i++)
            {
                Console.Write(configuracaColunasTabela,
                   amiguinhos[i].Id, amiguinhos[i].nome, amiguinhos[i].nomeResponsavel,
                   amiguinhos[i].numero, amiguinhos[i].localizacao);

                Console.WriteLine();
            }

            if (amiguinhos.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Nenhum amiguinho cadastrado!");
                Console.ResetColor();
            }

            Console.ReadLine();
        }

        public override void Editar()
        {
            Console.Clear();

            Visualizar();

            Console.WriteLine();

            Console.Write("Digite o número do amiguinho que deseja editar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Registrar(idSelecionado);
        }

        public override void Excluir()
        {
            Console.Clear();

            Visualizar();

            Console.WriteLine();

            Console.Write("Digite o ID do amiguinho que deseja excluir: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = controladorAmiguinho.Excluir(idSelecionado);

            if (conseguiuExcluir)
            {
                Console.WriteLine("\nRegistro excluído com sucesso");
                Console.ReadLine();
            }
        }

        public override string ObterOpcao()
        {
            Console.WriteLine("Cadastro de Amiguinhos\n");
            Console.WriteLine("Digite 1 para inserir um novo amiguinho");
            Console.WriteLine("Digite 2 para visualizar os amiguinhos");
            Console.WriteLine("Digite 3 para editar um amiguinho");
            Console.WriteLine("Digite 4 para excluir um amiguinho");

            Console.WriteLine("Digite S para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        private void MontarCabecalhoTabela(string configuracaColunasTabela)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(configuracaColunasTabela, "ID", "Nome Amiguinho", "Nome Responsável", "Bairro", "Telefone");

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.ResetColor();
        }
    }
}
