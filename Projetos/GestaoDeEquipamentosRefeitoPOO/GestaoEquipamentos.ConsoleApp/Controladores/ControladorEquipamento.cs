using System;
using GestaoEquipamentos.ConsoleApp.Dominio;

namespace GestaoEquipamentos.ConsoleApp.Controladores
{
    /// <summary>
    /// encarregado pelo CRUD
    /// Armazenar, Recuperar, Atualizar, Excluir
    /// 
    /// CONTROLLER = COORDENAÇÃO
    /// </summary>
    public class ControladorEquipamento : ControladorBase
    {
        public ControladorEquipamento(int capacidade)
        {

        }

        Equipamento[] equipamentos = new Equipamento[100];

        public override string Registrar(int id, string nome, double preco, string numeroSerie, DateTime dataFabricacao, string fabricante)
        {
            Equipamento equipamento = null;

            int posicao = ObterPosicaoParaEquipamentos(id);

            if (id == 0)
                equipamento = new Equipamento();
            else
                equipamento = equipamentos[posicao];

            equipamento.nome = nome;
            equipamento.preco = preco;
            equipamento.numeroSerie = numeroSerie;
            equipamento.dataFabricacao = dataFabricacao;
            equipamento.fabricante = fabricante;

            string resultadoValidacao = equipamento.Validar();

            if (resultadoValidacao == "EQUIPAMENTO_VALIDO")
                equipamentos[posicao] = equipamento;

            return resultadoValidacao;
        }

        public override object SelecionarPorId(int id)
        {
            Equipamento equipamento = null;

            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i].id == id)
                {
                    equipamento = equipamentos[i];

                    break;
                }
            }

            return equipamento;
        }

        public override bool Excluir(int idSelecionado)
        {
            bool conseguiuExcluir = false;

            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i].id == idSelecionado)
                {
                    equipamentos[i] = null;
                    conseguiuExcluir = true;
                    break;
                }
            }
            return conseguiuExcluir;
        }

        public override object[] SelecionarTudo()
        {
            Equipamento[] equipamentosAux = new Equipamento[QtdCadastrados()];

            int i = 0;

            foreach (Equipamento equipamento in equipamentos)
            {
                if (equipamento != null)
                    equipamentosAux[i++] = equipamento;
            }

            return equipamentosAux;
        }

        public override int QtdCadastrados()
        {
            int numeroEquipamentosCadastrados = 0;

            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] != null)
                {
                    numeroEquipamentosCadastrados++;
                }
            }

            return numeroEquipamentosCadastrados;
        }

        private int ObterPosicaoParaEquipamentos(int idEquipamentoSelecionado)
        {
            int posicao = 0;

            for (int i = 0; i < equipamentos.Length; i++)
            {
                //retorna uma posição para inserir equipamento
                if (idEquipamentoSelecionado == 0 && equipamentos[i] == null)
                {
                    posicao = i;
                    break;
                }
                //retorna uma posição de um equipamento existente
                else if (idEquipamentoSelecionado == equipamentos[i].id) //editando...
                {
                    posicao = i;
                    break;
                }
            }

            return posicao;
        }
    }
}