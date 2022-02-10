using GestaoEquipamentos.ConsoleApp.Dominio;
using System;

namespace GestaoEquipamentos.ConsoleApp.Controladores
{
    public class ControladorChamado : ControladorBase
    {

        private ControladorEquipamento controladorEquipamento;
        private ControladorSolicitante controladorSolicitante;

        private Chamado[] chamados;

        public ControladorChamado(int capacidadeRegistros, ControladorEquipamento controlador, ControladorSolicitante ctlrSolicitante)
        {
            controladorSolicitante = ctlrSolicitante;
            controladorEquipamento = controlador;
            chamados = new Chamado[capacidadeRegistros];
        }

        public override string Registrar(int idChamadoSelecionado, int idEquipamentoChamado, string titulo, string descricao, DateTime dataAbertura, int idSolicitanteChamado)
        {
            Chamado chamado = null;

            int posicao = ObterPosicaoParaChamados(idChamadoSelecionado);

            if (idChamadoSelecionado == 0)
                chamado = new Chamado();
            else
                chamado = chamados[posicao];

            chamado.equipamento = (Equipamento)controladorEquipamento.SelecionarPorId(idEquipamentoChamado);
            chamado.solicitante = (Solicitante)controladorSolicitante.SelecionarPorId(idSolicitanteChamado);
            chamado.titulo = titulo;
            chamado.descricao = descricao;
            chamado.dataAbertura = dataAbertura;
            

            string resultadoValidacao = chamado.Validar();

            if (resultadoValidacao == "CHAMADO_VALIDO")
                chamados[posicao] = chamado;

            return resultadoValidacao;
        }

        public override bool Excluir(int idSelecionado)
        {
            bool conseguiuExcluir = false;

            for (int i = 0; i < chamados.Length; i++)
            {
                if (chamados[i].id == idSelecionado)
                {
                    chamados[i] = null;
                    conseguiuExcluir = true;
                    break;
                }
            }
            return conseguiuExcluir;
        }

        public Chamado[] SelecionarTodosChamados()
        {
            Chamado[] chamadosAux = new Chamado[QtdCadastrados()];

            int i = 0;

            foreach (Chamado chamado in chamados)
            {
                if (chamado != null)
                    chamadosAux[i++] = chamado;
            }
           
            return chamadosAux;
        }

        public override int QtdCadastrados()
        {
            int numeroChamadosCadastrados = 0;

            for (int i = 0; i < chamados.Length; i++)
            {
                if (chamados[i] != null)
                {
                    numeroChamadosCadastrados++;
                }
            }

            return numeroChamadosCadastrados;
        }

        private int ObterPosicaoParaChamados(int idChamadoSelecionado)
        {
            int posicao = 0;

            for (int i = 0; i < chamados.Length; i++)
            {
                if (idChamadoSelecionado == 0 && chamados[i] == null) //inserindo...
                {
                    posicao = i;
                    break;
                }
                else if (idChamadoSelecionado == chamados[i].id) //editando...
                {
                    posicao = i;
                    break;
                }
            }

            return posicao;
        }
    }
}
