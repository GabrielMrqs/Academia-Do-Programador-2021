using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Linq;
using System;
using AgendaJP.Controladores.Model;
using AgendaJP.Dominios.Model;
using System.Configuration;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace AgendaJP.Tests.Compromissos
{
    [TestClass]
    public class ControladorCompromissoTest
    {
        private ControladorCompromisso controladorCompromisso;
        private ControladorContato controladorContato;

        public ControladorCompromissoTest()
        {
            controladorCompromisso = new ControladorCompromisso();
            controladorContato = new ControladorContato();

            Update("DELETE FROM TBCOMPROMISSO");
            Update("DELETE FROM TBCONTATO");
        }

        [TestMethod]
        public void InserirCompromissoComContato()
        {
            Contato contato = new Contato("Juca", "Juca1990@gmail.com", "49998035074", "NDD", "DESENVOLVEDOR");

            controladorContato.InserirRegistro(contato);

            Compromisso compromisso = new Compromisso("Jogar um fut", "Campinho do Moradas", new DateTime(2021, 06, 22, 10, 00, 00),
               new DateTime(2021, 06, 22, 11, 00, 00), contato);

            controladorCompromisso.InserirRegistro(compromisso);

            var qtdCadastroNoBanco = controladorCompromisso.Visualizar(controladorCompromisso.SqlSelecaoTodos).Count;

            qtdCadastroNoBanco.Should().Be(1);
        }
        [TestMethod]
        public void InserirCompromissoSemContato()
        {
            Compromisso compromisso = new Compromisso("Jogar um fut", "Campinho do Moradas", new DateTime(2021, 06, 22, 10, 00, 00),
               new DateTime(2021, 06, 22, 11, 00, 00), null);

            controladorCompromisso.InserirRegistro(compromisso);

            var qtdCadastroNoBanco = controladorCompromisso.Visualizar(controladorCompromisso.SqlSelecaoTodos).Count;

            qtdCadastroNoBanco.Should().Be(1);
        }
        [TestMethod]
        public void InserirCompromissoEntreHorarioExistente()
        {
            Compromisso compromisso = new Compromisso("Cortar grama", "Casa da minha vó", new DateTime(2021, 06, 22, 13, 08, 00),
               new DateTime(2021, 06, 22, 13, 09, 00), null);

            controladorCompromisso.InserirRegistro(compromisso);

            Compromisso compromisso1 = new Compromisso("Fazer um café", "Casa da minha vó", new DateTime(2021, 06, 22, 13, 07, 00),
               new DateTime(2021, 06, 22, 13, 10, 00), null);

            controladorCompromisso.ValidarDatas(compromisso1).Should().Be("Já exite compromisso neste horário.\n");
        }
        [TestMethod]
        public void EditarCompromissoComContato()
        {
            Compromisso compromisso1 = new Compromisso("Fazer vaso de barro", "Casa da minha vó", new DateTime(2021, 06, 22, 10, 00, 00),
               new DateTime(2021, 06, 22, 12, 00, 00), null);

            controladorCompromisso.InserirRegistro(compromisso1);

            Contato contato = new Contato("Juca", "Juca1990@gmail.com", "49998035074", "NDD", "DESENVOLVEDOR");

            controladorContato.InserirRegistro(contato);

            Compromisso compromisso2 = new Compromisso("Cortar grama", "Casa da minha vó", new DateTime(2021, 06, 22, 10, 00, 00),
               new DateTime(2021, 06, 22, 12, 00, 00), contato);

            controladorCompromisso.EditarRegistro(compromisso2, compromisso1.Id);

            var compromisso = controladorCompromisso.Visualizar($"SELECT * FROM TBCOMPROMISSO WHERE ID = {compromisso1.Id}").Last();

            compromisso.Contato.Should().NotBeNull();
        }
        [TestMethod]
        public void EditarCompromissoSemContato()
        {
            Contato contato = new Contato("Juca", "Juca1990@gmail.com", "49998035074", "NDD", "DESENVOLVEDOR");

            controladorContato.InserirRegistro(contato);

            Compromisso compromisso1 = new Compromisso("Fazer vaso de barro", "Casa da minha vó", new DateTime(2021, 06, 22, 10, 00, 00),
               new DateTime(2021, 06, 22, 12, 00, 00), contato);

            controladorCompromisso.InserirRegistro(compromisso1);

            Compromisso compromisso2 = new Compromisso("Cortar grama", "Casa da minha vó", new DateTime(2021, 06, 22, 10, 00, 00),
               new DateTime(2021, 06, 22, 12, 00, 00), null);

            controladorCompromisso.EditarRegistro(compromisso2, compromisso1.Id);

            var compromisso = controladorCompromisso.Visualizar($"SELECT * FROM TBCOMPROMISSO WHERE ID = {compromisso1.Id}").Last();

            compromisso.Contato.Should().BeNull();
        }

        [TestMethod]
        public void ExcluirCompromisso()
        {
            Compromisso compromisso = new Compromisso("Fazer vaso de barro", "Casa da minha vó", new DateTime(2021, 06, 22, 10, 00, 00),
               new DateTime(2021, 06, 22, 12, 00, 00), null);

            controladorCompromisso.InserirRegistro(compromisso);

            controladorCompromisso.ExcluirRegistro(compromisso.Id);

            int qtdCadastrados = controladorCompromisso.Visualizar(controladorCompromisso.SqlSelecaoTodos).Count;

            qtdCadastrados.Should().Be(0);
        }
        [TestMethod]
        public void ValidarCompromissoDataMenor()
        {
            Compromisso compromisso = new Compromisso("Cortar grama", "Casa da minha vó", new DateTime(2021, 07, 19, 13, 00, 00),
               new DateTime(2021, 07, 19, 12, 00, 00), null);

            controladorCompromisso.ValidarDatas(compromisso).Should().Be("Data de conclusão menor que Data de Início.\n");
        }
        [TestMethod]
        public void ValidarCompromissoDataDiaDaSemana()
        {
            Compromisso compromisso = new Compromisso("Cortar grama", "Casa da minha vó", new DateTime(2021, 07, 18, 12, 00, 00),
               new DateTime(2021, 07, 18, 13, 00, 00), null);

            controladorCompromisso.ValidarDatas(compromisso).Should().Be("Dia da semana inválido.\n");
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