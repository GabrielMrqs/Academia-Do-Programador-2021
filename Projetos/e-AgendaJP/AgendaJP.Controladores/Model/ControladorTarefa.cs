using AgendaJP.Dominios.Model;
using System;
using System.Collections.Generic;

namespace AgendaJP.Controladores.Model
{
    public class ControladorTarefa : Controlador<Tarefa>
    {
        #region Queries
        public override string Tabela => "TBTAREFA";
        public override string Valores => "[TITULO],[PRIORIDADE],[DATACRIACAO],[DATACONCLUSAO],[PERCENTUAL]";
        public override string Atualizar => "[TITULO] = @TITULO,[PRIORIDADE] = @PRIORIDADE,[DATACONCLUSAO] = @DATACONCLUSAO,[PERCENTUAL] = @PERCENTUAL";
        public override string SqlSelecaoTodos => $@"SELECT * FROM TBTAREFA";
        private string sqlSelecaoPendentes = $@"SELECT 
                                                    *
                                                FROM 
                                                    TBTAREFA
                                                WHERE
                                                    [PERCENTUAL] < 100
                                                ORDER BY
                                                  PRIORIDADE";
        private string sqlSelecaoCompletas = $@"SELECT 
                                       *
                                   FROM 
                                       TBTAREFA
                                   WHERE
                                       [PERCENTUAL] = 100
                                   ORDER BY
                                     PRIORIDADE";
        #endregion
        public List<Tarefa> VisualizarTarefasPendentes()
        {
            return Visualizar(sqlSelecaoPendentes);
        }
        public List<Tarefa> VisualizarTarefasFinalizadas()
        {
            return Visualizar(sqlSelecaoCompletas);
        }
        public override void InserirNoBanco(dynamic comandoInsercao, Tarefa tarefa)
        {
            comandoInsercao.Parameters.AddWithValue("TITULO", tarefa.Titulo);
            comandoInsercao.Parameters.AddWithValue("PRIORIDADE", tarefa.Prioridade);
            comandoInsercao.Parameters.AddWithValue("DATACRIACAO", tarefa.DataCriacao);
            comandoInsercao.Parameters.AddWithValue("DATACONCLUSAO", tarefa.DataConclusao);
            comandoInsercao.Parameters.AddWithValue("PERCENTUAL", tarefa.Percentual);
        }
        public override void EditarNoBanco(dynamic comandoEdicao, int id, Tarefa tarefa)
        {
            comandoEdicao.Parameters.AddWithValue("ID", id);
            comandoEdicao.Parameters.AddWithValue("TITULO", tarefa.Titulo);
            comandoEdicao.Parameters.AddWithValue("PRIORIDADE", tarefa.Prioridade);
            comandoEdicao.Parameters.AddWithValue("DATACONCLUSAO", tarefa.DataConclusao);
            comandoEdicao.Parameters.AddWithValue("PERCENTUAL", tarefa.Percentual);
        }
        public override void LerRegistros(dynamic leitorTarefas, List<Tarefa> registros)
        {
            while (leitorTarefas.Read())
            {
                int id = Convert.ToInt32(leitorTarefas["ID"]);
                string titulo = Convert.ToString(leitorTarefas["TITULO"]);
                string prioridade = Convert.ToString(leitorTarefas["PRIORIDADE"]);
                DateTime dataCriacao = Convert.ToDateTime(leitorTarefas["DATACRIACAO"]);
                DateTime dataConclusao = Convert.ToDateTime(leitorTarefas["DATACONCLUSAO"]);
                double percentual = Convert.ToDouble(leitorTarefas["PERCENTUAL"]);

                Tarefa registro = new Tarefa(prioridade, titulo, dataCriacao, dataConclusao, percentual);
                registro.Id = id;

                registros.Add(registro);
            }
        }
    }
}