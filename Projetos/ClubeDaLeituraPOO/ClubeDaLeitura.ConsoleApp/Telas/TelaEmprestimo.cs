using ClubeDaLeitura.ConsoleApp.Controladores;
using ClubeDaLeitura.ConsoleApp.Domínios;
using System;

namespace ClubeDaLeitura.ConsoleApp.Telas
{
    class TelaEmprestimo : TelaBase
    {
        private ControladorRevista controladorRevista;
        private ControladorAmiguinho controladorAmiguinho;
        private ControladorEmprestimo controladorEmprestimo;
        private TelaAmiguinho telaAmiguinho;
        private TelaRevista telaRevista;

        public TelaEmprestimo(ControladorRevista controladorRevista, ControladorAmiguinho controladorAmiguinho, ControladorEmprestimo controladorEmprestimo, ControladorCaixa controladorCaixa)
        {
            this.controladorRevista = controladorRevista;
            this.controladorAmiguinho = controladorAmiguinho;
            this.controladorEmprestimo = controladorEmprestimo;
            telaAmiguinho = new TelaAmiguinho(controladorAmiguinho);
            telaRevista = new TelaRevista(controladorRevista, controladorCaixa);
        }

        public override void Editar() { }

        public override void Excluir()
        {
            Console.Clear();

            Visualizar();

            Console.WriteLine();

            Console.Write("Digite o número do empréstimo que deseja devolver: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = controladorEmprestimo.Excluir(idSelecionado);

            if (conseguiuExcluir)
            {
                Console.WriteLine("\nDevolução realizada com sucesso");
                Console.ReadLine();
            }
        }

        public override string ObterOpcao()
        {
            Console.WriteLine("Controle de Empréstimos\n");
            Console.WriteLine("Digite 1 para realizar um novo empréstimo");
            Console.WriteLine("Digite 2 para visualizar os empréstimos de hoje");
            Console.WriteLine("Digite 3 para visualizar um empréstimo de algum mês");
            Console.WriteLine("Digite 4 para devolver um empréstimo");

            Console.WriteLine("Digite S para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        public override void Registrar(int id)
        {
            if (controladorAmiguinho.SelecionarTudo().Length > 0 && controladorRevista.SelecionarTudo().Length > 0)
            {
                Console.Clear();

                telaAmiguinho.Visualizar();

                Console.Write("Digite o ID do amiguinho: ");
                int idAmiguinho = Convert.ToInt32(Console.ReadLine());

                telaRevista.Visualizar();

                Console.Write("Digite o ID da revista: ");
                int idRevista = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a data de retirada: ");
                DateTime dataRetirada = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Digite a data de devolução: ");
                DateTime dataDevolucao = Convert.ToDateTime(Console.ReadLine());

                Amiguinho amiguinho = (Amiguinho)controladorAmiguinho.SelecionarPorId(idAmiguinho);
                Revista revista = (Revista)controladorRevista.SelecionarPorId(idRevista);

                Emprestimo emprestimo = new Emprestimo(amiguinho, revista, dataRetirada, dataDevolucao);

                controladorEmprestimo.Registrar(id, emprestimo);
            }
            else { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Registre pelo menos um amiguinho e uma revista"); Console.ReadLine(); Console.ResetColor(); }
        }

        public override void Visualizar()
        {
            Console.Clear();

            string configuracaColunasTabela = "{0,-20} | {1,-20} | {2,-20} | {3,-20} | {4,-20}";

            MontarCabecalhoTabela(configuracaColunasTabela);

            Emprestimo[] emprestimos = new Emprestimo[controladorEmprestimo.SelecionarTudo().Length];
            Array.Copy(controladorEmprestimo.SelecionarTudo(), emprestimos, controladorEmprestimo.SelecionarTudo().Length);

            for (int i = 0; i < emprestimos.Length; i++)
            {
                Console.Write(configuracaColunasTabela,
                   emprestimos[i].Id, emprestimos[i].Amiguinho.nome, emprestimos[i].Revista.NomeRevista,
                   emprestimos[i].DataEmprestimo.ToString("dd/MM/yyyy"), emprestimos[i].DataDevolucao.ToString("dd/MM/yyyy"));

                Console.WriteLine();
            }

            if (emprestimos.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Nenhum empréstimo cadastrado!");
                Console.ResetColor();
            }

            Console.ReadLine();
        }

        public override void Menu()
        {
            Console.Clear();

            string opcao = ObterOpcao();

            if (opcao == "1")
                Registrar(0);

            if (opcao == "2")
                VisualizarPorData(DateTime.Today);

            if (opcao == "3")
                VisualizarPorData(SelecionarData());

            if (opcao == "4")
                Excluir();

            if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))

                Console.Clear();
        }

        private DateTime SelecionarData()
        {
            Console.Clear();

            Console.WriteLine("Insira uma data para consulta:");
            DateTime data = Convert.ToDateTime(Console.ReadLine());
            return data;
        }

        private void MontarCabecalhoTabela(string configuracaColunasTabela)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(configuracaColunasTabela, "ID", "Amiguinho", "Revista", "Data Empréstimo", "Data Devolução");

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.ResetColor();
        }

        private void VisualizarPorData(DateTime data)
        {
            string configuracaColunasTabela = "{0,-20} | {1,-20} | {2,-20} | {3,-20} | {4,-20}";

            MontarCabecalhoTabela(configuracaColunasTabela);

            Emprestimo[] emprestimoConsulta = new Emprestimo[0];

            foreach (Emprestimo emprestimo in controladorEmprestimo.SelecionarTudo())
            {
                if (data.Month == emprestimo.DataEmprestimo.Month && data.Year == emprestimo.DataEmprestimo.Year)
                {
                    Array.Resize(ref emprestimoConsulta, emprestimoConsulta.Length + 1);
                    emprestimoConsulta[emprestimoConsulta.Length - 1] = emprestimo;
                }
            }

            for (int i = 0; i < emprestimoConsulta.Length; i++)
            {

                Console.Write(configuracaColunasTabela,
                   emprestimoConsulta[i].Id, emprestimoConsulta[i].Amiguinho.nome, emprestimoConsulta[i].Revista.NomeRevista,
                   emprestimoConsulta[i].DataEmprestimo.ToString("dd/MM/yyyy"), emprestimoConsulta[i].DataDevolucao.ToString("dd/MM/yyyy"));

                Console.WriteLine();
            }

            if (emprestimoConsulta.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Nenhum empréstimo cadastrado!");
                Console.ResetColor();
            }

            Console.ReadLine();
        }
    }
}
