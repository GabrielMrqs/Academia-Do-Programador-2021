using AgendaJP.Controladores.Model;
using AgendaJP.Dominios.Model;
using System;

namespace AgendaJP.ConsoleApp.Telas
{
    public abstract class TelaBase<T> where T : EntidadeBase
    {
        private Controlador<T> controlador;
        public TelaBase(Controlador<T> controlador)
        {
            this.controlador = controlador;
        }

        public void Menu()
        {
            string opcao = "";
            while (opcao != "S")
            {
                Console.Clear();
                Console.WriteLine("Insira 1 para Inserir novo Registro");
                Console.WriteLine("Insira 2 para Visualizar Registros");
                Console.WriteLine("Insira 3 para Editar Registro");
                Console.WriteLine("Insira 4 para Excluir Registro");
                Console.WriteLine("Insira S para Sair");
                Console.Write("Opção: ");
                opcao = Console.ReadLine().ToUpper();

                switch (opcao)
                {
                    case "1": InserirRegistro(); continue;
                    case "2": VisualizarRegistro(); continue;
                    case "3": EditarRegistro(); continue;
                    case "4": ExcluirRegistro(); continue;
                    case "S": break;
                    default: MensagemErro(); continue;
                }
            }
        }
        public void ExcluirRegistro()
        {
            Console.Clear();

            if (!ValidarVisualizacao())
            {
                Console.WriteLine("Nenhum registro cadastrada por enquanto!");
                Console.ReadLine();
                return;
            }

            controlador.Visualizar(controlador.SqlSelecaoTodos).ForEach(x => Console.WriteLine(x));

            Console.Write("\nInsira o ID do registro que deseja Excluir: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (!VerificarSeIdExiste(id))
                return;

            controlador.ExcluirRegistro(id);
        }
        public void EditarRegistro()
        {
            Console.Clear();
            if (!ValidarVisualizacao())
            {
                Console.WriteLine("Nenhum registro cadastrado por enquanto!");
                Console.ReadLine();
                return;
            }
            controlador.Visualizar(controlador.SqlSelecaoTodos).ForEach(x => Console.WriteLine(x));
            Console.Write("\nInsira o ID do registro que deseja Editar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (!VerificarSeIdExiste(id))
                return;

            T registro = typeof(T) == typeof(Tarefa) ? ObterTarefaEditar() : ObterRegistro();

            controlador.EditarRegistro(registro, id);
        }
        public void InserirRegistro()
        {
            T registro = ObterRegistro();
            if (registro == null)
                return;
            controlador.InserirRegistro(registro);
        }
        public void MensagemErro()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nOpção Inválida");
            Console.ResetColor();
            Console.ReadLine();
        }
        public abstract void VisualizarRegistro();
        public abstract T ValidarRegistro(T registro);
        public abstract T ObterRegistro();
        public virtual T ObterTarefaEditar() { return (T)Activator.CreateInstance(typeof(T)); }
        private bool ValidarVisualizacao()
        {
            return controlador.Visualizar(controlador.SqlSelecaoTodos).Count == 0 ? false : true;
        }
        private bool VerificarSeIdExiste(int id)
        {
            bool existe = true;
            if (!controlador.Visualizar(controlador.SqlSelecaoTodos).Exists(x => x.Id == id))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNão existe nenhum registro com este ID");
                Console.ResetColor();
                Console.ReadLine();
                existe = false;
            }
            return existe;
        }
    }
}