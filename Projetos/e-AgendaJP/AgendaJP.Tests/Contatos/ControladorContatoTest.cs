using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Linq;
using AgendaJP.Controladores.Model;
using AgendaJP.Dominios.Model;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SQLite;
using System;

namespace AgendaJP.Tests.Contatos
{
    [TestClass]
    public class ControladorContatoTest
    {
        private ControladorContato controladorContato;
        private ControladorCompromisso controladorCompromisso;
        public ControladorContatoTest()
        {
            controladorContato = new ControladorContato();
            controladorCompromisso = new ControladorCompromisso();
            Update("DELETE FROM TBCOMPROMISSO");
            Update("DELETE FROM TBCONTATO");
        }

        [TestMethod]
        public void InserirContato()
        {
            Contato contato = new Contato("Juca", "Juca1990@gmail.com", "49998035074", "NDD", "DESENVOLVEDOR");

            controladorContato.InserirRegistro(contato);

            var qtdCadastroNoBanco = controladorContato.Visualizar(controladorContato.SqlSelecaoTodos).Count;

            qtdCadastroNoBanco.Should().Be(1);
        }
        [TestMethod]
        public void EditarContato()
        {
            Contato contato1 = new Contato("Juca", "Juca1990@gmail.com", "49998035074", "NDD", "DESENVOLVEDOR");

            controladorContato.InserirRegistro(contato1);

            Contato contato2 = new Contato("Pedroca", "Pedrinho@gmail.com", "49998035074", "NDD", "TESTER");

            controladorContato.EditarRegistro(contato2, contato1.Id);

            var contato = controladorContato.Visualizar($"SELECT * FROM TBCONTATO WHERE ID = {contato1.Id}").Last();

            contato.Nome.Should().Be("Pedroca");
        }

        [TestMethod]
        public void ExcluirContato()
        {
            Contato contato = new Contato("Juca", "Juca1990@gmail.com", "49998035074", "NDD", "DESENVOLVEDOR");

            controladorContato.InserirRegistro(contato);

            controladorContato.ExcluirRegistro(contato.Id);

            var qtdCadastroNoBanco = controladorContato.Visualizar(controladorContato.SqlSelecaoTodos).Count;

            qtdCadastroNoBanco.Should().Be(0);
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