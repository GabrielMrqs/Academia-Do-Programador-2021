using AgendaJP.Controladores.Model;
using System;

namespace AgendaJP.ConsoleApp.Telas
{
    public class TelaPrincipal
    {
        private ControladorTarefa controladorTarefa = new ControladorTarefa();
        private ControladorContato controladorContato = new ControladorContato();
        private ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        public TelaPrincipal()
        {
            Menu();
        }
        public void Menu()
        {
            string opcao = "";
            while (opcao != "S")
            {
                Console.Clear();
                Console.WriteLine("Controle de Contatos e Tarefas\n");
                Console.WriteLine("Insira 1 para Tarefas");
                Console.WriteLine("Insira 2 para Contatos");
                Console.WriteLine("Insira 3 para Compromissos");
                Console.WriteLine("Insira S para Sair");
                Console.Write("Opção: ");
                opcao = Console.ReadLine().ToUpper();

                switch (opcao)
                {
                    case "1": new TelaTarefa(controladorTarefa); continue;
                    case "2": new TelaContato(controladorContato); continue;
                    case "3": new TelaCompromisso(controladorCompromisso, controladorContato); continue;
                    case "S": break;
                    default:; continue;
                }
            }
        }
    }
}
