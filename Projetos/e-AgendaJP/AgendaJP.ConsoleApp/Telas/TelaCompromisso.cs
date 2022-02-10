using AgendaJP.Controladores.Model;
using AgendaJP.Dominios.Model;
using System;

namespace AgendaJP.ConsoleApp.Telas
{
    public class TelaCompromisso : TelaBase<Compromisso>
    {
        private ControladorCompromisso controlador;
        private ControladorContato controladorContato;
        public TelaCompromisso(ControladorCompromisso controlador, ControladorContato controladorContato) : base(controlador)
        {
            this.controladorContato = controladorContato;
            this.controlador = controlador;
            Menu();
        }

        public override void VisualizarRegistro()
        {
            Console.Clear();
            Console.WriteLine("Insira 1 para Compromissos passados");
            Console.WriteLine("Insira 2 para Compromissos futuros");
            switch (Console.ReadLine())
            {
                case "1": VisualizarCompromissosPassados(); break;
                case "2": VisualizarCompromissosFuturos(); break;
                default: MensagemErro(); break;
            }
        }
        public override Compromisso ObterRegistro()
        {
            if(controladorContato.Visualizar(controladorContato.SqlSelecaoTodos).Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPrimeiro registre um contato");
                Console.ResetColor();
                Console.ReadLine();
                return null;
            }
            Console.Clear();
            Console.Write("Insira o Assunto do Compromisso: ");
            string assunto = Console.ReadLine();
            Console.Write("Insira o Local do Compromisso: ");
            string local = Console.ReadLine();
            Console.Write("Insira a Data do Compromisso (ex: 01/01/0001) ");
            string data = Console.ReadLine();
            Console.Write("Insira o Horário Inicial do Compromisso (ex: 00:00) ");
            string horarioInicial = Console.ReadLine();
            Console.Write("Insira o Horário Final do Compromisso (ex: 00:00) ");
            string horarioFinal = Console.ReadLine();
            Console.Write("Algum Contato envolvido? ( 1 - SIM | 2 - NÃO ) ");
            int temContato = Convert.ToInt32(Console.ReadLine());
            int id = 0;
            Contato contato = null;
            if(temContato == 1)
            {
                Console.WriteLine();

                controladorContato.Visualizar(controladorContato.SqlSelecaoTodos).ForEach(x => Console.WriteLine(x));

                Console.Write("Insira o ID do Contato envolvido no Compromisso: ");
                id = Convert.ToInt32(Console.ReadLine());

                contato = controladorContato.Visualizar(controladorContato.SqlSelecaoTodos).Find(x => x.Id == id);
            }

            Compromisso compromisso = new Compromisso(assunto, local, Convert.ToDateTime(data + " " + horarioInicial), Convert.ToDateTime(data + " "+ horarioFinal), contato);

            return ValidarRegistro(compromisso);
        }
        public override Compromisso ValidarRegistro(Compromisso compromisso)
        {
            if (compromisso.Validar() == "")
                return compromisso;
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDados incorretos, tente novamente!");
                Console.ResetColor();
                Console.ReadLine();
                return ObterRegistro();
            }
        }
        private void VisualizarCompromissosFuturos()
        {
            Console.Clear();
            if (controlador.Visualizar(controlador.SqlSelecaoTodos).Count == 0)
            {
                Console.WriteLine("Nenhum Compromisso Futuro por enquanto!");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Insira o Intervalo de Tempo: \n");
            Console.Write("Primeira data: ");
            DateTime primeiraData = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Segunda data: ");
            string segundaData = Console.ReadLine();

            //if (controlador.VisualizarCompromissosFuturos().Count == 0)
            //{
            //    Console.WriteLine("Nenhum Compromisso Futuro por enquanto!");
            //    Console.ReadLine();
            //    return;
            //}
            //Console.WriteLine();
            //controlador.VisualizarCompromissosFuturos();
            Console.ReadLine();
        }
        private void VisualizarCompromissosPassados()
        {
            Console.Clear();
            if (controlador.VisualizarCompromissosPassados().Count == 0)
            {
                Console.WriteLine("Nenhum Compromisso Passado por enquanto!");
                Console.ReadLine();
                return;
            }
            controlador.VisualizarCompromissosPassados().ForEach(x => Console.WriteLine(x));
            Console.ReadLine();
        }
    }
}
