using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Configuration;
using System.Linq;
using AgendaJP.Dominios.Model;

namespace AgendaJP.Controladores.Model
{
    public abstract class Controlador<T> where T : EntidadeBase
    {
        #region Conexão
        private string bancoSelecionado;
        private string enderecoDBAgendaJP;
        #endregion

        public Controlador()
        {
            bancoSelecionado = ConfigurationManager.AppSettings["bancoDeDados"];
            enderecoDBAgendaJP = ConfigurationManager.ConnectionStrings[bancoSelecionado].ConnectionString;
        }

        public void InserirRegistro(T registro)
        {
            dynamic conexaoComBanco;
            dynamic comando;

            EscolherProvedor(out conexaoComBanco, out comando);

            conexaoComBanco.Open();
            comando.Connection = conexaoComBanco;

            string sqlInsercao = $@"INSERT 
               INTO { Tabela}
               (
                   { Valores}
	           ) 
	           VALUES
               (
                   { FormatarValores(Valores)}
	           ); ";

            if (bancoSelecionado == "SQLite")
                sqlInsercao +=
                @"SELECT last_insert_rowid();";
            else
                sqlInsercao +=
                @"SELECT SCOPE_IDENTITY();";

            comando.CommandText = sqlInsercao;

            InserirNoBanco(comando, registro);

            object id = comando.ExecuteScalar();

            registro.Id = Convert.ToInt32(id);

            conexaoComBanco.Close();
        }
        public void EditarRegistro(T registro, int id)
        {
            dynamic conexaoComBanco;
            dynamic comando;

            EscolherProvedor(out conexaoComBanco, out comando);

            conexaoComBanco.Open();
            comando.Connection = conexaoComBanco;

            string sqlEdicao = $@"UPDATE {Tabela}
	                SET
		                {Atualizar}
	                WHERE 
                        [ID] = @ID";

            comando.CommandText = sqlEdicao;

            EditarNoBanco(comando, id, registro);

            comando.ExecuteNonQuery();

            conexaoComBanco.Close();
        }
        public void ExcluirRegistro(int id)
        {
            dynamic conexaoComBanco;
            dynamic comando;

            EscolherProvedor(out conexaoComBanco, out comando);

            conexaoComBanco.Open();

            comando.Connection = conexaoComBanco;

            string sqlExclusao = $@"DELETE 
                                          FROM {Tabela}
                                     WHERE
                                          [ID] = @ID";

            comando.CommandText = sqlExclusao;

            comando.Parameters.AddWithValue("ID", id);

            comando.ExecuteNonQuery();

            conexaoComBanco.Close();
        }
        public T GetById(int id)
        {
            return Visualizar($@"SELECT * FROM {Tabela} WHERE ID = {id}").Last();
        }
        public virtual List<T> Visualizar(string sqlSelecao)
        {
            dynamic leitorTarefas;
            dynamic conexaoComBanco;
            dynamic comando;

            EscolherProvedor(out conexaoComBanco, out comando);

            conexaoComBanco.Open();
            comando.Connection = conexaoComBanco;

            comando.CommandText = sqlSelecao;

            leitorTarefas = comando.ExecuteReader();

            List<T> registros = new List<T>();

            LerRegistros(leitorTarefas, registros);

            conexaoComBanco.Close();

            return registros;
        }
        public abstract void InserirNoBanco(dynamic comandoInsercao, T registro);
        public abstract void EditarNoBanco(dynamic comandoEdicao, int id, T registro);
        public abstract void LerRegistros(dynamic leitorTarefas, List<T> registros);
        public abstract string Tabela { get; }
        public abstract string Valores { get; }
        public abstract string Atualizar { get; }
        public abstract string SqlSelecaoTodos { get; }
        private string FormatarValores(string valores)
        {
            List<string> palavras = new List<string>();
            palavras = valores.Split(',').ToList();
            string resultado = "";
            palavras.ForEach(x => resultado += "@" + x + ",");
            resultado = resultado.Replace("[", "");
            resultado = resultado.Replace("]", "");
            resultado = resultado.Remove(resultado.Length - 1);
            return resultado;
        }
        private void EscolherProvedor(out dynamic conexaoComBanco, out dynamic comando)
        {
            if (bancoSelecionado == "SQLite")
            {
                conexaoComBanco = new SQLiteConnection(enderecoDBAgendaJP);
                comando = new SQLiteCommand();
            }
            else
            {
                conexaoComBanco = new SqlConnection(enderecoDBAgendaJP);
                comando = new SqlCommand();
            }
        }
    }
}