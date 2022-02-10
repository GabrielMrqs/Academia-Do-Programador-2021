using System;
using GestaoEquipamentos.ConsoleApp.Controladores;
using GestaoEquipamentos.ConsoleApp.Dominio;

namespace GestaoEquipamentos.ConsoleApp
{
    public class TelaSolicitante : TelaBase
    {
        private string tituloSol = "Gestão de Solicitantes\n";

        public override string Titulo
        {
            get => tituloSol;

        }

        private ControladorSolicitante controladorSolicitante;

        public TelaSolicitante(ControladorSolicitante controlador)
        {
            controladorSolicitante = controlador;
        }

        public override void Registrar(int id)
        {
            Console.Clear();

            string resultadoValidacao = "";

            do
            {
                Console.Write("Digite o nome do solicitante: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o email do solicitante: ");
                string email =Console.ReadLine();

                Console.Write("Digite o número de telefone do solicitante: ");
                long numeroTelefone = Convert.ToInt64(Console.ReadLine());

                resultadoValidacao = controladorSolicitante.Registrar(
                    id, nome, email, numeroTelefone);

                if (resultadoValidacao != "SOLICITANTE_VALIDO")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(resultadoValidacao);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Registro gravado com sucesso!");
                }

                Console.ReadLine();
                Console.Clear();
                Console.ResetColor();

            } while (resultadoValidacao != "SOLICITANTE_VALIDO");
        }

        public override void Visualizar()
        {
            Console.Clear();

            string configuracaColunasTabela = "{0,-10} | {1,-55} | {2,-35} | {3,-25}";

            MontarCabecalhoTabela(configuracaColunasTabela);

            Solicitante[] solicitantes = (Solicitante[])controladorSolicitante.SelecionarTudo();

            for (int i = 0; i < solicitantes.Length; i++)
            {
                Console.Write(configuracaColunasTabela,
                   solicitantes[i].id, solicitantes[i].nome, solicitantes[i].email, solicitantes[i].numTelefone);

                Console.WriteLine();
            }

            if (solicitantes.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Nenhum solicitante cadastrado!");
                Console.ResetColor();
            }

            Console.ReadLine();
        }

        public override void Editar()
        {
            Console.Clear();

            Visualizar();

            Console.WriteLine();

            Console.Write("Digite o número do solicitante que deseja editar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Registrar(idSelecionado);
        }

        public override void Excluir()
        {
            Console.Clear();

            Visualizar();

            Console.WriteLine();

            Console.Write("Digite o número do solicitante que deseja excluir: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = controladorSolicitante.Excluir(idSelecionado);

            if (conseguiuExcluir)
            {
                Console.WriteLine("Registro excluído com sucesso");
                Console.ReadLine();
            }
        }

        public override string ObterOpcaoControle()
        {
            Console.WriteLine("Digite 1 para inserir novo solicitante");
            Console.WriteLine("Digite 2 para visualizar solicitante");
            Console.WriteLine("Digite 3 para editar um solicitante");
            Console.WriteLine("Digite 4 para excluir um solicitante");

            Console.WriteLine("Digite S para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        private void MontarCabecalhoTabela(string configuracaoColunasTabela)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(configuracaoColunasTabela, "Id", "Nome", "E-mail", "Nº de Telefone");

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            Console.ResetColor();
        }
    }
}