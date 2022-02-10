using System;
using GestaoEquipamentos.ConsoleApp.Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp
{
    public class ControladorSolicitante : ControladorBase

    {
        public ControladorSolicitante(int capacidade)
        {

        }
       
        Solicitante[] solicitantes = new Solicitante[100];

        public override string Registrar(int id, string nome, string email, long numeroTelefone)
        {
            Solicitante solicitante = null;

            int posicao = ObterPosicaoParaSolicitantes(id);

            if (id == 0)
                solicitante = new Solicitante();
            else
                solicitante = solicitantes[posicao];

            solicitante.nome = nome;
            solicitante.email = email;
            solicitante.numTelefone = numeroTelefone;

            string resultadoValidacao = solicitante.Validar();

            if (resultadoValidacao == "SOLICITANTE_VALIDO")
                solicitantes[posicao] = solicitante;

            return resultadoValidacao;
        }

        public override object SelecionarPorId(int id)
        {
            Solicitante solicitante = null;

            for (int i = 0; i < solicitantes.Length; i++)
            {
                if (solicitantes[i].id == id)
                {
                    solicitante = solicitantes[i];

                    break;
                }
            }

            return solicitante;
        }

        public override bool Excluir(int idSelecionado)
        {
            bool conseguiuExcluir = false;

            for (int i = 0; i < solicitantes.Length; i++)
            {
                if (solicitantes[i].id == idSelecionado)
                {
                    solicitantes[i] = null;
                    conseguiuExcluir = true;
                    break;
                }
            }
            return conseguiuExcluir;
        }

        public override object[] SelecionarTudo()
        {
            Solicitante[] solicitanteAux = new Solicitante[QtdCadastrados()];

            int i = 0;

            foreach (Solicitante solicitante in solicitantes)
            {
                if (solicitante != null)
                    solicitanteAux[i++] = solicitante;
            }

            return solicitanteAux;
        }

        public override int QtdCadastrados()
        {
            int numeroSolicitantesCadastrados = 0;

            for (int i = 0; i < solicitantes.Length; i++)
            {
                if (solicitantes[i] != null)
                {
                    numeroSolicitantesCadastrados++;
                }
            }

            return numeroSolicitantesCadastrados;
        }

        private int ObterPosicaoParaSolicitantes(int idSolicitanteSelecionado)
        {
            int posicao = 0;

            for (int i = 0; i < solicitantes.Length; i++)
            {
                if (idSolicitanteSelecionado == 0 && solicitantes[i] == null)
                {
                    posicao = i;
                    break;
                }
                else if (idSolicitanteSelecionado == solicitantes[i].id)
                {
                    posicao = i;
                    break;
                }
            }

            return posicao;
        }
    }
}

