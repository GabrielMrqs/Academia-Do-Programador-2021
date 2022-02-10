using System;
using GestaoEquipamentos.ConsoleApp.Controladores;
using GestaoEquipamentos.ConsoleApp.Dominio;

namespace GestaoEquipamentos.ConsoleApp.Telas
{
    public class TelaChamado : TelaBase
    {
        private string tituloChamado = "Gestão de Chamados\n";

        public override string Titulo
        {
            get => tituloChamado;

        }

        private ControladorChamado controladorChamado;
        private TelaEquipamento telaEquipamento;
        private TelaSolicitante telaSolicitante;

        public TelaChamado(ControladorChamado controladorCham, TelaSolicitante telaSolicitante, TelaEquipamento telaEquipamento)
        {
            this.telaSolicitante = telaSolicitante;
            this.telaEquipamento = telaEquipamento;
            controladorChamado = controladorCham;
        }

        public override void Registrar(int idChamadoSelecionado)
        {
            Console.Clear();

            string resultadoValidacao = "";

            telaEquipamento.Visualizar();
            do
            {
                Console.Write("Digite o Id do equipamento para manutenção: ");
                int idEquipamentoChamado = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                telaSolicitante.Visualizar();

                Console.Write("Digite o Id do solicitante para manutenção: ");
                int idSolicitanteChamado = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.Write("Digite o titulo do chamado: ");
                string titulo = Console.ReadLine();

                Console.Write("Digite a descricao do chamado: ");
                string descricao = Console.ReadLine();

                Console.Write("Digite a data de abertura do chamado: ");
                DateTime dataAbertura = Convert.ToDateTime(Console.ReadLine());


                resultadoValidacao = controladorChamado.Registrar(idChamadoSelecionado, idEquipamentoChamado, titulo, descricao, dataAbertura, idSolicitanteChamado);

                if (resultadoValidacao != "CHAMADO_VALIDO")
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

            } while (resultadoValidacao != "CHAMADO_VALIDO");
        }

        public override void Visualizar()
        {
            Console.Clear();

            MontarCabecalhoTabela();

            Chamado[] chamados = controladorChamado.SelecionarTodosChamados();

            foreach (Chamado chamado in chamados)
            {
                Console.WriteLine("{0,-5} | {1,-20} | {2,-20} | {3,-20} | {4,-10}",
                    chamado.id, chamado.solicitante.nome, chamado.equipamento.nome, chamado.titulo, chamado.DiasEmAberto);
            }

            if (chamados.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Nenhum chamado registrado!");
                Console.ResetColor();
            }

            Console.ReadLine();
        }

        public override void Editar()
        {
            Console.Clear();

            Visualizar();

            Console.WriteLine();

            Console.Write("Digite o número do chamado que deseja editar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Registrar(idSelecionado);
        }

        public override void Excluir()
        {
            Console.Clear();

            Visualizar();

            Console.WriteLine();

            Console.Write("Digite o número do chamado que deseja excluir: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = controladorChamado.Excluir(idSelecionado);

            if (conseguiuExcluir)
            {
                Console.WriteLine("Registro excluído com sucesso");
                Console.ReadLine();
            }
        }

        public override string ObterOpcaoControle()
        {
            Console.WriteLine("Digite 1 para inserir novo chamado");
            Console.WriteLine("Digite 2 para visualizar chamados");
            Console.WriteLine("Digite 3 para editar um chamado");
            Console.WriteLine("Digite 4 para excluir um chamado");

            Console.WriteLine("Digite S para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        private void MontarCabecalhoTabela()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("{0,-5} | {1,-20} | {2,-20} | {3,-20} | {4,-10}", "Id", "Solicitante", "Equipamento", "Título", "Dias em Aberto");

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            Console.ResetColor();
        }




    }
}
