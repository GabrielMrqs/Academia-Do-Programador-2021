using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;
using System.Linq;
using AgendaJP.Controladores.Model;
using AgendaJP.Dominios.Model;
using System.Configuration;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace AgendaJP.Tests.Tarefas
{
    [TestClass]
    public class ControladorTarefaTest
    {
        private ControladorTarefa controladorTarefa;

        public ControladorTarefaTest()
        {
            controladorTarefa = new ControladorTarefa();

            Update("DELETE FROM TBTAREFA");
        }

        [TestMethod]
        public void InserirTarefa()
        {
            Tarefa tarefa = new Tarefa("Alta", "Fazer testes", new DateTime(2021, 06, 22), new DateTime(2021, 06, 23), 50);

            controladorTarefa.InserirRegistro(tarefa);

            var qtdCadastroNoBanco = controladorTarefa.Visualizar(controladorTarefa.SqlSelecaoTodos).Count;

            qtdCadastroNoBanco.Should().Be(1);
        }
        [TestMethod]
        public void EditarTarefa()
        {
            Tarefa tarefa1 = new Tarefa("Alta", "Fazer testes", new DateTime(2021, 06, 22), new DateTime(2021, 06, 23), 50);

            controladorTarefa.InserirRegistro(tarefa1);

            Tarefa tarefa2 = new Tarefa("Alta", "Fazer bolinho de arroz", new DateTime(2021, 06, 22), new DateTime(2021, 06, 23), 50);

            controladorTarefa.EditarRegistro(tarefa2, tarefa1.Id);

            var tarefa = controladorTarefa.Visualizar($"SELECT * FROM TBTAREFA WHERE ID = {tarefa1.Id}").Last();

            tarefa.Titulo.Should().Be("Fazer bolinho de arroz");
        }

        [TestMethod]
        public void ExcluirTarefa()
        {
            Tarefa tarefa = new Tarefa("Alta", "Fazer testes", new DateTime(2021, 06, 22), new DateTime(2021, 06, 23), 50);

            controladorTarefa.InserirRegistro(tarefa);

            controladorTarefa.ExcluirRegistro(tarefa.Id);

            var qtdCadastrados = controladorTarefa.Visualizar(controladorTarefa.SqlSelecaoTodos).Count;

            qtdCadastrados.Should().Be(0);
        }

        private void Update(string sql)
        {
            string bancoSelecionado, enderecoDBAgendaJP;
            bancoSelecionado = ConfigurationManager.AppSettings["bancoDeDados"];
            enderecoDBAgendaJP = ConfigurationManager.ConnectionStrings[bancoSelecionado].ConnectionString;

            dynamic connection;
            dynamic command;

            if (bancoSelecionado == "SQLite")
            {
                connection = new SQLiteConnection(enderecoDBAgendaJP);
                command = new SQLiteCommand();
            }
            else
            {
                connection = new SqlConnection(enderecoDBAgendaJP);
                command = new SqlCommand();
            }

            command.CommandText = sql;

            command.Connection = connection;

            connection.Open();

            command.ExecuteNonQuery();
        }
    }
}