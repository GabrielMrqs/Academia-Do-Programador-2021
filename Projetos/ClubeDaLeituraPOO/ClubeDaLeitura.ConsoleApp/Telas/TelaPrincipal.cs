using ClubeDaLeitura.ConsoleApp.Controladores;
using System;

namespace ClubeDaLeitura.ConsoleApp.Telas
{
    class TelaPrincipal
    {
        
        ControladorCaixa controladorCaixa;
        ControladorAmiguinho controladorAmiguinho;
        ControladorRevista controladorRevista;
        ControladorEmprestimo controladorEmprestimo;

        public TelaPrincipal()
        {
            controladorCaixa = new ControladorCaixa(100);
            controladorAmiguinho = new ControladorAmiguinho(100);
            controladorRevista = new ControladorRevista(100);
            controladorEmprestimo = new ControladorEmprestimo(100);
        }
        public TelaBase ObterTela()
        {
            string opcao;
            TelaBase telaSelecionada = null;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Clube da Leitura\n");
                Console.WriteLine("Digite 1 para o Cadastro de Caixas");
                Console.WriteLine("Digite 2 para o Cadastro de Amiguinhos");
                Console.WriteLine("Digite 3 para o Cadastro de Revistas");
                Console.WriteLine("Digite 4 para o Cadastro de Empréstimos");
                Console.WriteLine("Digite S para Sair");

                opcao = Console.ReadLine();
                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    telaSelecionada = null; break;
                }
                if (opcao == "1")
                {
                    telaSelecionada = new TelaCaixa(controladorCaixa); break;
                }
                if (opcao == "2")
                {
                    telaSelecionada = new TelaAmiguinho(controladorAmiguinho); break;
                }
                if (opcao == "3")
                {
                    telaSelecionada = new TelaRevista(controladorRevista, controladorCaixa); break;
                }
                if (opcao == "4")
                {
                    telaSelecionada = new TelaEmprestimo(controladorRevista, controladorAmiguinho, controladorEmprestimo, controladorCaixa); break;
                }

            }
            return telaSelecionada;
        }
    }
}
