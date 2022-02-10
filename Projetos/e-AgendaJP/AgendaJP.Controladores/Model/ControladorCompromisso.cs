using AgendaJP.Dominios.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AgendaJP.Controladores.Model
{
    public class ControladorCompromisso : Controlador<Compromisso>
    {
        #region Queries
        public override string Tabela => "TBCOMPROMISSO";
        public override string Valores => "[ASSUNTO],[LOCAL],[DATA_INICIO],[DATA_FINAL],[ID_CONTATO]";
        public override string Atualizar => "[ASSUNTO] = @ASSUNTO,[LOCAL] = @LOCAL,[DATA_INICIO] = @DATA_INICIO,[DATA_FINAL] = @DATA_FINAL,[ID_CONTATO] = @ID_CONTATO";
        public override string SqlSelecaoTodos => $@"SELECT
                                                   comp.[ID], 
                                                   comp.[ASSUNTO],
                                                   comp.[LOCAL], 
                                                   comp.[DATA_INICIO],
                                                   comp.[DATA_FINAL],
                                                   comp.[ID_CONTATO]
                                               FROM
                                                   TBCOMPROMISSO comp
                                                   LEFT JOIN TBCONTATO con
                                                   ON ID_CONTATO = con.ID";

        private string sqlSelecaoPassado = $@"SELECT
                                                    comp.[ID], 
                                                    [ASSUNTO],
                                                    [LOCAL], 
                                                    [DATA_INICIO],
                                                    [DATA_FINAL],
                                                    [ID_CONTATO]
                                               FROM
                                                    TBCOMPROMISSO comp
                                                    LEFT JOIN TBCONTATO con
                                               ON 
                                                    ID_CONTATO = con.ID
                                               WHERE
                                                    [DATA_FINAL] < CURRENT_TIMESTAMP";

        #endregion
        private ControladorContato controladorContato = new ControladorContato();
        public List<Compromisso> VisualizarCompromissosPassados()
        {
            return Visualizar(sqlSelecaoPassado);
        }
        public List<Compromisso> VisualizarCompromissosFuturos(DateTime inicio, DateTime final)
        {      
            string sqlSelecaoFuturo = $@"SELECT
                                              comp.[ID], 
                                              comp.[ASSUNTO],
                                              comp.[LOCAL], 
                                              comp.[DATA_INICIO],
                                              comp.[DATA_FINAL],
                                              comp.[ID_CONTATO]
                                         FROM
                                              TBCOMPROMISSO comp
                                              LEFT JOIN TBCONTATO con
                                              ON ID_CONTATO = con.ID
                                         WHERE
                                              [DATA_FINAL] <= '{final:yyyy-MM-dd}' 
                                         AND 
                                              [DATA_INICIO] >= '{inicio:yyyy-MM-dd}'";
            return Visualizar(sqlSelecaoFuturo);
        }
        public override void EditarNoBanco(dynamic comandoEdicao, int id, Compromisso registro)
        {
            comandoEdicao.Parameters.AddWithValue("ID", id);
            comandoEdicao.Parameters.AddWithValue("ASSUNTO", registro.Assunto);
            comandoEdicao.Parameters.AddWithValue("LOCAL", registro.Local);
            comandoEdicao.Parameters.AddWithValue("DATA_INICIO", registro.InicioDoCompromisso);
            comandoEdicao.Parameters.AddWithValue("DATA_FINAL", registro.FimDoCompromisso);
            if (registro.Contato == null)
                comandoEdicao.Parameters.AddWithValue("ID_CONTATO", DBNull.Value);
            else
                comandoEdicao.Parameters.AddWithValue("ID_CONTATO", registro.Contato.Id);
        }
        public override void InserirNoBanco(dynamic comandoInsercao, Compromisso registro)
        {
            comandoInsercao.Parameters.AddWithValue("ASSUNTO", registro.Assunto);
            comandoInsercao.Parameters.AddWithValue("LOCAL", registro.Local);
            comandoInsercao.Parameters.AddWithValue("DATA_INICIO", registro.InicioDoCompromisso);
            comandoInsercao.Parameters.AddWithValue("DATA_FINAL", registro.FimDoCompromisso);
            if (registro.Contato == null)
                comandoInsercao.Parameters.AddWithValue("ID_CONTATO", DBNull.Value);
            else
                comandoInsercao.Parameters.AddWithValue("ID_CONTATO", registro.Contato.Id);
        }
        public override void LerRegistros(dynamic leitorTarefas, List<Compromisso> registros)
        {
            while (leitorTarefas.Read())
            {
                Contato contato = null;
                int id = Convert.ToInt32(leitorTarefas["ID"]);
                string assunto = Convert.ToString(leitorTarefas["ASSUNTO"]);
                string local = Convert.ToString(leitorTarefas["LOCAL"]);
                DateTime dataCriacao = Convert.ToDateTime(leitorTarefas["DATA_INICIO"]);
                DateTime dataConclusao = Convert.ToDateTime(leitorTarefas["DATA_FINAL"]);
                if (Convert.ToString(leitorTarefas["ID_CONTATO"]) != DBNull.Value.ToString())
                {
                    int idContato = Convert.ToInt32(leitorTarefas["ID_CONTATO"]);
                    contato = controladorContato.Visualizar($"SELECT * FROM TBCONTATO WHERE ID = {idContato}").Last();
                }

                Compromisso registro = new Compromisso(assunto, local, dataCriacao, dataConclusao, contato);

                registro.Id = id;

                registros.Add(registro);
            }
        }
        public string ValidarDatas(Compromisso compromisso)
        {
            string ehValido = "";
            string sqlEntreDatas = $@"SELECT *
                                    FROM TBCompromisso
                                    WHERE
                                    '{compromisso.InicioDoCompromisso.ToString("yyyy-MM-dd HH:mm:ss.fff")}' BETWEEN DATA_INICIO AND DATA_FINAL
                                    OR  
                                    '{compromisso.FimDoCompromisso.ToString("yyyy-MM-dd HH:mm:ss.fff")}' BETWEEN DATA_INICIO AND DATA_FINAL
                                    OR
                                    DATA_INICIO BETWEEN '{compromisso.InicioDoCompromisso.ToString("yyyy-MM-dd HH:mm:ss.fff")}'
                                    AND '{compromisso.FimDoCompromisso.ToString("yyyy-MM-dd HH:mm:ss.fff")}'";

            if (compromisso.InicioDoCompromisso > compromisso.FimDoCompromisso)
                ehValido += "Data de conclusão menor que Data de Início.\n";
            if (compromisso.InicioDoCompromisso.DayOfWeek == DayOfWeek.Saturday ||
                   compromisso.InicioDoCompromisso.DayOfWeek == DayOfWeek.Sunday)
                ehValido += "Dia da semana inválido.\n";
            if (Visualizar(sqlEntreDatas).Count != 0)
                ehValido += "Já exite compromisso neste horário.\n";

            return ehValido;
        }
    }
}