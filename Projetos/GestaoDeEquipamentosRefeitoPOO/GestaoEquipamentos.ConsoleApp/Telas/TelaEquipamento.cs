using System;
using GestaoEquipamentos.ConsoleApp.Controladores;
using GestaoEquipamentos.ConsoleApp.Dominio;

namespace GestaoEquipamentos.ConsoleApp.Telas
{
    /// <summary>
    /// encarregada pela interação com usuário 
    /// (inputs, mensagens na tela)
    /// 
    /// VIEW == VISUALIZAÇÃO
    /// </summary>
    public class TelaEquipamento : TelaBase
    {
        private string tituloEquip = "Gestão de Equipamentos\n";

        public override string Titulo
        {
            get => tituloEquip;

        }

        private ControladorEquipamento controladorEquipamento;

        public TelaEquipamento(ControladorEquipamento controlador)
        {
            controladorEquipamento = controlador;
        }

        public override void Registrar(int id)
        {
            Console.Clear();

            string resultadoValidacao = "";

            do
            {
                Console.Write("Digite o nome do equipamento: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o preço do equipamento: ");
                double preco = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o número do equipamento: ");
                string numeroSerie = Console.ReadLine();

                Console.Write("Digite a data de fabricação do equipamento: ");
                DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Digite o fabricante do equipamento: ");
                string fabricante = Console.ReadLine();

                resultadoValidacao = controladorEquipamento.Registrar(
                    id, nome, preco, numeroSerie, dataFabricacao, fabricante);

                if (resultadoValidacao != "EQUIPAMENTO_VALIDO")
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

            } while (resultadoValidacao != "EQUIPAMENTO_VALIDO");
        }

        public override void Visualizar()
        {
            Console.Clear();

            string configuracaColunasTabela = "{0,-10} | {1,-55} | {2,-35}";

            MontarCabecalhoTabela(configuracaColunasTabela);

            Equipamento[] equipamentos = (Equipamento[])controladorEquipamento.SelecionarTudo();

            for (int i = 0; i < equipamentos.Length; i++)
            {
                Console.Write(configuracaColunasTabela,
                   equipamentos[i].id, equipamentos[i].nome, equipamentos[i].fabricante);

                Console.WriteLine();
            }

            if (equipamentos.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Nenhum equipmaneto cadastrado!");
                Console.ResetColor();
            }

            Console.ReadLine();
        }

        public override void Editar()
        {
            Console.Clear();

            Visualizar();

            Console.WriteLine();

            Console.Write("Digite o número do equipamento que deseja editar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Registrar(idSelecionado);
        }

        public override void Excluir()
        {
            Console.Clear();

            Visualizar();

            Console.WriteLine();

            Console.Write("Digite o número do equipamento que deseja excluir: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = controladorEquipamento.Excluir(idSelecionado);

            if (conseguiuExcluir)
            {
                Console.WriteLine("Registro excluído com sucesso");
                Console.ReadLine();
            }
        }

        public override string ObterOpcaoControle()
        {
            Console.WriteLine("Digite 1 para inserir novo equipamento");
            Console.WriteLine("Digite 2 para visualizar equipamentos");
            Console.WriteLine("Digite 3 para editar um equipamento");
            Console.WriteLine("Digite 4 para excluir um equipamento");

            Console.WriteLine("Digite S para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        private void MontarCabecalhoTabela(string configuracaoColunasTabela)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(configuracaoColunasTabela, "Id", "Nome", "Fabricante");

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            Console.ResetColor();
        }
    }

}
