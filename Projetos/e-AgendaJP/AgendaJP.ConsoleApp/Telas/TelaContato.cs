using AgendaJP.Controladores.Model;
using AgendaJP.Dominios.Model;
using System;

namespace AgendaJP.ConsoleApp.Telas
{
    public class TelaContato : TelaBase<Contato>
    {
        private ControladorContato controlador;
        public TelaContato(ControladorContato controlador) : base(controlador)
        {
            this.controlador = controlador;
            Menu();
        }

        public override void VisualizarRegistro()
        {
            Console.Clear();
            if (controlador.Visualizar(controlador.SqlSelecaoTodos).Count == 0)
            {
                Console.WriteLine("Nenhum contato por enquanto!");
                Console.ReadLine();
                return;
            }
            controlador.Visualizar(controlador.SqlSelecaoTodos).ForEach(x => Console.WriteLine(x));
            Console.ReadLine();
        }
        public override Contato ObterRegistro()
        {
            Console.Clear();
            Console.Write("Insira o Nome do Contato: ");
            string nome = Console.ReadLine();
            Console.Write("Insira o E-mail do Contato: ");
            string email = Console.ReadLine();
            Console.Write("Insira o Telefone com DDD do Contato: ");
            string telefone = Console.ReadLine();
            Console.Write("Insira a Empresa do Contato: ");
            string empresa = Console.ReadLine();
            Console.Write("Insira o Cargo do Contato: ");
            string cargo = Console.ReadLine();

            Contato contato = new Contato(nome, email, telefone, empresa, cargo);

            return ValidarRegistro(contato);
        }
        public override Contato ValidarRegistro(Contato contato)
        {
            if (contato.Validar() == "")
                 return contato;
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDados incorretos, tente novamente!");
                Console.ResetColor();
                Console.ReadLine();
                return ObterRegistro();
            }
        }
    }
}