using GestaoEquipamentos.ConsoleApp.Controladores;
using GestaoEquipamentos.ConsoleApp.Telas;
using System;

namespace GestaoEquipamentos.ConsoleApp
{
    class TelaPrincipal
    {
        ControladorChamado controladorChamado;
        ControladorEquipamento controladorEquipamento;
        ControladorSolicitante controladorSolicitante;
        TelaEquipamento telaEquipamento;
        TelaSolicitante telaSolicitante;

        public TelaPrincipal(TelaEquipamento tlEquipamento, TelaSolicitante tlSolicitante,
            ControladorEquipamento ctlrEquipamento, ControladorChamado ctlrChamado, ControladorSolicitante ctlrSolicitante)
        {
            telaEquipamento = tlEquipamento;
            telaSolicitante = tlSolicitante;
            controladorEquipamento = ctlrEquipamento;
            controladorChamado = ctlrChamado;
            controladorSolicitante = ctlrSolicitante;
        }

        public TelaBase ObterTela()
        {
            string opcao;
            TelaBase telaSelecionada = null;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite 1 para o Cadastro de Equipamentos");
                Console.WriteLine("Digite 2 para o Cadastro de Solicitantes");
                Console.WriteLine("Digite 3 para o Cadastro de Chamados");
                Console.WriteLine("Digite S para Sair");

                opcao = Console.ReadLine();
                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    telaSelecionada = null; break;
                }
                if (opcao == "1")
                {
                    telaSelecionada = new TelaEquipamento(controladorEquipamento); break;
                }
                if (opcao == "2")
                {
                    telaSelecionada = new TelaSolicitante(controladorSolicitante); break;
                }
                if(opcao == "3")
                {
                    telaSelecionada = new TelaChamado(controladorChamado, telaSolicitante, telaEquipamento); break;
                }
                    
            }
            return telaSelecionada;
        }
    }
}
