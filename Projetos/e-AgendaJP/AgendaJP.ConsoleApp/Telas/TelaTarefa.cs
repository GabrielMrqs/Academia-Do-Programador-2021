using AgendaJP.Controladores.Model;
using AgendaJP.Dominios.Model;
using System;

namespace AgendaJP.ConsoleApp.Telas
{
    public class TelaTarefa : TelaBase<Tarefa>
    {
        private ControladorTarefa controlador;
        public TelaTarefa(ControladorTarefa controlador) : base(controlador)
        {
            this.controlador = controlador;
            Menu();
        }

        public override void VisualizarRegistro()
        {
            Console.Clear();
            Console.WriteLine("Insira 1 para Visualizar Tarefas Pendentes");
            Console.WriteLine("Insira 2 para Visualizar Tarefas Concluídas");
            switch (Console.ReadLine())
            {
                case "1": VisualizarTarefasPendentes(); break;
                case "2": VisualizarTarefasFinalizadas(); break;
                default: MensagemErro(); break;
            }
        }
        public override Tarefa ObterRegistro()
        {
            Console.Clear();
            Console.Write("Insira o Título da Tarefa: ");
            string titulo = Console.ReadLine();
            Console.Write("Insira a Prioridade da Tarefa ( 1-ALTA | 2-MEDIA | 3-BAIXA ): ");
            string numPrioridade = Console.ReadLine();
            Console.Write("Insira a Data de Início da Tarefa: ");
            DateTime dataCriacao = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Insira a Data de Conclusão estimada da Tarefa: ");
            DateTime dataConclusao = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Insira o Percentual da Tarefa: ");
            double percentual = Convert.ToDouble(Console.ReadLine());

            Tarefa tarefa = new Tarefa(numPrioridade, titulo, dataCriacao, dataConclusao, percentual);

            return ValidarRegistro(tarefa);
        }
        public override Tarefa ObterTarefaEditar()
        {
            Console.Clear();
            Console.Write("Insira o Título da Tarefa: ");
            string titulo = Console.ReadLine();
            Console.Write("Insira a Prioridade da Tarefa ( 1-ALTA | 2-MEDIA | 3-BAIXA ): ");
            string numPrioridade = Console.ReadLine();
            DateTime dataCriacao = DateTime.Now;
            Console.Write("Insira a Data de Conclusão estimada da Tarefa: ");
            DateTime dataConclusao = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Insira o Percentual da Tarefa: ");
            double percentual = Convert.ToDouble(Console.ReadLine());

            Tarefa tarefa = new Tarefa(numPrioridade, titulo, dataCriacao, dataConclusao, percentual);

            return ValidarRegistro(tarefa);
        }
        public override Tarefa ValidarRegistro(Tarefa tarefa)
        {
            if (tarefa.Validar() == "")
                return tarefa;
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDados incorretos, tente novamente!");
                Console.ResetColor();
                Console.ReadLine();
                return ObterRegistro();
            }
        }
        private void VisualizarTarefasFinalizadas()
        {
            Console.Clear();
            if (controlador.VisualizarTarefasFinalizadas().Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa finalizada por enquanto!");
                Console.ReadLine();
                return;
            }
            controlador.VisualizarTarefasFinalizadas().ForEach(x => Console.WriteLine(x));
            Console.ReadLine();
        }
        private void VisualizarTarefasPendentes()
        {
            Console.Clear();
            if (controlador.VisualizarTarefasPendentes().Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa pendente por enquanto!");
                Console.ReadLine();
                return;
            }
            controlador.VisualizarTarefasPendentes().ForEach(x => Console.WriteLine(x));
            Console.ReadLine();
        }
    }
}
